using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Solver;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Solver s = new Solver();
            double a = -5.5, b = 5.5;
            double x = a;
            while (x<=b) {
                chart1.Series[0].Points.AddXY(x,s.Function(x));
                chart1.Series[1].Points.AddXY(x,0);
                x += 0.005;
            }
            chart1.Series[2].Points.AddXY(1.02987, 0);
            chart1.Series[2].Points.AddXY(-1.02987, 0);
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = 0.25;
            chart1.ChartAreas[0].AxisY.MajorGrid.Interval = 0.5;
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, eps = 0;
            bool result = double.TryParse(textBox1.Text, out a);
            if (!result) { MessageBox.Show("Некоректно введене значення a", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            result = result && double.TryParse(textBox2.Text, out b);
            if (!result) { MessageBox.Show("Некоректно введене значення b", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            result = result && double.TryParse(textBox3.Text, out eps);
            if (!result) { MessageBox.Show("Некоректно введене значення e (точність)", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (result)
            {
               
                int k = 0;
                double x = 0;
                Solver s = new Solver();
                if (s.FindNode(a, b, eps, ref x, ref k))
                {
                    textBox4.Text = x.ToString();
                }
                else {
                    MessageBox.Show("Функція не має коренів на цьому проміжку", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
