namespace Libreria_Practicas.AdminVentas
{
    partial class GestionDePedidos
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
            button3 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            BtnIniciarSesion = new Button();
            DgvInicioCliente = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvInicioCliente).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(356, 17);
            button3.Name = "button3";
            button3.Size = new Size(61, 23);
            button3.TabIndex = 17;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 17);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Busqueda de pedidos :";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 15;
            label1.Text = "Gestion de pedidos";
            // 
            // BtnIniciarSesion
            // 
            BtnIniciarSesion.Location = new Point(12, 104);
            BtnIniciarSesion.Name = "BtnIniciarSesion";
            BtnIniciarSesion.Size = new Size(69, 23);
            BtnIniciarSesion.TabIndex = 14;
            BtnIniciarSesion.Text = "Selecionar";
            BtnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // DgvInicioCliente
            // 
            DgvInicioCliente.BackgroundColor = SystemColors.Window;
            DgvInicioCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvInicioCliente.Location = new Point(12, 133);
            DgvInicioCliente.Name = "DgvInicioCliente";
            DgvInicioCliente.RowTemplate.Height = 25;
            DgvInicioCliente.Size = new Size(776, 296);
            DgvInicioCliente.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(667, 17);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 18;
            button1.Text = "Historial de facturas";
            button1.UseVisualStyleBackColor = true;
            // 
            // GestionDePedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(BtnIniciarSesion);
            Controls.Add(DgvInicioCliente);
            Name = "GestionDePedidos";
            Text = "GestionDePedidos";
            ((System.ComponentModel.ISupportInitialize)DgvInicioCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private TextBox textBox1;
        private Label label1;
        private Button BtnIniciarSesion;
        private DataGridView DgvInicioCliente;
        private Button button1;
    }
}