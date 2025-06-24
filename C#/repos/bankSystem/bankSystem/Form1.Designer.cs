namespace bankSystem
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
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 32);
            label1.Name = "label1";
            label1.Size = new Size(224, 25);
            label1.TabIndex = 0;
            label1.Text = "Bank System Withdrawal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 129);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 1;
            label2.Text = "Withdrawal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 202);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 2;
            label3.Text = "Suffecient";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 267);
            label4.Name = "label4";
            label4.Size = new Size(309, 25);
            label4.TabIndex = 3;
            label4.Text = "limit : Enter Amount less than 1000";
            // 
            // button1
            // 
            button1.Location = new Point(151, 339);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "Check";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(376, 339);
            button2.Name = "button2";
            button2.Size = new Size(133, 34);
            button2.TabIndex = 5;
            button2.Text = "Withdrawal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(280, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(321, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(280, 199);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(321, 31);
            textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(880, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
