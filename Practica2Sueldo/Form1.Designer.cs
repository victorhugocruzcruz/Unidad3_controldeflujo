﻿namespace Practica2Sueldo
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(33, 9);
            label1.Name = "label1";
            label1.Size = new Size(360, 96);
            label1.TabIndex = 0;
            label1.Text = "Dado como dato el sueldo de un trabajador, el programa aplica un aumento del 15% si el sueldo es inferior a 400 mil pesos y en caso contrario el aumento es del 8%.";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 131);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 1;
            label2.Text = "Ingresar sueldo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 315);
            label3.Name = "label3";
            label3.Size = new Size(120, 23);
            label3.TabIndex = 2;
            label3.Text = "Nuevo Sueldo";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(232, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(232, 312);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(120, 31);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(61, 192);
            button1.Name = "button1";
            button1.Size = new Size(119, 43);
            button1.TabIndex = 5;
            button1.Text = "Decisión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(233, 192);
            button2.Name = "button2";
            button2.Size = new Size(119, 43);
            button2.TabIndex = 6;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(419, 378);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Aumento de salario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}
