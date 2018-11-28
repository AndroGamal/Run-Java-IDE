using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public bool n = false;
        public string k;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            button1.Size = new System.Drawing.Size(this.Width-160,23);
            textBox1.Size = new System.Drawing.Size(this.Width - 40, this.Height - 91);
        }

        private void button1_Click(object sender, EventArgs e)
        {
         try {
           StreamWriter b = new StreamWriter(k+".java");
           b.Flush();
           b.Write(textBox1.Text);
           b.Close();
                Process m = new Process();
                m.StartInfo.FileName = "cmd.exe";
                m.StartInfo.Arguments = "/c javac "+k+".java";
                m.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                this.Cursor = Cursors.AppStarting;
                if (m.Start()) { m.WaitForExit();
                    m.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                    m.StartInfo.FileName = "andro.exe";
                    b = new StreamWriter("AndroSet.inf");
                    b.Flush();
                    b.Write("java " + k+b.NewLine);
                    b.Close();
                    m.Start();
                }
                this.Cursor = Cursors.Default;
           }
          catch { MessageBox.Show("error"); this.Cursor = Cursors.Default; }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader m = new StreamReader(k + ".java");
                textBox1.Text = m.ReadToEnd();
                m.Close();
            }
            catch { 
                MessageBox.Show("the "+k+" is not found");
                this.Close();
            }
        }
    }
}
