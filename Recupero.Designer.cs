namespace Libreria_Practicas
{
    partial class Recupero
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
            BtnIniciarSesion = new Button();
            textBox2 = new TextBox();
            LblLogin = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // BtnIniciarSesion
            // 
            BtnIniciarSesion.Location = new Point(326, 301);
            BtnIniciarSesion.Name = "BtnIniciarSesion";
            BtnIniciarSesion.Size = new Size(131, 23);
            BtnIniciarSesion.TabIndex = 7;
            BtnIniciarSesion.Text = "Recuperar Contraseña";
            BtnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(287, 229);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Ingrese nueva contraseña:";
            textBox2.Size = new Size(214, 23);
            textBox2.TabIndex = 6;
            // 
            // LblLogin
            // 
            LblLogin.AutoSize = true;
            LblLogin.ForeColor = SystemColors.ControlLightLight;
            LblLogin.Location = new Point(370, 99);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(57, 15);
            LblLogin.TabIndex = 5;
            LblLogin.Text = "Recupero";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(287, 175);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ingrese Correo Electronico :";
            textBox1.Size = new Size(214, 23);
            textBox1.TabIndex = 4;
            // 
            // Recupero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnIniciarSesion);
            Controls.Add(textBox2);
            Controls.Add(LblLogin);
            Controls.Add(textBox1);
            Name = "Recupero";
            Text = "Recupero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnIniciarSesion;
        private TextBox textBox2;
        private Label LblLogin;
        private TextBox textBox1;
    }
}