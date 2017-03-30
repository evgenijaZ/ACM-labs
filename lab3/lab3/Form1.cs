using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Interpolation;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] x = new double[11];
            double[] y = new double[11];
            Interpolation cInt = new Interpolation();
            cInt.CalculateNodes(x, y, 0, 2);
            textBox1.Clear();
            for (int i = 0; i <= 10; i++)
            {
                textBox1.Text += x[i].ToString() + '\t' + y[i].ToString("F4") + Environment.NewLine ;
            }
        }
    }
}
