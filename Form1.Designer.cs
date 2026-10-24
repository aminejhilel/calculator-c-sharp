namespace calculator
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            lb_result = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 67);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "premier nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(383, 67);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 1;
            label2.Text = "deuxiemme nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(363, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 27);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(88, 226);
            button1.Name = "button1";
            button1.Size = new Size(68, 61);
            button1.TabIndex = 4;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(234, 226);
            button2.Name = "button2";
            button2.Size = new Size(68, 61);
            button2.TabIndex = 5;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(363, 226);
            button3.Name = "button3";
            button3.Size = new Size(68, 61);
            button3.TabIndex = 6;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(482, 226);
            button4.Name = "button4";
            button4.Size = new Size(68, 61);
            button4.TabIndex = 7;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(277, 342);
            label3.Name = "label3";
            label3.Size = new Size(110, 26);
            label3.TabIndex = 8;
            label3.Text = "resultat";
            // 
            // lb_result
            // 
            lb_result.AutoSize = true;
            lb_result.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_result.Location = new Point(317, 406);
            lb_result.Name = "lb_result";
            lb_result.Size = new Size(34, 24);
            lb_result.TabIndex = 9;
            lb_result.Text = "00";
            lb_result.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 548);
            Controls.Add(lb_result);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "calculatrice";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label3;
        private Label lb_result;
    }
}
