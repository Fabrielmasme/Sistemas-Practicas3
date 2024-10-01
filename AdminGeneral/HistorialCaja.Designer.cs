namespace Libreria_Practicas.AdminGeneral
{
    partial class HistorialCaja
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
            monthCalendar1 = new MonthCalendar();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 271);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 289);
            dataGridView1.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(18, 97);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(695, 162);
            button1.Name = "button1";
            button1.Size = new Size(93, 23);
            button1.TabIndex = 2;
            button1.Text = "Cierre del mes";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 3;
            label1.Text = "Historial de caja";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(101, 409);
            label2.Name = "label2";
            label2.Size = new Size(433, 15);
            label2.TabIndex = 4;
            label2.Text = "Se puede ver el ingreso mensual del cierre de caja y ver los cierres de cajas diarios";
            // 
            // HistorialCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 572);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(monthCalendar1);
            Controls.Add(dataGridView1);
            Name = "HistorialCaja";
            Text = "HistorialCaja";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MonthCalendar monthCalendar1;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}