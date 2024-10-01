namespace Libreria_Practicas.AdminCompras
{
    partial class Historial_de_compras
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 333);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(102, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "Buscar Compra :";
            // 
            // button1
            // 
            button1.Location = new Point(232, 75);
            button1.Name = "button1";
            button1.Size = new Size(57, 23);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Historial_de_compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 478);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Historial_de_compras";
            Text = "Historial_de_compras";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button1;
    }
}