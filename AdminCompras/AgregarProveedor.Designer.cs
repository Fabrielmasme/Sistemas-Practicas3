namespace Libreria_Practicas.AdminCompras
{
    partial class AgregarProveedor
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(30, 27);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Agregar Proveedor";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "Nombre proveedor :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 304);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 23);
            textBox2.TabIndex = 2;
            textBox2.Text = "ISBN :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(30, 275);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(166, 23);
            textBox3.TabIndex = 3;
            textBox3.Text = "Nombre Libro :";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(30, 246);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(166, 23);
            textBox4.TabIndex = 4;
            textBox4.Text = "Direccion :";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(30, 217);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(166, 23);
            textBox5.TabIndex = 5;
            textBox5.Text = "Correo Electronico :";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(30, 188);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(166, 23);
            textBox6.TabIndex = 6;
            textBox6.Text = "Telefono :";
            // 
            // button1
            // 
            button1.Location = new Point(264, 393);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 7;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // AgregarProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(384, 450);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AgregarProveedor";
            Text = "AgregarProveedor";
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
    }
}