using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crush_Master
{
    public partial class Form2 : Form
    {
        class Player
        {
            public int X { get; set; }
            public int ID { get; private set; }

            public Player(int x, int id)
            {
                X = x;
                ID = id;
            }
        }

        static Socket socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
        static MemoryStream ms = new MemoryStream(new byte[256], 0, 256, true, true);
        static BinaryWriter writer = new BinaryWriter(ms);
        static BinaryReader reader = new BinaryReader(ms);

        static List<Player> players = new List<Player>();



        static Random random = new Random();

        static Player player;

        enum PacketInfo
        {
            ID, Position
        }

        int count = 3;
        //int move = 0;
        private readonly Game _game = new Game();
        public Form2()
        {
            //this.KeyPreview = true;
            //this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_Key);
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            //Cursor.Hide();
            _game.Size = Size;
          _game.Win += () =>
            {

                
                button3.Show();
                pictureBox1.Show();
                button4.Show();

            };

            _game.Loss += () =>
            {
               
                button3.Show();

                pictureBox1.Hide();
                button4.Show();

            };
            Application.Idle += delegate { Invalidate(); button3.Hide(); pictureBox1.Hide(); this.FormBorderStyle = FormBorderStyle.None; button4.Hide();};
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.None;
            pictureBox1.BackColor = Color.Transparent;
            _game.Start(count);
            // this.WindowState = FormWindowState.Maximized;

            socket.Connect("127.0.0.1", 2048);

            int x = Convert.ToInt32(Cursor.Position.X);

            SendPacket(PacketInfo.ID);
            int id = ReceivePacket();
            Thread.Sleep(1000);

            player = new Player(x, id);
            SendPacket(PacketInfo.Position);

            Task.Run(() => { while (true) ReceivePacket(); });

            Console.CursorVisible = false;

            while (true)
            {
               SendPacket(PacketInfo.Position);
               // _game.SetPaddle2Position(player.X);
                //MessageBox.Show(player.X.ToString());
            }

        }

        static void SendPacket(PacketInfo info)
        {
            switch (info)
            {
                case PacketInfo.ID:
                    writer.Write(0);
                    socket.Send(ms.GetBuffer());
                    break;

                case PacketInfo.Position:
                    writer.Write(1);
                    writer.Write(player.ID);
                    writer.Write(player.X);
                    socket.Send(ms.GetBuffer());
                    break;
            }
        }

        static int ReceivePacket()
        {
            ms.Position = 0;

            socket.Receive(ms.GetBuffer());

            int code = reader.ReadInt32();

            int id;
            int x;

            switch (code)
            {
                case 0:
                    return reader.ReadInt32();

                case 1:
                    id = reader.ReadInt32();
                    x = Convert.ToInt32(Cursor.Position.X);

                    Player plr = players.Find(p => p.ID == id);
                    if (plr != null)
                    {
                        plr.X = x;
                    }

                    else
                    {
                        plr = new Player(x, id);
                        players.Add(plr);
                    }
                    break;
            }
            return -1;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            _game.SetPaddlePosition(e.X);
        }

        /*private void Form2_Key(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Right) 
            {
                move += 100;
                _game.SetPaddle2Position(move);
            }
            if (e.KeyCode == Keys.Left)
            {
                move -= 100;
                _game.SetPaddle2Position(move);
            }
        }*/

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            _game.Update(e.Graphics);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            Menu menu1 = new Menu();
            this.Close();
            menu1.Show();
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.R)
            {
            _game.Start(count);
            button3.Hide(); 
            }
            
        }
    }
}
