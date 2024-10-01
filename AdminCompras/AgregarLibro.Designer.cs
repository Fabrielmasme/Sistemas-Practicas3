namespace Libreria_Practicas.AdminCompras
{
    partial class AgregarLibro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Codigo :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(42, 240);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Cantidad :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(42, 211);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "Precio :";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(42, 182);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            textBox4.Text = "Autor :";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(42, 153);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 4;
            textBox5.Text = "Descripcion :";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(42, 124);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 5;
            textBox6.Text = "Genero :";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(42, 95);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 6;
            textBox7.Text = "Nombre :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(387, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 257);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(559, 401);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // AgregarLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(646, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "AgregarLibro";
            Text = "AgregarLibro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private PictureBox pictureBox1;
        private Button button1;
    }
}