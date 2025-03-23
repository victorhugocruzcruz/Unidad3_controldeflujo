namespace Practica5Triang
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 83);
            label1.Name = "label1";
            label1.Size = new Size(180, 26);
            label1.TabIndex = 0;
            label1.Text = "Longitud del lado A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 139);
            label2.Name = "label2";
            label2.Size = new Size(179, 26);
            label2.TabIndex = 1;
            label2.Text = "Longitud del lado B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 194);
            label3.Name = "label3";
            label3.Size = new Size(178, 26);
            label3.TabIndex = 2;
            label3.Text = "Longitud del lado C";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(24, 368);
            label4.Name = "label4";
            label4.Size = new Size(159, 26);
            label4.TabIndex = 3;
            label4.Text = "Tipo de triangulo";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic);
            textBox1.Location = new Point(268, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 33);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic);
            textBox2.Location = new Point(268, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(124, 33);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic);
            textBox3.Location = new Point(268, 191);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(124, 33);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Cursor = Cursors.No;
            textBox4.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic);
            textBox4.Location = new Point(209, 365);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(183, 33);
            textBox4.TabIndex = 7;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(24, 254);
            button1.Name = "button1";
            button1.Size = new Size(122, 53);
            button1.TabIndex = 8;
            button1.Text = "DECISIÓN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(157, 254);
            button2.Name = "button2";
            button2.Size = new Size(122, 53);
            button2.TabIndex = 9;
            button2.Text = "BORRAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(295, 254);
            button3.Name = "button3";
            button3.Size = new Size(122, 53);
            button3.TabIndex = 10;
            button3.Text = "SALIR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Help;
            pictureBox1.Image = Properties.Resources.Tipor_de_triangulos;
            pictureBox1.Location = new Point(439, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 385);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 22);
            label5.Name = "label5";
            label5.Size = new Size(409, 29);
            label5.TabIndex = 12;
            label5.Text = "IDENTIFICADOR DE TIPO DE TRIANGULO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(748, 436);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Calibri", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Identificador de tipo de triangulo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label5;
    }
}
