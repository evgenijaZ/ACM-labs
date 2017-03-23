namespace lab2
{
    partial class FormSort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labeltime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelshow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть кількість елементів";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Зчитати масив з файлу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Згенерувати масив";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(348, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "Відсортувати масив";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(348, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 31);
            this.button4.TabIndex = 6;
            this.button4.Text = "Закрити";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Час сортування:";
            this.label2.Visible = false;
            // 
            // labeltime
            // 
            this.labeltime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labeltime.Location = new System.Drawing.Point(125, 119);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(110, 13);
            this.labeltime.TabIndex = 9;
            this.labeltime.Text = "0";
            this.labeltime.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Сортування масиву алгоритмом HeapSort";
            // 
            // labelshow
            // 
            this.labelshow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelshow.Location = new System.Drawing.Point(27, 139);
            this.labelshow.Multiline = true;
            this.labelshow.Name = "labelshow";
            this.labelshow.ReadOnly = true;
            this.labelshow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.labelshow.Size = new System.Drawing.Size(488, 128);
            this.labelshow.TabIndex = 11;
            // 
            // FormSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 310);
            this.Controls.Add(this.labelshow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labeltime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormSort";
            this.Text = "Сортування масиву";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox labelshow;
    }
}