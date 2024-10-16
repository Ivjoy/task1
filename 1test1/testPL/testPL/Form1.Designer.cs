namespace testPL
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
            n = new TextBox();
            m = new TextBox();
            button1 = new Button();
            listBoxResult = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // n
            // 
            n.Location = new Point(116, 54);
            n.Name = "n";
            n.PlaceholderText = "значение n";
            n.Size = new Size(100, 23);
            n.TabIndex = 0;
            n.KeyPress += n_KeyPress;
            // 
            // m
            // 
            m.Location = new Point(116, 200);
            m.Name = "m";
            m.PlaceholderText = "значение m";
            m.Size = new Size(100, 23);
            m.TabIndex = 1;
            m.KeyPress += m_KeyPress;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(179, 258);
            button1.Name = "button1";
            button1.Size = new Size(119, 42);
            button1.TabIndex = 3;
            button1.Text = "Решить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.ItemHeight = 15;
            listBoxResult.Location = new Point(284, 54);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(43, 169);
            listBoxResult.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(284, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(43, 29);
            textBox1.TabIndex = 5;
            textBox1.Text = "ПУТЬ";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(116, 158);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 29);
            textBox2.TabIndex = 6;
            textBox2.Text = "Значение M";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(116, 19);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 29);
            textBox3.TabIndex = 7;
            textBox3.Text = "Значение N";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 333);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBoxResult);
            Controls.Add(button1);
            Controls.Add(m);
            Controls.Add(n);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox n;
        private TextBox m;
        private Button button1;
        private ListBox listBoxResult;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
