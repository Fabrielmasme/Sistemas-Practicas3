namespace Libreria_Practicas.Cliente
{
    partial class RegistroCliente
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
            BtnRegistrese = new Button();
            TbxIngreseApellido = new TextBox();
            LblRegistro = new Label();
            TbxIngreseNombre = new TextBox();
            TxbxRepitaConrtaseniaRegistro = new TextBox();
            TxbxIngreseContraseniaRegistro = new TextBox();
            TxbxIngreseCorreo = new TextBox();
            TxbxIngreseTelefono = new TextBox();
            TbxIngreseEdad = new TextBox();
            TbxIngreseDNI = new TextBox();
            SuspendLayout();
            // 
            // BtnRegistrese
            // 
            BtnRegistrese.ForeColor = Color.DarkBlue;
            BtnRegistrese.Location = new Point(301, 465);
            BtnRegistrese.Name = "BtnRegistrese";
            BtnRegistrese.Size = new Size(127, 23);
            BtnRegistrese.TabIndex = 11;
            BtnRegistrese.Text = "Registrarse ";
            BtnRegistrese.UseVisualStyleBackColor = true;
            // 
            // TbxIngreseApellido
            // 
            TbxIngreseApellido.Location = new Point(265, 147);
            TbxIngreseApellido.Name = "TbxIngreseApellido";
            TbxIngreseApellido.PlaceholderText = "Ingrese Ingrese su Apellido :";
            TbxIngreseApellido.Size = new Size(214, 23);
            TbxIngreseApellido.TabIndex = 10;
            // 
            // LblRegistro
            // 
            LblRegistro.AutoSize = true;
            LblRegistro.ForeColor = SystemColors.ControlLightLight;
            LblRegistro.Location = new Point(340, 69);
            LblRegistro.Name = "LblRegistro";
            LblRegistro.Size = new Size(50, 15);
            LblRegistro.TabIndex = 9;
            LblRegistro.Text = "Registro";
            // 
            // TbxIngreseNombre
            // 
            TbxIngreseNombre.Location = new Point(265, 103);
            TbxIngreseNombre.Name = "TbxIngreseNombre";
            TbxIngreseNombre.PlaceholderText = "Ingrese su Nombre :";
            TbxIngreseNombre.Size = new Size(214, 23);
            TbxIngreseNombre.TabIndex = 8;
            // 
            // TxbxRepitaConrtaseniaRegistro
            // 
            TxbxRepitaConrtaseniaRegistro.Location = new Point(265, 412);
            TxbxRepitaConrtaseniaRegistro.Name = "TxbxRepitaConrtaseniaRegistro";
            TxbxRepitaConrtaseniaRegistro.PlaceholderText = "Repita Contraseña :";
            TxbxRepitaConrtaseniaRegistro.Size = new Size(214, 23);
            TxbxRepitaConrtaseniaRegistro.TabIndex = 12;
            // 
            // TxbxIngreseContraseniaRegistro
            // 
            TxbxIngreseContraseniaRegistro.Location = new Point(265, 366);
            TxbxIngreseContraseniaRegistro.Name = "TxbxIngreseContraseniaRegistro";
            TxbxIngreseContraseniaRegistro.PlaceholderText = "Ingrese Contraseña :";
            TxbxIngreseContraseniaRegistro.Size = new Size(214, 23);
            TxbxIngreseContraseniaRegistro.TabIndex = 13;
            // 
            // TxbxIngreseCorreo
            // 
            TxbxIngreseCorreo.Location = new Point(265, 320);
            TxbxIngreseCorreo.Name = "TxbxIngreseCorreo";
            TxbxIngreseCorreo.PlaceholderText = "Ingrese su Correo :";
            TxbxIngreseCorreo.Size = new Size(214, 23);
            TxbxIngreseCorreo.TabIndex = 14;
            // 
            // TxbxIngreseTelefono
            // 
            TxbxIngreseTelefono.Location = new Point(265, 278);
            TxbxIngreseTelefono.Name = "TxbxIngreseTelefono";
            TxbxIngreseTelefono.PlaceholderText = "Ingrese su numero de  telefono :";
            TxbxIngreseTelefono.Size = new Size(214, 23);
            TxbxIngreseTelefono.TabIndex = 15;
            // 
            // TbxIngreseEdad
            // 
            TbxIngreseEdad.Location = new Point(265, 234);
            TbxIngreseEdad.Name = "TbxIngreseEdad";
            TbxIngreseEdad.PlaceholderText = "Ingrese su edad :";
            TbxIngreseEdad.Size = new Size(214, 23);
            TbxIngreseEdad.TabIndex = 16;
            // 
            // TbxIngreseDNI
            // 
            TbxIngreseDNI.Location = new Point(265, 189);
            TbxIngreseDNI.Name = "TbxIngreseDNI";
            TbxIngreseDNI.PlaceholderText = "Ingrese su D.N.I :";
            TbxIngreseDNI.Size = new Size(214, 23);
            TbxIngreseDNI.TabIndex = 17;
            // 
            // RegistroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 554);
            Controls.Add(TbxIngreseDNI);
            Controls.Add(TbxIngreseEdad);
            Controls.Add(TxbxIngreseTelefono);
            Controls.Add(TxbxIngreseCorreo);
            Controls.Add(TxbxIngreseContraseniaRegistro);
            Controls.Add(TxbxRepitaConrtaseniaRegistro);
            Controls.Add(BtnRegistrese);
            Controls.Add(TbxIngreseApellido);
            Controls.Add(LblRegistro);
            Controls.Add(TbxIngreseNombre);
            ForeColor = SystemColors.ControlLightLight;
            Name = "RegistroCliente";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnRegistrese;
        private TextBox TbxIngreseApellido;
        private Label LblRegistro;
        private TextBox TbxIngreseNombre;
        private TextBox TxbxRepitaConrtaseniaRegistro;
        private TextBox TxbxIngreseContraseniaRegistro;
        private TextBox TxbxIngreseCorreo;
        private TextBox TxbxIngreseTelefono;
        private TextBox TbxIngreseEdad;
        private TextBox TbxIngreseDNI;
    }
}