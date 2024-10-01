namespace Libreria_Practicas.Cliente
{
    partial class CobroExitoso
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
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(335, 99);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "¡ Pedido Exitoso !";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(229, 189);
            label2.Name = "label2";
            label2.Size = new Size(314, 15);
            label2.TabIndex = 1;
            label2.Text = "Acérquese al mostrador de la librería para retirar su pedido";
            // 
            // button2
            // 
            button2.Location = new Point(346, 268);
            button2.Name = "button2";
            button2.Size = new Size(73, 23);
            button2.TabIndex = 9;
            button2.Text = "Volver";
            button2.UseVisualStyleBackColor = true;
            // 
            // CobroExitoso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CobroExitoso";
            Text = "CobroExitoso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button2;
    }
}