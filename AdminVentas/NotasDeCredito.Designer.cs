namespace Libreria_Practicas.AdminVentas
{
    partial class NotasDeCredito
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
            label1 = new Label();
            BtnBuscar = new Button();
            textBox1 = new TextBox();
            DgvInicioCliente = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvInicioCliente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(36, 26);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "Notas de Credito";
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(262, 82);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(53, 23);
            BtnBuscar.TabIndex = 5;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(36, 82);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar nota de credito :";
            textBox1.Size = new Size(186, 23);
            textBox1.TabIndex = 6;
            // 
            // DgvInicioCliente
            // 
            DgvInicioCliente.BackgroundColor = SystemColors.Window;
            DgvInicioCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvInicioCliente.Location = new Point(36, 152);
            DgvInicioCliente.Name = "DgvInicioCliente";
            DgvInicioCliente.RowTemplate.Height = 25;
            DgvInicioCliente.Size = new Size(680, 234);
            DgvInicioCliente.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(262, 264);
            label2.Name = "label2";
            label2.Size = new Size(225, 15);
            label2.TabIndex = 8;
            label2.Text = "Acá apareceran todas las notas de credito";
            label2.Click += label2_Click;
            // 
            // NotasDeCredito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(DgvInicioCliente);
            Controls.Add(textBox1);
            Controls.Add(BtnBuscar);
            Controls.Add(label1);
            Name = "NotasDeCredito";
            Text = "NotasDeCredito";
            Load += NotasDeCredito_Load;
            ((System.ComponentModel.ISupportInitialize)DgvInicioCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnBuscar;
        private TextBox textBox1;
        private DataGridView DgvInicioCliente;
        private Label label2;
    }
}