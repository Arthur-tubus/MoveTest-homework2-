namespace hw2
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
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 19.8000011F, FontStyle.Bold);
            label1.Location = new Point(36, 119);
            label1.Name = "label1";
            label1.Size = new Size(392, 41);
            label1.TabIndex = 0;
            label1.Text = "                                             Test";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            label1.MouseDown += label1_MouseDown;
            label1.MouseMove += label1_MouseMove;
            label1.MouseUp += label1_MouseUp;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 16.2F);
            button1.Location = new Point(305, 251);
            button1.Name = "button1";
            button1.Size = new Size(157, 60);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseDown += button1_MouseDown;
            button1.MouseMove += button1_MouseMove;
            button1.MouseUp += button1_MouseUp;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(305, 192);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 27);
            textBox1.TabIndex = 2;
            textBox1.Visible = false;
            textBox1.Click += textBox1_Click;
            textBox1.MouseDown += textBox1_MouseDown;
            textBox1.MouseMove += textBox1_MouseMove;
            textBox1.MouseUp += textBox1_MouseUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(358, 195);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            label2.Visible = false;
            label2.Click += label2_Click;
            label2.MouseDown += label2_MouseDown;
            label2.MouseMove += label2_MouseMove;
            label2.MouseUp += label2_MouseUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(721, 410);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "label3";
            label3.Visible = false;
            label3.Click += label3_Click;
            label3.MouseDown += label3_MouseDown;
            label3.MouseMove += label3_MouseMove;
            label3.MouseUp += label3_MouseUp;
            // 
            // button2
            // 
            button2.Font = new Font("Calibri", 16.2F);
            button2.Location = new Point(305, 329);
            button2.Name = "button2";
            button2.Size = new Size(157, 60);
            button2.TabIndex = 5;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            button2.MouseClick += button2_MouseClick;
            button2.MouseDown += button2_MouseDown;
            button2.MouseMove += button2_MouseMove;
            button2.MouseUp += button2_MouseUp;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(647, 34);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 6;
            label4.Text = "Закінчити тест?";
            label4.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        private void LoadPositions()
        {
            if (File.Exists(SaveFile))
            {
                string[] lines = File.ReadAllLines(SaveFile);
                if (lines.Length >= 6)
                {
                    label1.Location = ParsePoint(lines[0]);
                    label2.Location = ParsePoint(lines[1]);
                    label3.Location = ParsePoint(lines[2]);
                    button1.Location = ParsePoint(lines[3]);
                    button2.Location = ParsePoint(lines[4]);
                    textBox1.Location = ParsePoint(lines[5]);
                    
                }
            }
        }
        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Label label4;
    }
}
