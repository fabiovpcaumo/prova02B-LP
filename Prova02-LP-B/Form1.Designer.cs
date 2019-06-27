namespace Prova02_LP_B
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOption1 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.btnOption4 = new System.Windows.Forms.Button();
            this.btnOption5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOption1
            // 
            this.btnOption1.Location = new System.Drawing.Point(278, 129);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(210, 23);
            this.btnOption1.TabIndex = 0;
            this.btnOption1.Text = "1 - Conversão de Temperatura";
            this.btnOption1.UseVisualStyleBackColor = true;
            this.btnOption1.Click += new System.EventHandler(this.BtnOption1_Click);
            // 
            // btnOption2
            // 
            this.btnOption2.Location = new System.Drawing.Point(278, 158);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(210, 23);
            this.btnOption2.TabIndex = 1;
            this.btnOption2.Text = "2 - Consumo Médio";
            this.btnOption2.UseVisualStyleBackColor = true;
            this.btnOption2.Click += new System.EventHandler(this.BtnOption2_Click);
            // 
            // btnOption3
            // 
            this.btnOption3.Location = new System.Drawing.Point(278, 187);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(210, 23);
            this.btnOption3.TabIndex = 2;
            this.btnOption3.Text = "3 - Salário Final";
            this.btnOption3.UseVisualStyleBackColor = true;
            this.btnOption3.Click += new System.EventHandler(this.BtnOption3_Click);
            // 
            // btnOption4
            // 
            this.btnOption4.Location = new System.Drawing.Point(278, 216);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(210, 23);
            this.btnOption4.TabIndex = 3;
            this.btnOption4.Text = "4 - Troca de Valores";
            this.btnOption4.UseVisualStyleBackColor = true;
            this.btnOption4.Click += new System.EventHandler(this.BtnOption4_Click);
            // 
            // btnOption5
            // 
            this.btnOption5.Location = new System.Drawing.Point(278, 245);
            this.btnOption5.Name = "btnOption5";
            this.btnOption5.Size = new System.Drawing.Size(210, 23);
            this.btnOption5.TabIndex = 4;
            this.btnOption5.Text = "5 - Sair";
            this.btnOption5.UseVisualStyleBackColor = true;
            this.btnOption5.Click += new System.EventHandler(this.BtnOption5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Opções";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOption5);
            this.Controls.Add(this.btnOption4);
            this.Controls.Add(this.btnOption3);
            this.Controls.Add(this.btnOption2);
            this.Controls.Add(this.btnOption1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOption1;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Button btnOption3;
        private System.Windows.Forms.Button btnOption4;
        private System.Windows.Forms.Button btnOption5;
        private System.Windows.Forms.Label label1;
    }
}

