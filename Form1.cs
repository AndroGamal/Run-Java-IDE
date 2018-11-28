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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            button1.Size = new System.Drawing.Size(this.Width - 36, 23);
            button2.Size = new System.Drawing.Size(this.Width - 36, 23);
            this.button1.Location = new Point(12, this.Height - 73);
            this.button2.Location = new Point(12, this.Height - 102);
            this.textBox1.Size = new Size(this.Width-36,23);
            this.textBox1.Location = new Point(12,this.Height -128);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2();
            m.k = textBox1.Text;
            StreamWriter b = new StreamWriter(m.k + ".java");
            b.WriteLine(b.NewLine+b.NewLine+"public class " + m.k + " {"+b.NewLine+"   public static void main(String[] args)"+b.NewLine+" {"+b.NewLine+b.NewLine+"}"+"}");
            b.Close();
            Visible = false;
            m.ShowDialog();
            Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2();
            m.k = textBox1.Text;
            Visible = false;
            m.ShowDialog();
            Visible = true;
        }
    }
}
