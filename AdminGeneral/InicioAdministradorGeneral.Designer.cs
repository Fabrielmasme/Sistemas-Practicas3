namespace Libreria_Practicas.AdminGeneral
{
    partial class InicioAdministradorGeneral
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
            BtnOrdenarMenorPrecio = new Button();
            BtnOrdenarMayorPrecio = new Button();
            BtnBuscar = new Button();
            BtnCerrarSesion = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtnOrdenarMenorPrecio
            // 
            BtnOrdenarMenorPrecio.Location = new Point(12, 173);
            BtnOrdenarMenorPrecio.Name = "BtnOrdenarMenorPrecio";
            BtnOrdenarMenorPrecio.Size = new Size(157, 29);
            BtnOrdenarMenorPrecio.TabIndex = 15;
            BtnOrdenarMenorPrecio.Text = "Gestion de caja";
            BtnOrdenarMenorPrecio.UseVisualStyleBackColor = true;
            // 
            // BtnOrdenarMayorPrecio
            // 
            BtnOrdenarMayorPrecio.Location = new Point(12, 86);
            BtnOrdenarMayorPrecio.Name = "BtnOrdenarMayorPrecio";
            BtnOrdenarMayorPrecio.Size = new Size(157, 29);
            BtnOrdenarMayorPrecio.TabIndex = 14;
            BtnOrdenarMayorPrecio.Text = "Control de usuarios";
            BtnOrdenarMayorPrecio.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(329, 16);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(65, 39);
            BtnBuscar.TabIndex = 13;
            BtnBuscar.Text = "Perfil";
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // BtnCerrarSesion
            // 
            BtnCerrarSesion.Location = new Point(441, 16);
            BtnCerrarSesion.Name = "BtnCerrarSesion";
            BtnCerrarSesion.Size = new Size(67, 39);
            BtnCerrarSesion.TabIndex = 11;
            BtnCerrarSesion.Text = "Cerrar Sesion";
            BtnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 16;
            label1.Text = "Administrador General";
            // 
            // InicioAdministradorGeneral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(542, 450);
            Controls.Add(label1);
            Controls.Add(BtnOrdenarMenorPrecio);
            Controls.Add(BtnOrdenarMayorPrecio);
            Controls.Add(BtnBuscar);
            Controls.Add(BtnCerrarSesion);
            Name = "InicioAdministradorGeneral";
            Text = "InicioAdministradorGeneral";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnOrdenarMenorPrecio;
        private Button BtnOrdenarMayorPrecio;
        private Button BtnBuscar;
        private Button BtnCerrarSesion;
        private Label label1;
    }
}