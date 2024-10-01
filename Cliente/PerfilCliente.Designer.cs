namespace Libreria_Practicas.Cliente
{
    partial class PerfilCliente
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
            TbxIngreseDNI = new TextBox();
            TbxIngreseEdad = new TextBox();
            TxbxIngreseTelefono = new TextBox();
            TxbxIngreseCorreo = new TextBox();
            TxbxIngreseContraseniaRegistro = new TextBox();
            TxbxRepitaConrtaseniaRegistro = new TextBox();
            TbxIngreseApellido = new TextBox();
            LblPerfil = new Label();
            TbxIngreseNombre = new TextBox();
            BtnActalizarPerfil = new Button();
            SuspendLayout();
            // 
            // TbxIngreseDNI
            // 
            TbxIngreseDNI.Location = new Point(293, 162);
            TbxIngreseDNI.Name = "TbxIngreseDNI";
            TbxIngreseDNI.PlaceholderText = "Ingrese su D.N.I :";
            TbxIngreseDNI.Size = new Size(214, 23);
            TbxIngreseDNI.TabIndex = 26;
            // 
            // TbxIngreseEdad
            // 
            TbxIngreseEdad.Location = new Point(293, 207);
            TbxIngreseEdad.Name = "TbxIngreseEdad";
            TbxIngreseEdad.PlaceholderText = "Ingrese su edad :";
            TbxIngreseEdad.Size = new Size(214, 23);
            TbxIngreseEdad.TabIndex = 25;
            // 
            // TxbxIngreseTelefono
            // 
            TxbxIngreseTelefono.Location = new Point(293, 251);
            TxbxIngreseTelefono.Name = "TxbxIngreseTelefono";
            TxbxIngreseTelefono.PlaceholderText = "Ingrese su numero de  telefono :";
            TxbxIngreseTelefono.Size = new Size(214, 23);
            TxbxIngreseTelefono.TabIndex = 24;
            // 
            // TxbxIngreseCorreo
            // 
            TxbxIngreseCorreo.Location = new Point(293, 293);
            TxbxIngreseCorreo.Name = "TxbxIngreseCorreo";
            TxbxIngreseCorreo.PlaceholderText = "Ingrese su Correo :";
            TxbxIngreseCorreo.Size = new Size(214, 23);
            TxbxIngreseCorreo.TabIndex = 23;
            // 
            // TxbxIngreseContraseniaRegistro
            // 
            TxbxIngreseContraseniaRegistro.Location = new Point(293, 339);
            TxbxIngreseContraseniaRegistro.Name = "TxbxIngreseContraseniaRegistro";
            TxbxIngreseContraseniaRegistro.PlaceholderText = "Ingrese Contraseña :";
            TxbxIngreseContraseniaRegistro.Size = new Size(214, 23);
            TxbxIngreseContraseniaRegistro.TabIndex = 22;
            // 
            // TxbxRepitaConrtaseniaRegistro
            // 
            TxbxRepitaConrtaseniaRegistro.Location = new Point(293, 385);
            TxbxRepitaConrtaseniaRegistro.Name = "TxbxRepitaConrtaseniaRegistro";
            TxbxRepitaConrtaseniaRegistro.PlaceholderText = "Repita Contraseña :";
            TxbxRepitaConrtaseniaRegistro.Size = new Size(214, 23);
            TxbxRepitaConrtaseniaRegistro.TabIndex = 21;
            // 
            // TbxIngreseApellido
            // 
            TbxIngreseApellido.Location = new Point(293, 120);
            TbxIngreseApellido.Name = "TbxIngreseApellido";
            TbxIngreseApellido.PlaceholderText = "Ingrese Ingrese su Apellido :";
            TbxIngreseApellido.Size = new Size(214, 23);
            TbxIngreseApellido.TabIndex = 20;
            // 
            // LblPerfil
            // 
            LblPerfil.AutoSize = true;
            LblPerfil.ForeColor = SystemColors.ControlLightLight;
            LblPerfil.Location = new Point(368, 42);
            LblPerfil.Name = "LblPerfil";
            LblPerfil.Size = new Size(34, 15);
            LblPerfil.TabIndex = 19;
            LblPerfil.Text = "Perfil";
            // 
            // TbxIngreseNombre
            // 
            TbxIngreseNombre.Location = new Point(293, 76);
            TbxIngreseNombre.Name = "TbxIngreseNombre";
            TbxIngreseNombre.PlaceholderText = "Ingrese su Nombre :";
            TbxIngreseNombre.Size = new Size(214, 23);
            TbxIngreseNombre.TabIndex = 18;
            // 
            // BtnActalizarPerfil
            // 
            BtnActalizarPerfil.Location = new Point(344, 427);
            BtnActalizarPerfil.Name = "BtnActalizarPerfil";
            BtnActalizarPerfil.Size = new Size(107, 23);
            BtnActalizarPerfil.TabIndex = 27;
            BtnActalizarPerfil.Text = "Actualizar Perfil";
            BtnActalizarPerfil.UseVisualStyleBackColor = true;
            // 
            // PerfilCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 477);
            Controls.Add(BtnActalizarPerfil);
            Controls.Add(TbxIngreseDNI);
            Controls.Add(TbxIngreseEdad);
            Controls.Add(TxbxIngreseTelefono);
            Controls.Add(TxbxIngreseCorreo);
            Controls.Add(TxbxIngreseContraseniaRegistro);
            Controls.Add(TxbxRepitaConrtaseniaRegistro);
            Controls.Add(TbxIngreseApellido);
            Controls.Add(LblPerfil);
            Controls.Add(TbxIngreseNombre);
            Name = "PerfilCliente";
            Text = "PerfilCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TbxIngreseDNI;
        private TextBox TbxIngreseEdad;
        private TextBox TxbxIngreseTelefono;
        private TextBox TxbxIngreseCorreo;
        private TextBox TxbxIngreseContraseniaRegistro;
        private TextBox TxbxRepitaConrtaseniaRegistro;
        private TextBox TbxIngreseApellido;
        private Label LblPerfil;
        private TextBox TbxIngreseNombre;
        private Button BtnActalizarPerfil;
    }
}