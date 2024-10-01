namespace Libreria_Practicas.AdminVentas
{
    partial class CobroEfectivo
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
            button3 = new Button();
            textBox1 = new TextBox();
            monthCalendar1 = new MonthCalendar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 7;
            label1.Text = "Devoluciones";
            // 
            // button3
            // 
            button3.Location = new Point(339, 319);
            button3.Name = "button3";
            button3.Size = new Size(85, 23);
            button3.TabIndex = 19;
            button3.Text = "Enviar a caja";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(314, 110);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ingrese monto total :";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 18;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(289, 145);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 20;
            // 
            // CobroEfectivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(monthCalendar1);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "CobroEfectivo";
            Text = "CobroEfectivo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button3;
        private TextBox textBox1;
        private MonthCalendar monthCalendar1;
    }
}