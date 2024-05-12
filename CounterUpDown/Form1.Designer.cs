namespace CounterUpDown
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
            n1 = new Button();
            textBox1 = new TextBox();
            n2 = new Button();
            n3 = new Button();
            SuspendLayout();
            // 
            // n1
            // 
            n1.Font = new Font("Segoe UI", 12F);
            n1.Location = new Point(298, 56);
            n1.Margin = new Padding(3, 2, 3, 2);
            n1.Name = "n1";
            n1.Size = new Size(47, 38);
            n1.TabIndex = 0;
            n1.Text = "+";
            n1.UseVisualStyleBackColor = true;
            n1.Click += n1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(138, 82);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 39);
            textBox1.TabIndex = 1;
            textBox1.Text = "1";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // n2
            // 
            n2.Font = new Font("Segoe UI", 12F);
            n2.Location = new Point(298, 110);
            n2.Margin = new Padding(3, 2, 3, 2);
            n2.Name = "n2";
            n2.Size = new Size(47, 38);
            n2.TabIndex = 2;
            n2.Text = "-";
            n2.UseVisualStyleBackColor = true;
            n2.Click += n2_Click;
            // 
            // n3
            // 
            n3.Font = new Font("Segoe UI", 12F);
            n3.Location = new Point(138, 148);
            n3.Margin = new Padding(3, 2, 3, 2);
            n3.Name = "n3";
            n3.Size = new Size(109, 30);
            n3.TabIndex = 3;
            n3.Text = "Set to 0";
            n3.UseVisualStyleBackColor = true;
            n3.Click += n3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 244);
            Controls.Add(n3);
            Controls.Add(n2);
            Controls.Add(textBox1);
            Controls.Add(n1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button n1;
        private TextBox textBox1;
        private Button n2;
        private Button n3;
    }
}
