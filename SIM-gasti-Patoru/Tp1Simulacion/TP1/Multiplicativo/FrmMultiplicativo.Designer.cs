﻿
namespace Tp1Simulacion.Multiplicativo
{
    partial class FrmMultuplicativo
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
            this.NumG = new System.Windows.Forms.NumericUpDown();
            this.NumX0 = new System.Windows.Forms.NumericUpDown();
            this.NumK = new System.Windows.Forms.NumericUpDown();
            this.NumN = new System.Windows.Forms.NumericUpDown();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.LblX0 = new System.Windows.Forms.Label();
            this.LblG = new System.Windows.Forms.Label();
            this.LblK = new System.Windows.Forms.Label();
            this.LblN = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumX0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumN)).BeginInit();
            this.SuspendLayout();
            // 
            // NumG
            // 
            this.NumG.Location = new System.Drawing.Point(101, 101);
            this.NumG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumG.Maximum = new decimal(new int[] {
            100999999,
            0,
            0,
            0});
            this.NumG.Name = "NumG";
            this.NumG.Size = new System.Drawing.Size(133, 22);
            this.NumG.TabIndex = 51;
            this.NumG.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // NumX0
            // 
            this.NumX0.Location = new System.Drawing.Point(101, 146);
            this.NumX0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumX0.Maximum = new decimal(new int[] {
            100999999,
            0,
            0,
            0});
            this.NumX0.Name = "NumX0";
            this.NumX0.Size = new System.Drawing.Size(133, 22);
            this.NumX0.TabIndex = 50;
            this.NumX0.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // NumK
            // 
            this.NumK.Location = new System.Drawing.Point(101, 59);
            this.NumK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumK.Maximum = new decimal(new int[] {
            10099999,
            0,
            0,
            0});
            this.NumK.Name = "NumK";
            this.NumK.Size = new System.Drawing.Size(133, 22);
            this.NumK.TabIndex = 49;
            this.NumK.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // NumN
            // 
            this.NumN.Location = new System.Drawing.Point(101, 15);
            this.NumN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumN.Maximum = new decimal(new int[] {
            1009999,
            0,
            0,
            0});
            this.NumN.Name = "NumN";
            this.NumN.Size = new System.Drawing.Size(133, 22);
            this.NumN.TabIndex = 47;
            this.NumN.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.BackColor = System.Drawing.Color.White;
            this.BtnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerar.ForeColor = System.Drawing.Color.Black;
            this.BtnGenerar.Location = new System.Drawing.Point(383, 199);
            this.BtnGenerar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(100, 50);
            this.BtnGenerar.TabIndex = 46;
            this.BtnGenerar.Text = "Generar";
            this.BtnGenerar.UseVisualStyleBackColor = false;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // LblX0
            // 
            this.LblX0.AutoSize = true;
            this.LblX0.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblX0.Location = new System.Drawing.Point(20, 150);
            this.LblX0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblX0.Name = "LblX0";
            this.LblX0.Size = new System.Drawing.Size(34, 21);
            this.LblX0.TabIndex = 44;
            this.LblX0.Text = "X0:";
            // 
            // LblG
            // 
            this.LblG.AutoSize = true;
            this.LblG.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblG.Location = new System.Drawing.Point(20, 105);
            this.LblG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblG.Name = "LblG";
            this.LblG.Size = new System.Drawing.Size(30, 21);
            this.LblG.TabIndex = 43;
            this.LblG.Text = "G:";
            // 
            // LblK
            // 
            this.LblK.AutoSize = true;
            this.LblK.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblK.Location = new System.Drawing.Point(20, 63);
            this.LblK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblK.Name = "LblK";
            this.LblK.Size = new System.Drawing.Size(25, 21);
            this.LblK.TabIndex = 42;
            this.LblK.Text = "K:";
            // 
            // LblN
            // 
            this.LblN.AutoSize = true;
            this.LblN.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblN.Location = new System.Drawing.Point(20, 18);
            this.LblN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblN.Name = "LblN";
            this.LblN.Size = new System.Drawing.Size(28, 21);
            this.LblN.TabIndex = 41;
            this.LblN.Text = "N:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(276, 201);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 50);
            this.btnVolver.TabIndex = 52;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 16);
            this.label5.TabIndex = 57;
            this.label5.Text = "Semilla de generación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "2^g = M (Modulo)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "1 + 4K = A (cte mul)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Nros. a Generar";
            // 
            // FrmMultuplicativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 265);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.NumG);
            this.Controls.Add(this.NumX0);
            this.Controls.Add(this.NumK);
            this.Controls.Add(this.NumN);
            this.Controls.Add(this.BtnGenerar);
            this.Controls.Add(this.LblX0);
            this.Controls.Add(this.LblG);
            this.Controls.Add(this.LblK);
            this.Controls.Add(this.LblN);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMultuplicativo";
            this.Text = "FormMultuplicativo";
            this.Load += new System.EventHandler(this.FrmMultuplicativo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumX0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumG;
        private System.Windows.Forms.NumericUpDown NumX0;
        private System.Windows.Forms.NumericUpDown NumK;
        private System.Windows.Forms.NumericUpDown NumN;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.Label LblX0;
        private System.Windows.Forms.Label LblG;
        private System.Windows.Forms.Label LblK;
        private System.Windows.Forms.Label LblN;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}