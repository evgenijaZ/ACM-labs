using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] array = new double[3, 4];
            Double.TryParse(textBox1.Text,  out array[0, 0]);
            Double.TryParse(textBox2.Text,  out array[0, 1]);
            Double.TryParse(textBox3.Text,  out array[0, 2]);
            Double.TryParse(textBox4.Text,  out array[1, 0]);
            Double.TryParse(textBox5.Text,  out array[1, 1]);
            Double.TryParse(textBox6.Text,  out array[1, 2]);
            Double.TryParse(textBox7.Text,  out array[2, 0]);
            Double.TryParse(textBox8.Text,  out array[2, 1]);
            Double.TryParse(textBox9.Text,  out array[2, 2]);
            Double.TryParse(textBox10.Text, out array[3, 0]);
            Double.TryParse(textBox11.Text, out array[3, 1]);
            Double.TryParse(textBox12.Text, out array[3, 2]);


           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1.Text = Convert.ToString(1.84);
            textBox2.Text = Convert.ToString(2.32);
            textBox3.Text = Convert.ToString(1.83);
            textBox4.Text = Convert.ToString(2.25);
            textBox5.Text = Convert.ToString(2.00);
            textBox6.Text = Convert.ToString(2.06);
            textBox7.Text = Convert.ToString(2.58);
            textBox8.Text = Convert.ToString(2.82);
            textBox9.Text = Convert.ToString(2.24);
            textBox10.Text = Convert.ToString(-6.09);
            textBox11.Text = Convert.ToString(-6.96);
            textBox12.Text = Convert.ToString(-5.53);

        }
    }
}
