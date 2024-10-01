namespace Libreria_Practicas.AdminCompras
{
    partial class Stock
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
            BtnCarritoCompras = new Button();
            BtnBuscar = new Button();
            TxbxBusquedaInicioCliente = new TextBox();
            DgvInicioCliente = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvInicioCliente).BeginInit();
            SuspendLayout();
            // 
            // BtnCarritoCompras
            // 
            BtnCarritoCompras.Location = new Point(669, 24);
            BtnCarritoCompras.Name = "BtnCarritoCompras";
            BtnCarritoCompras.Size = new Size(119, 23);
            BtnCarritoCompras.TabIndex = 17;
            BtnCarritoCompras.Text = "Carrito de Compras\r\n";
            BtnCarritoCompras.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(257, 108);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(53, 23);
            BtnBuscar.TabIndex = 14;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // TxbxBusquedaInicioCliente
            // 
            TxbxBusquedaInicioCliente.Location = new Point(24, 108);
            TxbxBusquedaInicioCliente.Name = "TxbxBusquedaInicioCliente";
            TxbxBusquedaInicioCliente.Size = new Size(200, 23);
            TxbxBusquedaInicioCliente.TabIndex = 13;
            TxbxBusquedaInicioCliente.Text = "Buscar :";
            // 
            // DgvInicioCliente
            // 
            DgvInicioCliente.BackgroundColor = SystemColors.Window;
            DgvInicioCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvInicioCliente.Location = new Point(12, 204);
            DgvInicioCliente.Name = "DgvInicioCliente";
            DgvInicioCliente.RowTemplate.Height = 25;
            DgvInicioCliente.Size = new Size(776, 234);
            DgvInicioCliente.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(343, 296);
            label1.Name = "label1";
            label1.Size = new Size(161, 15);
            label1.TabIndex = 26;
            label1.Text = "Acá se va a poder ver el stock";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(278, 175);
            button1.Name = "button1";
            button1.Size = new Size(53, 23);
            button1.TabIndex = 28;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(360, 175);
            button2.Name = "button2";
            button2.Size = new Size(63, 23);
            button2.TabIndex = 29;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(451, 175);
            button3.Name = "button3";
            button3.Size = new Size(66, 23);
            button3.TabIndex = 30;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(327, 445);
            button4.Name = "button4";
            button4.Size = new Size(66, 23);
            button4.TabIndex = 31;
            button4.Text = "Guardar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(527, 445);
            button5.Name = "button5";
            button5.Size = new Size(74, 23);
            button5.TabIndex = 32;
            button5.Text = "Actualizar";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(738, 445);
            button6.Name = "button6";
            button6.Size = new Size(50, 23);
            button6.TabIndex = 33;
            button6.Text = "Editar";
            button6.UseVisualStyleBackColor = true;
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 480);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(BtnCarritoCompras);
            Controls.Add(BtnBuscar);
            Controls.Add(TxbxBusquedaInicioCliente);
            Controls.Add(DgvInicioCliente);
            Name = "Stock";
            Text = "Stock";
            Load += Stock_Load;
            ((System.ComponentModel.ISupportInitialize)DgvInicioCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnCarritoCompras;
        private Button BtnBuscar;
        private TextBox TxbxBusquedaInicioCliente;
        private DataGridView DgvInicioCliente;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}