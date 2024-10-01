namespace Libreria_Practicas.Cliente
{
    partial class CarritoDeCompras
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(44, 42);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Carrito de compras";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 221);
            dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 337);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(249, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Ingrese número de nota de credito :";
            // 
            // button1
            // 
            button1.Location = new Point(304, 337);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(656, 378);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 4;
            button2.Text = "Pagar";
            button2.UseVisualStyleBackColor = true;
            // 
            // CarritoDeCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 422);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "CarritoDeCompras";
            Text = "CarritoDeCompras";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}