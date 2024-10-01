namespace Libreria_Practicas.AdminVentas
{
    partial class DefinicionDeTipoFactura
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
            label2 = new Label();
            DgvInicioCliente = new DataGridView();
            button1 = new Button();
            BtnIniciarSesion = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvInicioCliente).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(645, 445);
            button3.Name = "button3";
            button3.Size = new Size(61, 23);
            button3.TabIndex = 17;
            button3.Text = "Enviar";
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(207, 283);
            label2.Name = "label2";
            label2.Size = new Size(214, 15);
            label2.TabIndex = 16;
            label2.Text = "Acá se ven todos los datos de la factura";
            // 
            // DgvInicioCliente
            // 
            DgvInicioCliente.BackgroundColor = SystemColors.Window;
            DgvInicioCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvInicioCliente.Location = new Point(12, 153);
            DgvInicioCliente.Name = "DgvInicioCliente";
            DgvInicioCliente.RowTemplate.Height = 25;
            DgvInicioCliente.Size = new Size(694, 276);
            DgvInicioCliente.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(191, 63);
            button1.Name = "button1";
            button1.Size = new Size(117, 23);
            button1.TabIndex = 13;
            button1.Text = "Devolucion Parcial";
            button1.UseVisualStyleBackColor = true;
            // 
            // BtnIniciarSesion
            // 
            BtnIniciarSesion.Location = new Point(40, 63);
            BtnIniciarSesion.Name = "BtnIniciarSesion";
            BtnIniciarSesion.Size = new Size(111, 23);
            BtnIniciarSesion.TabIndex = 12;
            BtnIniciarSesion.Text = "Devolucion Total";
            BtnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // DefinisionDeTipoFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(720, 480);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(DgvInicioCliente);
            Controls.Add(button1);
            Controls.Add(BtnIniciarSesion);
            Name = "DefinisionDeTipoFactura";
            Text = "DefinisionDeTipoFactura";
            ((System.ComponentModel.ISupportInitialize)DgvInicioCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Label label2;
        private DataGridView DgvInicioCliente;
        private Button button1;
        private Button BtnIniciarSesion;
    }
}