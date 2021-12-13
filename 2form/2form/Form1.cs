using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            StringBuilder a = new StringBuilder(textBox1.Text);
            string[] buf = a.ToString().Split(' ', ',', '.', '!', '?', '-', '\'', '\\', '\"', '*');
            for (int i = 0; i < buf.Length; i++)
            {
                if (buf[i].ToLower() == textBox2.Text.ToLower())
                    sum++;
            }
           result.Text=($"Результат:\nКоличество повторений: {sum}\n");

        }
    }
}
