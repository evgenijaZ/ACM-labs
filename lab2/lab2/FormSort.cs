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
using System.IO;
namespace lab2
{
    public partial class FormSort : Form
    {
        public FormSort()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s="";
            int[] arr = null;
            try
            {
                s = System.IO.File.ReadAllText("array.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка читання з файлу\n"+ ex.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                arr = s.Split(' ').Select(x => int.Parse(x)).ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невірно введені дані. " + ex.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            labelshow.Text = string.Join(" ", arr);
            textBox1.Text = arr.Length.ToString();
            button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numbArrays;
            bool result =  int.TryParse(textBox1.Text,out numbArrays);
            if (result)
            {
                if (numbArrays > 0)
                {
                    HeapSort hs = new HeapSort();
                    labelshow.Text = hs.runGenerate(numbArrays);
                    button3.Enabled = true;
                }
                else {
                    MessageBox.Show("Число має бути додатнім", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Невірно введені дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            
            int numbArrays;
            numbArrays = int.Parse(textBox1.Text);
            int[] arr = this.labelshow.Text.Split(' ').Select(x => int.Parse(x)).ToArray();
            HeapSort hs = new HeapSort();
            System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
            swatch.Start();
            labelshow.Text = hs.runSort(numbArrays, arr);
            swatch.Stop();
            labeltime.Text = swatch.Elapsed.ToString();
            label2.Visible = true;
            labeltime.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
