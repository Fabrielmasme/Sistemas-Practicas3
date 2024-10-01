namespace Libreria_Practicas.AdminVentas
{
    partial class HistorialDeFacturas
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
            button1 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            BtnIniciarSesion = new Button();
            DgvInicioCliente = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvInicioCliente).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 19);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 24;
            button1.Text = "Historial de facturas";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(356, 19);
            button3.Name = "button3";
            button3.Size = new Size(61, 23);
            button3.TabIndex = 23;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 19);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Busqueda de facturas :";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 22;
            // 
            // BtnIniciarSesion
            // 
            BtnIniciarSesion.Location = new Point(12, 106);
            BtnIniciarSesion.Name = "BtnIniciarSesion";
            BtnIniciarSesion.Size = new Size(69, 23);
            BtnIniciarSesion.TabIndex = 20;
            BtnIniciarSesion.Text = "Selecionar";
            BtnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // DgvInicioCliente
            // 
            DgvInicioCliente.BackgroundColor = SystemColors.Window;
            DgvInicioCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvInicioCliente.Location = new Point(12, 135);
            DgvInicioCliente.Name = "DgvInicioCliente";
            DgvInicioCliente.RowTemplate.Height = 25;
            DgvInicioCliente.Size = new Size(776, 296);
            DgvInicioCliente.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(302, 258);
            label2.Name = "label2";
            label2.Size = new Size(197, 15);
            label2.TabIndex = 25;
            label2.Text = "Acá se pueden ver todas las facturas";
            label2.Click += label2_Click;
            // 
            // HistorialDeFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(BtnIniciarSesion);
            Controls.Add(DgvInicioCliente);
            Name = "HistorialDeFacturas";
            Text = "HistorialDeFacturas";
            ((System.ComponentModel.ISupportInitialize)DgvInicioCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private TextBox textBox1;
        private Button BtnIniciarSesion;
        private DataGridView DgvInicioCliente;
        private Label label2;
    }
}