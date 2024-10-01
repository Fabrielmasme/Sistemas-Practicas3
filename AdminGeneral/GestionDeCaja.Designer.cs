namespace Libreria_Practicas.AdminGeneral
{
    partial class GestionDeCaja
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
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            monthCalendar1 = new MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Caja";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 170);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(228, 182);
            label2.Name = "label2";
            label2.Size = new Size(231, 15);
            label2.TabIndex = 2;
            label2.Text = "Se pueden gestionar los ingresos y egresos";
            // 
            // button1
            // 
            button1.Location = new Point(677, 17);
            button1.Name = "button1";
            button1.Size = new Size(111, 23);
            button1.TabIndex = 3;
            button1.Text = "Historial de caja";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(677, 415);
            button2.Name = "button2";
            button2.Size = new Size(111, 23);
            button2.TabIndex = 4;
            button2.Text = "Cerrar Caja";
            button2.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(12, 330);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 5;
            // 
            // GestionDeCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 510);
            Controls.Add(monthCalendar1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "GestionDeCaja";
            Text = "GestionDeCaja";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Button button1;
        private Button button2;
        private MonthCalendar monthCalendar1;
    }
}