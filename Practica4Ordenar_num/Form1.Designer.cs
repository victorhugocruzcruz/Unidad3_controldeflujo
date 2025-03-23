namespace Practica4Ordenar_num
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(39, 78);
            label1.Name = "label1";
            label1.Size = new Size(496, 29);
            label1.TabIndex = 0;
            label1.Text = "ORDENAR TRES NÚMEROS DE MAYOR A MENOR";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(55, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(99, 33);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(204, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(99, 33);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(345, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(99, 33);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Cursor = Cursors.No;
            textBox4.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(39, 351);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(126, 33);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Cursor = Cursors.No;
            textBox5.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(189, 351);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(124, 33);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Cursor = Cursors.No;
            textBox6.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(334, 351);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(123, 33);
            textBox6.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(39, 241);
            button1.Name = "button1";
            button1.Size = new Size(125, 56);
            button1.TabIndex = 7;
            button1.Text = "ORDENAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(189, 241);
            button2.Name = "button2";
            button2.Size = new Size(124, 56);
            button2.TabIndex = 8;
            button2.Text = "BORRAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Brown;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.Location = new Point(333, 241);
            button3.Name = "button3";
            button3.Size = new Size(124, 56);
            button3.TabIndex = 9;
            button3.Text = "SALIR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(86, 190);
            label2.Name = "label2";
            label2.Size = new Size(25, 26);
            label2.TabIndex = 10;
            label2.Text = "A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(192, 0, 0);
            label3.Location = new Point(237, 190);
            label3.Name = "label3";
            label3.Size = new Size(24, 26);
            label3.TabIndex = 11;
            label3.Text = "B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(386, 190);
            label4.Name = "label4";
            label4.Size = new Size(23, 26);
            label4.TabIndex = 12;
            label4.Text = "C";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_del_tec_en_gris;
            pictureBox1.Location = new Point(386, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(565, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Ordenador de 3 números";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
    }
}
