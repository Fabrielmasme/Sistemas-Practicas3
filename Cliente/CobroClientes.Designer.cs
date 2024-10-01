namespace Libreria_Practicas.Cliente
{
    partial class CobroClientes
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(352, 21);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Pagos";
            // 
            // button1
            // 
            button1.Location = new Point(319, 70);
            button1.Name = "button1";
            button1.Size = new Size(129, 23);
            button1.TabIndex = 1;
            button1.Text = "Pago En Efectivo";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(282, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Numero de tarjeta :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(282, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "Fecha de vencimiento :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(282, 306);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(195, 23);
            textBox3.TabIndex = 4;
            textBox3.Text = "D.N.I Del titular :";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(282, 266);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(195, 23);
            textBox4.TabIndex = 5;
            textBox4.Text = "CVV :";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(282, 225);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(195, 23);
            textBox5.TabIndex = 6;
            textBox5.Text = "Nombre del titular :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(330, 370);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 7;
            label2.Text = "Total a pagar: $$$";
            // 
            // button2
            // 
            button2.Location = new Point(317, 430);
            button2.Name = "button2";
            button2.Size = new Size(129, 23);
            button2.TabIndex = 8;
            button2.Text = "Confirmar Pago";
            button2.UseVisualStyleBackColor = true;
            // 
            // CobroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 492);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "CobroClientes";
            Text = "CobroClientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label2;
        private Button button2;
    }
}