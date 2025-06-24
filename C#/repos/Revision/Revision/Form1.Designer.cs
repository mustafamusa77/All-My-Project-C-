namespace Revision
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 65);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 0;
            label1.Text = "Name of the customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 119);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Bill amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 172);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 2;
            label3.Text = "Mode of payment";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(336, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(369, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(336, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(369, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(336, 281);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(369, 27);
            textBox3.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(336, 164);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(369, 28);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(336, 341);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(369, 27);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(336, 393);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(369, 27);
            textBox5.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(159, 279);
            button1.Name = "button1";
            button1.Size = new Size(150, 35);
            button1.TabIndex = 9;
            button1.Text = "Calculate Discount";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(159, 336);
            button2.Name = "button2";
            button2.Size = new Size(150, 36);
            button2.TabIndex = 10;
            button2.Text = "Discount";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(159, 393);
            button3.Name = "button3";
            button3.Size = new Size(150, 37);
            button3.TabIndex = 11;
            button3.Text = "Net Amount";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(578, 464);
            button4.Name = "button4";
            button4.Size = new Size(127, 36);
            button4.TabIndex = 12;
            button4.Text = "Stop";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 538);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Glamar Garment";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
