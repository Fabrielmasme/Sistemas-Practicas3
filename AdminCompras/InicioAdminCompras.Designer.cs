namespace Libreria_Practicas.AdminCompras
{
    partial class InicioAdminCompras
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
            button2 = new Button();
            button4 = new Button();
            label1 = new Label();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvInicioCliente).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(694, 17);
            button3.Name = "button3";
            button3.Size = new Size(75, 41);
            button3.TabIndex = 22;
            button3.Text = "Cerrar Sesion";
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 17);
            label2.Name = "label2";
            label2.Size = new Size(182, 15);
            label2.TabIndex = 21;
            label2.Text = "Inicio Administrador de Compras";
            // 
            // DgvInicioCliente
            // 
            DgvInicioCliente.BackgroundColor = SystemColors.Window;
            DgvInicioCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvInicioCliente.Location = new Point(210, 164);
            DgvInicioCliente.Name = "DgvInicioCliente";
            DgvInicioCliente.RowTemplate.Height = 25;
            DgvInicioCliente.Size = new Size(380, 274);
            DgvInicioCliente.TabIndex = 20;
            // 
            // button1
            // 
            button1.Location = new Point(25, 119);
            button1.Name = "button1";
            button1.Size = new Size(125, 23);
            button1.TabIndex = 19;
            button1.Text = "Estados de compras";
            button1.UseVisualStyleBackColor = true;
            // 
            // BtnIniciarSesion
            // 
            BtnIniciarSesion.Location = new Point(25, 61);
            BtnIniciarSesion.Name = "BtnIniciarSesion";
            BtnIniciarSesion.Size = new Size(83, 23);
            BtnIniciarSesion.TabIndex = 18;
            BtnIniciarSesion.Text = "Proveedores";
            BtnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(694, 134);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 23;
            button2.Text = "Alertas";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(25, 90);
            button4.Name = "button4";
            button4.Size = new Size(111, 23);
            button4.TabIndex = 24;
            button4.Text = "Stock";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(277, 270);
            label1.Name = "label1";
            label1.Size = new Size(226, 15);
            label1.TabIndex = 25;
            label1.Text = "Acá se va a poder ver los pedidos a recibir";
            // 
            // button5
            // 
            button5.Location = new Point(25, 148);
            button5.Name = "button5";
            button5.Size = new Size(125, 23);
            button5.TabIndex = 26;
            button5.Text = "Pagos a proveedores";
            button5.UseVisualStyleBackColor = true;
            // 
            // InicioAdminCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(DgvInicioCliente);
            Controls.Add(button1);
            Controls.Add(BtnIniciarSesion);
            Name = "InicioAdminCompras";
            Text = "InicioAdminCompras";
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
        private Button button2;
        private Button button4;
        private Label label1;
        private Button button5;
    }
}