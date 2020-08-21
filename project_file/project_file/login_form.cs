using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace project_file
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool f=false;
            StreamReader s = new StreamReader("login.txt");
            while(true)
            {
                string ss=s.ReadLine();
                if (ss == null)
                {
                    break;
                }
              //  string ss = arr[i];
                int x = ss.IndexOf('|');
                string s1 = ss.Substring(0, x);
                string s2 = ss.Substring(x + 1);
                if(s1==textBox1.Text&&s2==textBox2.Text)
                {
                    Form2.fff.button2.Enabled = true;
                   Form2.fff.button1.Enabled = false;
                    Form2.fff.button4.Enabled = true;
               //     Form2.fff.Controls.Remove(label1);
                    f = true;
                    this.Hide();
                    break;
                }
            }
            if(f==false)
                MessageBox.Show("wronge  "+textBox1.Text+"  "+textBox2.Text);
            s.Close();
        }
    }
}
