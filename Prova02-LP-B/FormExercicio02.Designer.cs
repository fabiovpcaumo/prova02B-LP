namespace Prova02_LP_B
{
    partial class FormExercicio02
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
            this.tbArrayValues = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPositiveNumbers = new System.Windows.Forms.TextBox();
            this.tbCountNegativeNumbers = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNewNumber = new System.Windows.Forms.TextBox();
            this.btnAddToArray = new System.Windows.Forms.Button();
            this.btnClearArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbArrayValues
            // 
            this.tbArrayValues.Location = new System.Drawing.Point(312, 70);
            this.tbArrayValues.Name = "tbArrayValues";
            this.tbArrayValues.ReadOnly = true;
            this.tbArrayValues.Size = new System.Drawing.Size(100, 20);
            this.tbArrayValues.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Array:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numeros Positivos";
            // 
            // tbPositiveNumbers
            // 
            this.tbPositiveNumbers.Location = new System.Drawing.Point(312, 114);
            this.tbPositiveNumbers.Name = "tbPositiveNumbers";
            this.tbPositiveNumbers.ReadOnly = true;
            this.tbPositiveNumbers.Size = new System.Drawing.Size(100, 20);
            this.tbPositiveNumbers.TabIndex = 3;
            // 
            // tbCountNegativeNumbers
            // 
            this.tbCountNegativeNumbers.Location = new System.Drawing.Point(312, 160);
            this.tbCountNegativeNumbers.Name = "tbCountNegativeNumbers";
            this.tbCountNegativeNumbers.ReadOnly = true;
            this.tbCountNegativeNumbers.Size = new System.Drawing.Size(100, 20);
            this.tbCountNegativeNumbers.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Qtde. Negativos";
            // 
            // tbNewNumber
            // 
            this.tbNewNumber.Location = new System.Drawing.Point(255, 302);
            this.tbNewNumber.Name = "tbNewNumber";
            this.tbNewNumber.Size = new System.Drawing.Size(100, 20);
            this.tbNewNumber.TabIndex = 7;
            // 
            // btnAddToArray
            // 
            this.btnAddToArray.Location = new System.Drawing.Point(361, 299);
            this.btnAddToArray.Name = "btnAddToArray";
            this.btnAddToArray.Size = new System.Drawing.Size(145, 23);
            this.btnAddToArray.TabIndex = 8;
            this.btnAddToArray.Text = "Adicionar ao Array";
            this.btnAddToArray.UseVisualStyleBackColor = true;
            this.btnAddToArray.Click += new System.EventHandler(this.BtnAddToArray_Click);
            // 
            // btnClearArray
            // 
            this.btnClearArray.Location = new System.Drawing.Point(337, 343);
            this.btnClearArray.Name = "btnClearArray";
            this.btnClearArray.Size = new System.Drawing.Size(75, 23);
            this.btnClearArray.TabIndex = 9;
            this.btnClearArray.Text = "Limpar Array";
            this.btnClearArray.UseVisualStyleBackColor = true;
            this.btnClearArray.Click += new System.EventHandler(this.BtnClearArray_Click);
            // 
            // FormExercicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearArray);
            this.Controls.Add(this.btnAddToArray);
            this.Controls.Add(this.tbNewNumber);
            this.Controls.Add(this.tbCountNegativeNumbers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPositiveNumbers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbArrayValues);
            this.Name = "FormExercicio02";
            this.Text = "FormExercicio02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbArrayValues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPositiveNumbers;
        private System.Windows.Forms.TextBox tbCountNegativeNumbers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNewNumber;
        private System.Windows.Forms.Button btnAddToArray;
        private System.Windows.Forms.Button btnClearArray;
    }
}