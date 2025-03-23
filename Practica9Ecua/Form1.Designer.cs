namespace Practica9Ecua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 36F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(199, 13);
            label1.Name = "label1";
            label1.Size = new Size(224, 59);
            label1.TabIndex = 0;
            label1.Text = "Z = X² + X³";
            // 
            // label2
            // 
            label2.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(31, 80);
            label2.Name = "label2";
            label2.Size = new Size(122, 31);
            label2.TabIndex = 1;
            label2.Text = "X";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(171, 80);
            label3.Name = "label3";
            label3.Size = new Size(122, 31);
            label3.TabIndex = 2;
            label3.Text = "X²";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(320, 80);
            label4.Name = "label4";
            label4.Size = new Size(122, 31);
            label4.TabIndex = 3;
            label4.Text = "X³";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(467, 80);
            label5.Name = "label5";
            label5.Size = new Size(121, 31);
            label5.TabIndex = 4;
            label5.Text = "Z";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            listBox1.Cursor = Cursors.No;
            listBox1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(23, 115);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(122, 213);
            listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            listBox2.Cursor = Cursors.No;
            listBox2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 19;
            listBox2.Location = new Point(171, 115);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(122, 213);
            listBox2.TabIndex = 6;
            // 
            // listBox3
            // 
            listBox3.Cursor = Cursors.No;
            listBox3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 19;
            listBox3.Location = new Point(320, 115);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(122, 213);
            listBox3.TabIndex = 7;
            // 
            // listBox4
            // 
            listBox4.Cursor = Cursors.No;
            listBox4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 19;
            listBox4.Location = new Point(467, 115);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(121, 213);
            listBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(171, 360);
            button1.Name = "button1";
            button1.Size = new Size(271, 38);
            button1.TabIndex = 9;
            button1.Text = "CALCULAR VALORES";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(627, 420);
            Controls.Add(button1);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Ecuaciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private Button button1;
    }
}
