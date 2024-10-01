namespace Libreria_Practicas.AdminCompras
{
    partial class Proveedores
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            BtnCarritoCompras = new Button();
            BtnBuscar = new Button();
            TxbxBusquedaInicioCliente = new TextBox();
            DgvInicioCliente = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvInicioCliente).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(327, 424);
            button4.Name = "button4";
            button4.Size = new Size(66, 23);
            button4.TabIndex = 44;
            button4.Text = "Guardar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(451, 154);
            button3.Name = "button3";
            button3.Size = new Size(66, 23);
            button3.TabIndex = 43;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(360, 154);
            button2.Name = "button2";
            button2.Size = new Size(63, 23);
            button2.TabIndex = 42;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(278, 154);
            button1.Name = "button1";
            button1.Size = new Size(53, 23);
            button1.TabIndex = 41;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(278, 289);
            label1.Name = "label1";
            label1.Size = new Size(274, 15);
            label1.TabIndex = 40;
            label1.Text = "Acá se va a poder ver la informacion del proveedor";
            // 
            // BtnCarritoCompras
            // 
            BtnCarritoCompras.Location = new Point(451, 424);
            BtnCarritoCompras.Name = "BtnCarritoCompras";
            BtnCarritoCompras.Size = new Size(151, 23);
            BtnCarritoCompras.TabIndex = 39;
            BtnCarritoCompras.Text = "Registro de contactacion";
            BtnCarritoCompras.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(257, 87);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(53, 23);
            BtnBuscar.TabIndex = 36;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // TxbxBusquedaInicioCliente
            // 
            TxbxBusquedaInicioCliente.Location = new Point(24, 87);
            TxbxBusquedaInicioCliente.Name = "TxbxBusquedaInicioCliente";
            TxbxBusquedaInicioCliente.Size = new Size(200, 23);
            TxbxBusquedaInicioCliente.TabIndex = 35;
            TxbxBusquedaInicioCliente.Text = "Buscar :";
            // 
            // DgvInicioCliente
            // 
            DgvInicioCliente.BackgroundColor = SystemColors.Window;
            DgvInicioCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvInicioCliente.Location = new Point(12, 183);
            DgvInicioCliente.Name = "DgvInicioCliente";
            DgvInicioCliente.RowTemplate.Height = 25;
            DgvInicioCliente.Size = new Size(776, 234);
            DgvInicioCliente.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(24, 11);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 47;
            label2.Text = "Proveedores";
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 456);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(BtnCarritoCompras);
            Controls.Add(BtnBuscar);
            Controls.Add(TxbxBusquedaInicioCliente);
            Controls.Add(DgvInicioCliente);
            Name = "Proveedores";
            Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)DgvInicioCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Button BtnCarritoCompras;
        private Button BtnBuscar;
        private TextBox TxbxBusquedaInicioCliente;
        private DataGridView DgvInicioCliente;
        private Label label2;
    }
}