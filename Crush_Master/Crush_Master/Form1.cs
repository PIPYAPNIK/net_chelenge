using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crush_Master
{
    public partial class Form1 : Form
    {
        int count = 0;
        private readonly Game _game = new Game();
        public Form1()
        {

            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            //Cursor.Hide();
            _game.Size = Size;
            _game.Win += () =>
            {

                if (count == 0) { button2.Enabled = false; }
                else { button2.Enabled = true; }
                if (count == 2) { button1.Enabled = false; }
                else { button1.Enabled = true; }
                button1.Show();
                button2.Show();
                button3.Show();
                pictureBox1.Show();
                button4.Show();

            };

            _game.Loss += () =>
            {
                if (count == 0) { button2.Enabled = false; }
                else { button2.Enabled = true; }
                button1.Enabled = false;
                button3.Show();
                button2.Show();
                button1.Show();
                pictureBox1.Hide();
                button4.Show();

            };
            Application.Idle += delegate { Invalidate(); button1.Hide(); button2.Hide(); button3.Hide(); pictureBox1.Hide(); this.FormBorderStyle = FormBorderStyle.None; button4.Hide(); };
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            _game.SetPaddlePosition(e.X);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            _game.Update(e.Graphics);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            pictureBox1.BackColor = Color.Transparent;
            _game.Start(count);
           // this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count += 1;
            _game.Start(count);
            button1.Hide();
            button2.Hide();
            button3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count -= 1;
            _game.Start(count);
            button1.Hide();
            button2.Hide();
            button3.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }
        /*private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape);
               
        }*/

        private void button4_Click(object sender, EventArgs e)
        {
            Menu menu1 = new Menu();
            this.Close();
            menu1.Show();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void R(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.R)
            {
             _game.Start(count);
            button3.Hide();
            }
        }
    }
}
