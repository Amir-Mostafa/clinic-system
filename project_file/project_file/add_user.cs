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
    public partial class add_user : Form
    {
        public add_user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    if (File.Exists("login.txt"))
                    {
                        StreamWriter s = new StreamWriter("login.txt",true);
                        {
                            string add = textBox1.Text + "|" + textBox2.Text;
                            s.WriteLine(add);
                            s.Close();
                            MessageBox.Show("Ok");
                            this.Hide();
                        }
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        }
    }

