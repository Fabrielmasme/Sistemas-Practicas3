namespace Libreria_Practicas.Cliente
{
    partial class InicioCliente
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
            DgvInicioCliente = new DataGridView();
            BtnPerfil = new Button();
            BtnCerrarSesion = new Button();
            TxbxBusquedaInicioCliente = new TextBox();
            BtnBuscar = new Button();
            BtnOrdenarMayorPrecio = new Button();
            BtnOrdenarMenorPrecio = new Button();
            BtnCarritoCompras = new Button();
            CbbxGenero = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DgvInicioCliente).BeginInit();
            SuspendLayout();
            // 
            // DgvInicioCliente
            // 
            DgvInicioCliente.BackgroundColor = SystemColors.Window;
            DgvInicioCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvInicioCliente.Location = new Point(12, 204);
            DgvInicioCliente.Name = "DgvInicioCliente";
            DgvInicioCliente.RowTemplate.Height = 25;
            DgvInicioCliente.Size = new Size(606, 234);
            DgvInicioCliente.TabIndex = 0;
            // 
            // BtnPerfil
            // 
            BtnPerfil.Location = new Point(24, 20);
            BtnPerfil.Name = "BtnPerfil";
            BtnPerfil.Size = new Size(67, 39);
            BtnPerfil.TabIndex = 1;
            BtnPerfil.Text = "Perfil";
            BtnPerfil.UseVisualStyleBackColor = true;
            // 
            // BtnCerrarSesion
            // 
            BtnCerrarSesion.Location = new Point(157, 20);
            BtnCerrarSesion.Name = "BtnCerrarSesion";
            BtnCerrarSesion.Size = new Size(67, 39);
            BtnCerrarSesion.TabIndex = 2;
            BtnCerrarSesion.Text = "Cerrar Sesion";
            BtnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // TxbxBusquedaInicioCliente
            // 
            TxbxBusquedaInicioCliente.Location = new Point(24, 112);
            TxbxBusquedaInicioCliente.Name = "TxbxBusquedaInicioCliente";
            TxbxBusquedaInicioCliente.Size = new Size(200, 23);
            TxbxBusquedaInicioCliente.TabIndex = 3;
            TxbxBusquedaInicioCliente.Text = "Buscar :";
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(257, 112);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(53, 23);
            BtnBuscar.TabIndex = 4;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // BtnOrdenarMayorPrecio
            // 
            BtnOrdenarMayorPrecio.Location = new Point(360, 66);
            BtnOrdenarMayorPrecio.Name = "BtnOrdenarMayorPrecio";
            BtnOrdenarMayorPrecio.Size = new Size(157, 23);
            BtnOrdenarMayorPrecio.TabIndex = 5;
            BtnOrdenarMayorPrecio.Text = "Ordenar por mayor precio";
            BtnOrdenarMayorPrecio.UseVisualStyleBackColor = true;
            // 
            // BtnOrdenarMenorPrecio
            // 
            BtnOrdenarMenorPrecio.Location = new Point(360, 95);
            BtnOrdenarMenorPrecio.Name = "BtnOrdenarMenorPrecio";
            BtnOrdenarMenorPrecio.Size = new Size(157, 23);
            BtnOrdenarMenorPrecio.TabIndex = 6;
            BtnOrdenarMenorPrecio.Text = "Ordenar por menor precio";
            BtnOrdenarMenorPrecio.UseVisualStyleBackColor = true;
            // 
            // BtnCarritoCompras
            // 
            BtnCarritoCompras.Location = new Point(669, 28);
            BtnCarritoCompras.Name = "BtnCarritoCompras";
            BtnCarritoCompras.Size = new Size(119, 23);
            BtnCarritoCompras.TabIndex = 7;
            BtnCarritoCompras.Text = "Carrito de Compras\r\n";
            BtnCarritoCompras.UseVisualStyleBackColor = true;
            // 
            // CbbxGenero
            // 
            CbbxGenero.FormattingEnabled = true;
            CbbxGenero.Location = new Point(567, 95);
            CbbxGenero.Name = "CbbxGenero";
            CbbxGenero.Size = new Size(63, 23);
            CbbxGenero.TabIndex = 9;
            CbbxGenero.Text = "Genero";
            // 
            // InicioCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(CbbxGenero);
            Controls.Add(BtnCarritoCompras);
            Controls.Add(BtnOrdenarMenorPrecio);
            Controls.Add(BtnOrdenarMayorPrecio);
            Controls.Add(BtnBuscar);
            Controls.Add(TxbxBusquedaInicioCliente);
            Controls.Add(BtnCerrarSesion);
            Controls.Add(BtnPerfil);
            Controls.Add(DgvInicioCliente);
            Name = "InicioCliente";
            Text = "InicioCliente";
            ((System.ComponentModel.ISupportInitialize)DgvInicioCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvInicioCliente;
        private Button BtnPerfil;
        private Button BtnCerrarSesion;
        private TextBox TxbxBusquedaInicioCliente;
        private Button BtnBuscar;
        private Button BtnOrdenarMayorPrecio;
        private Button BtnOrdenarMenorPrecio;
        private Button BtnCarritoCompras;
        private ComboBox CbbxGenero;
    }
}