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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(!Directory.Exists("D:/clinic"))
            {
                Directory.CreateDirectory("D:/clinic");
            }
            if (!File.Exists("login.txt"))
            {
                StreamWriter s = new StreamWriter("login.txt");
                s.WriteLine("amir|123");
                s.Close();
            }
            timer1.Start();
            if(!File.Exists("pationts.txt"))
            {
                File.Create("pationts.txt");
                    
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if(progressBar1.Value!=100)
            {
                progressBar1.Value += 5;
            }
            else
            {
                timer1.Stop();
                this.Hide();
                Form f = new Form2();
                f.Show();
            }
        }
    }
}
