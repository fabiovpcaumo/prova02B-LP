namespace Prova02_LP_B
{
    partial class FormOption1
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
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.tbFahrenheit = new System.Windows.Forms.TextBox();
            this.tbCelsius = new System.Windows.Forms.TextBox();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(198, 100);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(88, 13);
            this.lblFahrenheit.TabIndex = 0;
            this.lblFahrenheit.Text = "Graus Fahrenheit";
            // 
            // tbFahrenheit
            // 
            this.tbFahrenheit.Location = new System.Drawing.Point(340, 97);
            this.tbFahrenheit.Name = "tbFahrenheit";
            this.tbFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.tbFahrenheit.TabIndex = 1;
            // 
            // tbCelsius
            // 
            this.tbCelsius.Location = new System.Drawing.Point(340, 142);
            this.tbCelsius.Name = "tbCelsius";
            this.tbCelsius.ReadOnly = true;
            this.tbCelsius.Size = new System.Drawing.Size(100, 20);
            this.tbCelsius.TabIndex = 3;
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(198, 145);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(71, 13);
            this.lblCelsius.TabIndex = 2;
            this.lblCelsius.Text = "Graus Celsius";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(340, 222);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Converter";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
            // 
            // FormOption1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.tbCelsius);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.tbFahrenheit);
            this.Controls.Add(this.lblFahrenheit);
            this.Name = "FormOption1";
            this.Text = "FormOption1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.TextBox tbFahrenheit;
        private System.Windows.Forms.TextBox tbCelsius;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Button btnConvert;
    }
}