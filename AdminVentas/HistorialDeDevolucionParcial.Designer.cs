namespace Libreria_Practicas.AdminVentas
{
    partial class HistorialDeDevolucionParcial
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
            label1 = new Label();
            BtnIniciarSesion = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DgvInicioCliente).BeginInit();
            SuspendLayout();
            // 
            // DgvInicioCliente
            // 
            DgvInicioCliente.BackgroundColor = SystemColors.Window;
            DgvInicioCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvInicioCliente.Location = new Point(12, 85);
            DgvInicioCliente.Name = "DgvInicioCliente";
            DgvInicioCliente.RowTemplate.Height = 25;
            DgvInicioCliente.Size = new Size(668, 280);
            DgvInicioCliente.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(167, 15);
            label1.TabIndex = 10;
            label1.Text = "Historial de devolucion parcial";
            // 
            // BtnIniciarSesion
            // 
            BtnIniciarSesion.Location = new Point(12, 56);
            BtnIniciarSesion.Name = "BtnIniciarSesion";
            BtnIniciarSesion.Size = new Size(69, 23);
            BtnIniciarSesion.TabIndex = 9;
            BtnIniciarSesion.Text = "Selecionar";
            BtnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(619, 43);
            button3.Name = "button3";
            button3.Size = new Size(61, 23);
            button3.TabIndex = 12;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(466, 14);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Busqueda :";
            textBox1.Size = new Size(214, 23);
            textBox1.TabIndex = 11;
            // 
            // HistorialDeDevolucionParcial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(BtnIniciarSesion);
            Controls.Add(DgvInicioCliente);
            Name = "HistorialDeDevolucionParcial";
            Text = "HistorialDeDevolucionParcial";
            ((System.ComponentModel.ISupportInitialize)DgvInicioCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvInicioCliente;
        private Label label1;
        private Button BtnIniciarSesion;
        private Button button3;
        private TextBox textBox1;
    }
}