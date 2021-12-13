using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder a = new StringBuilder(textBox1.Text);
            string buf = textBox2.Text;


            a.Replace(buf[0].ToString().ToLower(), "");
            a.Replace(buf[0].ToString().ToUpper(), "");
            result.Text=($"Результат:\nИзмененная строка: {a}");
        }
    }
}
