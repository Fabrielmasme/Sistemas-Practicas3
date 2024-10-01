namespace Libreria_Practicas.AdminCompras
{
    partial class EstadoDeCompras
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
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            monthCalendar1 = new MonthCalendar();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            textBox2 = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Estado de compras";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(118, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "Historial de compras";
            // 
            // button1
            // 
            button1.Location = new Point(656, 72);
            button1.Name = "button1";
            button1.Size = new Size(45, 23);
            button1.TabIndex = 2;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 297);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 251);
            dataGridView1.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(12, 123);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.ControlLightLight;
            checkBox1.Location = new Point(656, 145);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Compra Terminada";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = SystemColors.ControlLightLight;
            checkBox2.Location = new Point(656, 225);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(127, 19);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Compra Cancelada";
            checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = SystemColors.ControlLightLight;
            checkBox3.Location = new Point(656, 187);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(132, 19);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "Compra incompleta";
            checkBox3.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(199, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            textBox2.Text = "Buscar :";
            // 
            // button2
            // 
            button2.Location = new Point(305, 73);
            button2.Name = "button2";
            button2.Size = new Size(55, 23);
            button2.TabIndex = 9;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            // 
            // EstadoDeCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 560);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(monthCalendar1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "EstadoDeCompras";
            Text = "EstadoDeCompras";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private MonthCalendar monthCalendar1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private TextBox textBox2;
        private Button button2;
    }
}