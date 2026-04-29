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
            buttonCount = new Button();
            buttonType = new Button();
            buttonFind = new Button();
            buttonInsert = new Button();
            buttonRemove = new Button();
            buttonRemoveAt = new Button();
            buttonClear = new Button();
            buttonContains = new Button();
            buttonAddRange = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // buttonCount
            // 
            buttonCount.Location = new Point(30, 12);
            buttonCount.Name = "buttonCount";
            buttonCount.Size = new Size(218, 36);
            buttonCount.TabIndex = 0;
            buttonCount.Text = "кількість елементів";
            buttonCount.UseVisualStyleBackColor = true;
            buttonCount.Click += buttonCount_Click;
            // 
            // buttonType
            // 
            buttonType.Location = new Point(30, 47);
            buttonType.Name = "buttonType";
            buttonType.Size = new Size(218, 36);
            buttonType.TabIndex = 1;
            buttonType.Text = "тип елемента";
            buttonType.UseVisualStyleBackColor = true;
            buttonType.Click += buttonType_Click;
            // 
            // buttonFind
            // 
            buttonFind.Location = new Point(30, 82);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(218, 36);
            buttonFind.TabIndex = 2;
            buttonFind.Text = "пошук";
            buttonFind.UseVisualStyleBackColor = true;
            buttonFind.Click += buttonFind_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(30, 117);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(218, 36);
            buttonInsert.TabIndex = 3;
            buttonInsert.Text = "вставка";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(30, 152);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(218, 36);
            buttonRemove.TabIndex = 4;
            buttonRemove.Text = "видалення рядка";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonRemoveAt
            // 
            buttonRemoveAt.Location = new Point(30, 187);
            buttonRemoveAt.Name = "buttonRemoveAt";
            buttonRemoveAt.Size = new Size(218, 36);
            buttonRemoveAt.TabIndex = 5;
            buttonRemoveAt.Text = "видалення за індексом";
            buttonRemoveAt.UseVisualStyleBackColor = true;
            buttonRemoveAt.Click += buttonRemoveAt_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(30, 222);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(218, 36);
            buttonClear.TabIndex = 6;
            buttonClear.Text = "очистка";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonContains
            // 
            buttonContains.Location = new Point(30, 257);
            buttonContains.Name = "buttonContains";
            buttonContains.Size = new Size(218, 36);
            buttonContains.TabIndex = 7;
            buttonContains.Text = "перевірка";
            buttonContains.UseVisualStyleBackColor = true;
            buttonContains.Click += buttonContains_Click;
            // 
            // buttonAddRange
            // 
            buttonAddRange.Location = new Point(30, 292);
            buttonAddRange.Name = "buttonAddRange";
            buttonAddRange.Size = new Size(218, 36);
            buttonAddRange.TabIndex = 8;
            buttonAddRange.Text = "додати масив";
            buttonAddRange.UseVisualStyleBackColor = true;
            buttonAddRange.Click += buttonAddRange_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Яблуко", "", "Банан", "", "Апельсин", "", "Груша" });
            listBox1.Location = new Point(339, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(241, 224);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(339, 319);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(buttonAddRange);
            Controls.Add(buttonContains);
            Controls.Add(buttonClear);
            Controls.Add(buttonRemoveAt);
            Controls.Add(buttonRemove);
            Controls.Add(buttonInsert);
            Controls.Add(buttonFind);
            Controls.Add(buttonType);
            Controls.Add(buttonCount);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCount;
        private Button buttonType;
        private Button buttonFind;
        private Button buttonInsert;
        private Button buttonRemove;
        private Button buttonRemoveAt;
        private Button buttonClear;
        private Button buttonContains;
        private Button buttonAddRange;
        private ListBox listBox1;
        private TextBox textBox1;
    }
}
