namespace Practica3Par_div3
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 64, 64);
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(46, 88);
            label1.Name = "label1";
            label1.Size = new Size(400, 39);
            label1.TabIndex = 0;
            label1.Text = "_____________________________________";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(0, 64, 64);
            label2.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(56, 148);
            label2.Name = "label2";
            label2.Size = new Size(186, 57);
            label2.TabIndex = 1;
            label2.Text = "Ingresa un número entero cualquiera";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Calibri", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(279, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(95, 37);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(56, 226);
            button1.Name = "button1";
            button1.Size = new Size(160, 47);
            button1.TabIndex = 3;
            button1.Text = "Determinar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(241, 226);
            button2.Name = "button2";
            button2.Size = new Size(160, 47);
            button2.TabIndex = 4;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(34, 9);
            label3.Name = "label3";
            label3.Size = new Size(401, 96);
            label3.TabIndex = 5;
            label3.Text = "Dado como dato un número entero determinar si es par o impar,  en caso de ser impar determinar si es divisible por 3.";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Calibri", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.Location = new Point(152, 293);
            button3.Name = "button3";
            button3.Size = new Size(160, 47);
            button3.TabIndex = 6;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(472, 357);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Calibri", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Número par o divisible entre 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label3;
        private Button button3;
    }
}
