namespace Practica6
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
            groupBox1 = new GroupBox();
            Valor1 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox3 = new GroupBox();
            Resultado = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Valor1);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(24, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 93);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // Valor1
            // 
            Valor1.Cursor = Cursors.IBeam;
            Valor1.Location = new Point(200, 37);
            Valor1.Name = "Valor1";
            Valor1.Size = new Size(106, 31);
            Valor1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 37);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 0;
            label1.Text = "Ingresa el Valor:";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(24, 150);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(359, 130);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Operaciones de Conversion";
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(106, 89);
            button3.Name = "button3";
            button3.Size = new Size(140, 35);
            button3.TabIndex = 2;
            button3.Text = "BORRAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(200, 36);
            button2.Name = "button2";
            button2.Size = new Size(140, 35);
            button2.TabIndex = 1;
            button2.Text = "CENTÍGRADOS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(20, 36);
            button1.Name = "button1";
            button1.Size = new Size(140, 35);
            button1.TabIndex = 0;
            button1.Text = "FAHRENHEIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Resultado);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(24, 286);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(359, 129);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resultado";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // Resultado
            // 
            Resultado.Cursor = Cursors.No;
            Resultado.Location = new Point(129, 78);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(100, 31);
            Resultado.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 39);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 0;
            label2.Text = "Equivalencia en";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 439);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Conversion de temperaturas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private Label label2;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox Valor1;
        private TextBox Resultado;
    }
}
