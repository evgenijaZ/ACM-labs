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
            Double.TryParse(textBox2.Text,  out array[1, 0]);
            Double.TryParse(textBox3.Text,  out array[2, 0]);
            Double.TryParse(textBox4.Text,  out array[0, 1]);
            Double.TryParse(textBox5.Text,  out array[1, 1]);
            Double.TryParse(textBox6.Text,  out array[2, 1]);
            Double.TryParse(textBox7.Text,  out array[0, 2]);
            Double.TryParse(textBox8.Text,  out array[1, 2]);
            Double.TryParse(textBox9.Text,  out array[2, 2]);
            Double.TryParse(textBox10.Text, out array[0, 3]);
            Double.TryParse(textBox11.Text, out array[1, 3]);
            Double.TryParse(textBox12.Text, out array[2, 3]);

            Solver s = new Solver();
            s.TransformMatrix(array, 3, 4);

            
            textBox1.Text = array[0, 0].ToString("F5");
            textBox2.Text = array[1, 0].ToString("F5");
            textBox3.Text = array[2, 0].ToString("F5");
            textBox4.Text = array[0, 1].ToString("F5");
            textBox5.Text = array[1, 1].ToString("F5");
            textBox6.Text = array[2, 1].ToString("F5");
            textBox7.Text = array[0, 2].ToString("F5");
            textBox8.Text = array[1, 2].ToString("F5");
            textBox9.Text = array[2, 2].ToString("F5");
            textBox10.Text = array[0, 3].ToString("F5"); 
            textBox11.Text = array[1, 3].ToString("F5");
            textBox12.Text = array[2, 3].ToString("F5");

            double x1 = 0, x2 = 0, x3 = 0;
            s.CalculateRoots(array, ref x1, ref x2, ref x3);
            textBox13.Text = x1.ToString("F5");
            textBox14.Text = x2.ToString("F5");
            textBox15.Text = x3.ToString("F5");


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
            textBox12.Text = Convert.ToString(-5.52);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void довідкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Info = new Form2();
            Info.Show();
        }
    }
}
