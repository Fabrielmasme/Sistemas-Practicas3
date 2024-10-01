namespace Libreria_Practicas.AdminCompras
{
    partial class PagosProveedores
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
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(233, 261);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(192, 23);
            textBox4.TabIndex = 6;
            textBox4.Text = "Nombre del proveedor :";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(233, 290);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(192, 23);
            textBox3.TabIndex = 5;
            textBox3.Text = "Ingrese pago en efectivo :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(233, 319);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 23);
            textBox2.TabIndex = 4;
            textBox2.Text = "Ingrese pago virtual :";
            // 
            // button1
            // 
            button1.Location = new Point(282, 375);
            button1.Name = "button1";
            button1.Size = new Size(105, 23);
            button1.TabIndex = 7;
            button1.Text = "Guardar Pago";
            button1.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(233, 76);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AliceBlue;
            label1.Location = new Point(18, 21);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 9;
            label1.Text = "Pagos a proveedores";
            // 
            // PagosProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(monthCalendar1);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Name = "PagosProveedores";
            Text = "PagosProveedores";
            Load += PagosProveedores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button1;
        private MonthCalendar monthCalendar1;
        private Label label1;
    }
}