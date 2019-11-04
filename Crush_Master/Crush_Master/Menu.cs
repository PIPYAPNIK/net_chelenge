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
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            pictureBox1.BackColor = Color.Transparent; this.FormBorderStyle = FormBorderStyle.None;

        }
        private void buttonSolo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 gameForm = new Form1();
            gameForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 gameForm1 = new Form1();
            gameForm1.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonMulty_Click(object sender, EventArgs e)
        {
            
            Form2 gameForm2 = new Form2();
            gameForm2.Show();
        }
    }
}
