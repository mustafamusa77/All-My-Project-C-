namespace groupAss
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
            button1 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            button4 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.0173912F, FontStyle.Bold);
            label1.Location = new Point(114, 122);
            label1.Name = "label1";
            label1.Size = new Size(153, 21);
            label1.TabIndex = 0;
            label1.Text = "Name of Customre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.0173912F, FontStyle.Bold);
            label2.Location = new Point(114, 178);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 1;
            label2.Text = "Bill Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.0173912F, FontStyle.Bold);
            label3.Location = new Point(114, 238);
            label3.Name = "label3";
            label3.Size = new Size(146, 21);
            label3.TabIndex = 2;
            label3.Text = "Mode of Payment";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.0173912F, FontStyle.Bold);
            button1.Location = new Point(114, 296);
            button1.Name = "button1";
            button1.Size = new Size(145, 38);
            button1.TabIndex = 3;
            button1.Text = "Calculate Discount";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.0173912F, FontStyle.Bold);
            button3.Location = new Point(114, 448);
            button3.Name = "button3";
            button3.Size = new Size(145, 38);
            button3.TabIndex = 5;
            button3.Text = "Net Amount";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 8.139131F, FontStyle.Bold);
            textBox1.Location = new Point(303, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 25);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 8.139131F, FontStyle.Bold);
            textBox2.Location = new Point(303, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 25);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 8.139131F, FontStyle.Bold);
            textBox3.Location = new Point(303, 296);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(145, 25);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 8.139131F, FontStyle.Bold);
            textBox4.Location = new Point(303, 372);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(145, 25);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 8.139131F, FontStyle.Bold);
            textBox5.Location = new Point(303, 448);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(145, 25);
            textBox5.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 8.139131F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(303, 231);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 25);
            comboBox1.TabIndex = 11;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Segoe UI", 8.765218F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(303, 510);
            button4.Name = "button4";
            button4.Size = new Size(120, 42);
            button4.TabIndex = 12;
            button4.Text = "STOP";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.0173912F, FontStyle.Bold);
            label4.Location = new Point(114, 378);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 13;
            label4.Text = "Discount";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(618, 643);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private Button button4;
        private Label label4;
    }
}
