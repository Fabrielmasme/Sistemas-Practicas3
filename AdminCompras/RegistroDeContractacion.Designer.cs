namespace Libreria_Practicas.AdminCompras
{
    partial class RegistroDeContractacion
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
            monthCalendar1 = new MonthCalendar();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(18, 378);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(688, 517);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Nombre del proveedor :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(218, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "Buscar ISBN :";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(745, 233);
            dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(18, 19);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 5;
            label1.Text = "¡ Contactá a tu proveedor !";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(414, 34);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(190, 23);
            textBox3.TabIndex = 6;
            textBox3.Text = "Numero de orden de compra :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(171, 230);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Location = new Point(66, 230);
            label3.Name = "label3";
            label3.Size = new Size(510, 15);
            label3.TabIndex = 8;
            label3.Text = "Acá se va a poder registrar la cantidad de libros que se hacen en la compra, precio del costo, etc";
            // 
            // RegistroDeContractacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 558);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(monthCalendar1);
            Name = "RegistroDeContractacion";
            Text = "Registro de Contactacion";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
    }
}