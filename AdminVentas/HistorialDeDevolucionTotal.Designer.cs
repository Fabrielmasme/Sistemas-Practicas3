namespace Libreria_Practicas.AdminVentas
{
    partial class HistorialDeDevolucionTotal
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
            ((System.ComponentModel.ISupportInitialize)DgvInicioCliente).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(619, 43);
            button3.Name = "button3";
            button3.Size = new Size(61, 23);
            button3.TabIndex = 17;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(466, 14);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Busqueda :";
            textBox1.Size = new Size(214, 23);
            textBox1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(156, 15);
            label1.TabIndex = 15;
            label1.Text = "Historial de devolucion total";
            // 
            // BtnIniciarSesion
            // 
            BtnIniciarSesion.Location = new Point(12, 56);
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
            DgvInicioCliente.Location = new Point(12, 85);
            DgvInicioCliente.Name = "DgvInicioCliente";
            DgvInicioCliente.RowTemplate.Height = 25;
            DgvInicioCliente.Size = new Size(668, 280);
            DgvInicioCliente.TabIndex = 13;
            // 
            // HistorialDeDevolucionTotal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(694, 450);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(BtnIniciarSesion);
            Controls.Add(DgvInicioCliente);
            Name = "HistorialDeDevolucionTotal";
            Text = "HistorialDeDevolucionTotal";
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
    }
}