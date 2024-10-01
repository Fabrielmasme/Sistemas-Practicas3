namespace Libreria_Practicas.AdminVentas
{
    partial class Devoluciones
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
            textBox1 = new TextBox();
            BtnIniciarSesion = new Button();
            button1 = new Button();
            label1 = new Label();
            DgvInicioCliente = new DataGridView();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvInicioCliente).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(447, 58);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Busqueda :";
            textBox1.Size = new Size(214, 23);
            textBox1.TabIndex = 1;
            // 
            // BtnIniciarSesion
            // 
            BtnIniciarSesion.Location = new Point(13, 58);
            BtnIniciarSesion.Name = "BtnIniciarSesion";
            BtnIniciarSesion.Size = new Size(169, 23);
            BtnIniciarSesion.TabIndex = 4;
            BtnIniciarSesion.Text = "Historial de devolucion total";
            BtnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(208, 58);
            button1.Name = "button1";
            button1.Size = new Size(207, 23);
            button1.TabIndex = 5;
            button1.Text = "Historial de devoluciones parciales";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(13, 19);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 6;
            label1.Text = "Devoluciones";
            // 
            // DgvInicioCliente
            // 
            DgvInicioCliente.BackgroundColor = SystemColors.Window;
            DgvInicioCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvInicioCliente.Location = new Point(13, 146);
            DgvInicioCliente.Name = "DgvInicioCliente";
            DgvInicioCliente.RowTemplate.Height = 25;
            DgvInicioCliente.Size = new Size(648, 276);
            DgvInicioCliente.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(256, 278);
            label2.Name = "label2";
            label2.Size = new Size(139, 15);
            label2.TabIndex = 8;
            label2.Text = "Acá se editan las facturas";
            // 
            // button2
            // 
            button2.Location = new Point(556, 451);
            button2.Name = "button2";
            button2.Size = new Size(105, 23);
            button2.TabIndex = 9;
            button2.Text = "Aceptar cambios";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(600, 87);
            button3.Name = "button3";
            button3.Size = new Size(61, 23);
            button3.TabIndex = 10;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            // 
            // Devoluciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(690, 486);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(DgvInicioCliente);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(BtnIniciarSesion);
            Controls.Add(textBox1);
            Name = "Devoluciones";
            Text = "Devoluciones";
            ((System.ComponentModel.ISupportInitialize)DgvInicioCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button BtnIniciarSesion;
        private Button button1;
        private Label label1;
        private DataGridView DgvInicioCliente;
        private Label label2;
        private Button button2;
        private Button button3;
    }
}