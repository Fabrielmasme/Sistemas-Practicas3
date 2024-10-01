namespace Libreria_Practicas.AdminVentas
{
    partial class InicioAdminVentas
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
            BtnCerrarSesion = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // BtnCerrarSesion
            // 
            BtnCerrarSesion.Location = new Point(491, 42);
            BtnCerrarSesion.Name = "BtnCerrarSesion";
            BtnCerrarSesion.Size = new Size(67, 39);
            BtnCerrarSesion.TabIndex = 3;
            BtnCerrarSesion.Text = "Cerrar Sesion";
            BtnCerrarSesion.UseVisualStyleBackColor = true;
            BtnCerrarSesion.Click += BtnCerrarSesion_Click;
            // 
            // button1
            // 
            button1.Location = new Point(65, 126);
            button1.Name = "button1";
            button1.Size = new Size(139, 39);
            button1.TabIndex = 4;
            button1.Text = "Gestion de pedidos";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(65, 216);
            button3.Name = "button3";
            button3.Size = new Size(139, 39);
            button3.TabIndex = 6;
            button3.Text = "Notas de credito";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(65, 171);
            button4.Name = "button4";
            button4.Size = new Size(139, 39);
            button4.TabIndex = 7;
            button4.Text = "Devolucion";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 8;
            label1.Text = "Administrador De Ventas";
            // 
            // button2
            // 
            button2.Location = new Point(65, 261);
            button2.Name = "button2";
            button2.Size = new Size(139, 39);
            button2.TabIndex = 9;
            button2.Text = "Cobro en efectivo";
            button2.UseVisualStyleBackColor = true;
            // 
            // InicioAdminVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(570, 394);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(BtnCerrarSesion);
            Name = "InicioAdminVentas";
            Text = "InicioAdminVentas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCerrarSesion;
        private Button button1;
        private Button button3;
        private Button button4;
        private Label label1;
        private Button button2;
    }
}