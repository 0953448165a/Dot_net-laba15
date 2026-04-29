namespace WinFormsApp1
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
            buttonStart = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxXmin = new TextBox();
            textBoxXmax = new TextBox();
            textBoxDx = new TextBox();
            textBoxK = new TextBox();
            textBoxBeta = new TextBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(483, 236);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(94, 29);
            buttonStart.TabIndex = 0;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 40);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 1;
            label1.Text = "x_min";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 93);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "x_max";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 133);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 3;
            label3.Text = "dx";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 166);
            label4.Name = "label4";
            label4.Size = new Size(16, 20);
            label4.TabIndex = 4;
            label4.Text = "k";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 208);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 5;
            label5.Text = "β (beta)";
            label5.Click += label5_Click;
            // 
            // textBoxXmin
            // 
            textBoxXmin.Location = new Point(217, 40);
            textBoxXmin.Name = "textBoxXmin";
            textBoxXmin.Size = new Size(125, 27);
            textBoxXmin.TabIndex = 6;
            textBoxXmin.TextChanged += textBox1_TextChanged;
            // 
            // textBoxXmax
            // 
            textBoxXmax.Location = new Point(217, 90);
            textBoxXmax.Name = "textBoxXmax";
            textBoxXmax.Size = new Size(125, 27);
            textBoxXmax.TabIndex = 7;
            // 
            // textBoxDx
            // 
            textBoxDx.Location = new Point(217, 130);
            textBoxDx.Name = "textBoxDx";
            textBoxDx.Size = new Size(125, 27);
            textBoxDx.TabIndex = 8;
            // 
            // textBoxK
            // 
            textBoxK.Location = new Point(217, 171);
            textBoxK.Name = "textBoxK";
            textBoxK.Size = new Size(125, 27);
            textBoxK.TabIndex = 9;
            // 
            // textBoxBeta
            // 
            textBoxBeta.Location = new Point(217, 208);
            textBoxBeta.Name = "textBoxBeta";
            textBoxBeta.Size = new Size(125, 27);
            textBoxBeta.TabIndex = 10;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(414, 40);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(252, 164);
            listBox1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 328);
            Controls.Add(listBox1);
            Controls.Add(textBoxBeta);
            Controls.Add(textBoxK);
            Controls.Add(textBoxDx);
            Controls.Add(textBoxXmax);
            Controls.Add(textBoxXmin);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStart;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxXmin;
        private TextBox textBoxXmax;
        private TextBox textBoxDx;
        private TextBox textBoxK;
        private TextBox textBoxBeta;
        private ListBox listBox1;
    }
}
