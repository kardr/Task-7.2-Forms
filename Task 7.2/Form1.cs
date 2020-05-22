using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = Convert.ToString(textBox1.Text);
            string prepin = " ,.!:;?-";
            string[] razd = s.Split(prepin.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(razd, (a, b) => a.Length - b.Length);
            foreach (string w in razd)
            {
                textBox2.Text += "\n\r"+  w + "\n\r";
            }
        }
    }
}
