namespace Libreria_Practicas
{
    partial class InicioSesionCliente
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
            textBox1 = new TextBox();
            LblLogin = new Label();
            textBox2 = new TextBox();
            BtnIniciarSesion = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 144);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ingrese Correo Electronico :";
            textBox1.Size = new Size(214, 23);
            textBox1.TabIndex = 0;
            // 
            // LblLogin
            // 
            LblLogin.AutoSize = true;
            LblLogin.ForeColor = SystemColors.ControlLightLight;
            LblLogin.Location = new Point(218, 68);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(37, 15);
            LblLogin.TabIndex = 1;
            LblLogin.Text = "Login";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 216);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Ingrese Contraseña:";
            textBox2.Size = new Size(214, 23);
            textBox2.TabIndex = 2;
            // 
            // BtnIniciarSesion
            // 
            BtnIniciarSesion.Location = new Point(188, 294);
            BtnIniciarSesion.Name = "BtnIniciarSesion";
            BtnIniciarSesion.Size = new Size(107, 23);
            BtnIniciarSesion.TabIndex = 3;
            BtnIniciarSesion.Text = "Iniciar Sesion";
            BtnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // InicioSesionCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(506, 430);
            Controls.Add(BtnIniciarSesion);
            Controls.Add(textBox2);
            Controls.Add(LblLogin);
            Controls.Add(textBox1);
            Name = "InicioSesionCliente";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label LblLogin;
        private TextBox textBox2;
        private Button BtnIniciarSesion;
    }
}
