namespace practica4
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(356, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(537, 33);
            label1.TabIndex = 1;
            label1.Text = "INTRODUSCA LAS DIMENSIONES DEL CILINDRO";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(200, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 33);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Aquamarine;
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(26, 224);
            button1.Name = "button1";
            button1.Size = new Size(119, 49);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 81);
            label2.Name = "label2";
            label2.Size = new Size(72, 29);
            label2.TabIndex = 1;
            label2.Text = "Radio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(73, 160);
            label3.Name = "label3";
            label3.Size = new Size(76, 29);
            label3.TabIndex = 1;
            label3.Text = "Altura";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(200, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 33);
            textBox2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(107, 302);
            label4.Name = "label4";
            label4.Size = new Size(97, 26);
            label4.TabIndex = 1;
            label4.Text = "Base área";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(107, 345);
            label5.Name = "label5";
            label5.Size = new Size(116, 26);
            label5.TabIndex = 1;
            label5.Text = "Lateral área";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(107, 389);
            label6.Name = "label6";
            label6.Size = new Size(98, 26);
            label6.TabIndex = 1;
            label6.Text = "Total área";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(107, 441);
            label7.Name = "label7";
            label7.Size = new Size(88, 26);
            label7.TabIndex = 1;
            label7.Text = "Volumen";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(254, 297);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(139, 31);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(254, 340);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(139, 31);
            textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(254, 384);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(139, 31);
            textBox5.TabIndex = 2;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(254, 436);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(139, 31);
            textBox6.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.Aquamarine;
            button2.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(181, 224);
            button2.Name = "button2";
            button2.Size = new Size(119, 49);
            button2.TabIndex = 3;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Aquamarine;
            button3.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.Location = new Point(333, 224);
            button3.Name = "button3";
            button3.Size = new Size(119, 49);
            button3.TabIndex = 4;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(558, 489);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Calibri", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Area del cilindro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button2;
        private Button button3;
    }
}
