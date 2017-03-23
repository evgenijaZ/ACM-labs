using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HeapSort;
namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void відсортуватиМасивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSort fSort = new FormSort();
            fSort.Show();

        }

        private void довідкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo fInfo = new FormInfo();
            fInfo.Show();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numbArrays, step;

            bool result1 = int.TryParse(textBox1.Text, out numbArrays);
            if (result1)
            {
                if (numbArrays > 0)
                {
                    bool result2 = int.TryParse(textBox2.Text, out step);
                    if (result2)
                    {
                        if (step > 0)
                        {
                            HeapSort hs = new HeapSort();
                            hs.makeData(numbArrays, step);
                            button2.Enabled = true;

                            chart1.Series[0].Points.Clear();
                            chart1.Series[1].Points.Clear();
                            for (int i = 0; i < numbArrays; i++)
                            {
                                chart1.Series[0].Points.AddXY(i * step, (i * step * Math.Log10(i * step)));
                            }
                        }
                        else
                        {
                            MessageBox.Show("Крок має бути додатнім", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Невірно введені дані у полі \"Крок\"", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Кількість має бути додатньою", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Невірно введені дані у полі \"Кількість\"", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 200; i++ ) {
                chart1.Series[0].Points.AddXY(i * 20, (i * 20 * Math.Log10(i * 20)));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string path = @"data.txt";
            if (!System.IO.File.Exists(path))
            {
                MessageBox.Show("Відсутній файл", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(path))
                {
                    string line;
                    while (!sr.EndOfStream)
                    {
                       line = sr.ReadLine();
                       double[] arr = line.Split(' ').Select(x => double.Parse(x)).ToArray();
                       chart1.Series[1].Points.AddXY(arr[0], arr[1]*5000);
                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
          //  chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
        }
    }
}
