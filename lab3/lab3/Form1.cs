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
            this.WindowState = FormWindowState.Maximized;
            double t = 0;
            while (t <= 2)
            {
                Interpolation cInt = new Interpolation();
                double f1 = cInt.Function(t);
                chart1.Series[0].Points.AddXY(t, f1);
                chart2.Series[0].Points.AddXY(t, 0);
                t += 0.001;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;           
            int.TryParse(textBox2.Text, out n);
            double[] x = new double[n+1];
            double[] y = new double[n+1];
            Interpolation cInt = new Interpolation();
            cInt.CalculateNodes(x, y, 0, 2, n);
            textBox1.Clear();
            for (int i = 0; i <= n; i++)
            {
                textBox1.Text += x[i].ToString("F4") + '\t' + y[i].ToString("F4") + Environment.NewLine;
                
            }
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart2.Series[0].Points.Clear();
            
            double t = 0;
            while (t<=2) {
                double f1 = cInt.Function(t);
                chart1.Series[0].Points.AddXY(t,f1);
                double f2 = cInt.Polinom(t, n, 0, 2);
                chart1.Series[1].Points.AddXY(t,f2);
                chart2.Series[0].Points.AddXY(t, f2-f1);
                t += 0.001;
            }

        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart2.Series[0].Points.Clear();
            double t = 0;
            while (t <= 2)
            {
                Interpolation cInt = new Interpolation();
                double f1 = cInt.Function(t);
                chart1.Series[0].Points.AddXY(t, f1);
                chart2.Series[0].Points.AddXY(t, 0);
                t += 0.001;
            }
        }
    }
}
