
namespace Tp1Simulacion
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMultiplicativo = new System.Windows.Forms.Button();
            this.BtnMixto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione una de las 2 opciones";
            // 
            // BtnMultiplicativo
            // 
            this.BtnMultiplicativo.Location = new System.Drawing.Point(34, 76);
            this.BtnMultiplicativo.Name = "BtnMultiplicativo";
            this.BtnMultiplicativo.Size = new System.Drawing.Size(77, 49);
            this.BtnMultiplicativo.TabIndex = 1;
            this.BtnMultiplicativo.Text = "Metodo Multiplicativo";
            this.BtnMultiplicativo.UseVisualStyleBackColor = true;
            this.BtnMultiplicativo.Click += new System.EventHandler(this.BtnMultiplicativo_Click);
            // 
            // BtnMixto
            // 
            this.BtnMixto.Location = new System.Drawing.Point(165, 76);
            this.BtnMixto.Name = "BtnMixto";
            this.BtnMixto.Size = new System.Drawing.Size(97, 49);
            this.BtnMixto.TabIndex = 2;
            this.BtnMixto.Text = "Metodo Congruencial Mixto";
            this.BtnMixto.UseVisualStyleBackColor = true;
            this.BtnMixto.Click += new System.EventHandler(this.BtnMixto_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 154);
            this.Controls.Add(this.BtnMixto);
            this.Controls.Add(this.BtnMultiplicativo);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnMultiplicativo;
        private System.Windows.Forms.Button BtnMixto;
    }
}