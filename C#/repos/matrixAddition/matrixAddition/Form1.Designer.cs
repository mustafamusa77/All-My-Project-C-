namespace matrixAddition
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(67, 49);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 0;
            label1.Text = "Enter in A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.IndianRed;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(296, 59);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 1;
            label2.Text = "Enter in B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.IndianRed;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(488, 59);
            label3.Name = "label3";
            label3.Size = new Size(105, 28);
            label3.TabIndex = 2;
            label3.Text = "Show in C";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(308, 349);
            button1.Name = "button1";
            button1.Size = new Size(122, 47);
            button1.TabIndex = 3;
            button1.Text = "Display";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(12, 101);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 200);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 28;
            listBox2.Location = new Point(266, 101);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(180, 200);
            listBox2.TabIndex = 5;
            // 
            // listBox3
            // 
            listBox3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 28;
            listBox3.Location = new Point(488, 101);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(180, 200);
            listBox3.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
    }
}
