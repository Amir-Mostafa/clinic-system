using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_file
{
    
    public partial class Form2 : Form
    {
        int gg = 0;
        public static Form2 fff;
        public Form2()
        {
            InitializeComponent();
            fff = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new login_form();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new users();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = new oppereations();
            f.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           button2.Enabled = false;
          // button3.Enabled = false;
           button4.Enabled = false;
           timer1.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                lblTitle.BackColor = Color.Black;
              
            if(label1.Location.X>this.Width)
            {
                label1.Location = new Point(0 - label1.Width, label1.Location.Y);
            }
            label1.Location = new Point(label1.Location.X + 3, label1.Location.Y);

        }
    }
}
