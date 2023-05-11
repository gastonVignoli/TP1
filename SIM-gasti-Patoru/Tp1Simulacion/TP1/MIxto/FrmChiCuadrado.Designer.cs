namespace Tp1Simulacion.MIxto
{
    partial class FrmChiCuadrado
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
            this.dgvChiCuadrado = new System.Windows.Forms.DataGridView();
            this.intervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCoeficiente = new System.Windows.Forms.Label();
            this.txtCoeficiente = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnMostrarGraf = new System.Windows.Forms.Button();
            this.LblHipotesis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiCuadrado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChiCuadrado
            // 
            this.dgvChiCuadrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiCuadrado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intervalo,
            this.fo,
            this.fe,
            this.MarcaClase,
            this.c,
            this.cac});
            this.dgvChiCuadrado.Location = new System.Drawing.Point(9, 25);
            this.dgvChiCuadrado.Margin = new System.Windows.Forms.Padding(2);
            this.dgvChiCuadrado.Name = "dgvChiCuadrado";
            this.dgvChiCuadrado.RowHeadersWidth = 51;
            this.dgvChiCuadrado.RowTemplate.Height = 24;
            this.dgvChiCuadrado.Size = new System.Drawing.Size(778, 310);
            this.dgvChiCuadrado.TabIndex = 0;
            // 
            // intervalo
            // 
            this.intervalo.HeaderText = "Intervalo";
            this.intervalo.MaxInputLength = 10;
            this.intervalo.MinimumWidth = 6;
            this.intervalo.Name = "intervalo";
            this.intervalo.ReadOnly = true;
            this.intervalo.Width = 125;
            // 
            // fo
            // 
            this.fo.HeaderText = "Frec. Observada";
            this.fo.MaxInputLength = 10;
            this.fo.MinimumWidth = 6;
            this.fo.Name = "fo";
            this.fo.ReadOnly = true;
            this.fo.Width = 125;
            // 
            // fe
            // 
            this.fe.HeaderText = "Frec Esperada";
            this.fe.MaxInputLength = 10;
            this.fe.MinimumWidth = 6;
            this.fe.Name = "fe";
            this.fe.ReadOnly = true;
            this.fe.Width = 125;
            // 
            // MarcaClase
            // 
            this.MarcaClase.HeaderText = "Marca de clase";
            this.MarcaClase.MaxInputLength = 10;
            this.MarcaClase.Name = "MarcaClase";
            this.MarcaClase.ReadOnly = true;
            // 
            // c
            // 
            this.c.HeaderText = "C";
            this.c.MaxInputLength = 10;
            this.c.MinimumWidth = 6;
            this.c.Name = "c";
            this.c.ReadOnly = true;
            this.c.Width = 125;
            // 
            // cac
            // 
            this.cac.HeaderText = "C acumulado";
            this.cac.MaxInputLength = 10;
            this.cac.MinimumWidth = 6;
            this.cac.Name = "cac";
            this.cac.ReadOnly = true;
            this.cac.Width = 125;
            // 
            // lblCoeficiente
            // 
            this.lblCoeficiente.AutoSize = true;
            this.lblCoeficiente.Location = new System.Drawing.Point(430, 344);
            this.lblCoeficiente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCoeficiente.Name = "lblCoeficiente";
            this.lblCoeficiente.Size = new System.Drawing.Size(130, 13);
            this.lblCoeficiente.TabIndex = 1;
            this.lblCoeficiente.Text = "Coeficiente Chi Cuadrado:";
            // 
            // txtCoeficiente
            // 
            this.txtCoeficiente.Enabled = false;
            this.txtCoeficiente.Location = new System.Drawing.Point(555, 342);
            this.txtCoeficiente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCoeficiente.Name = "txtCoeficiente";
            this.txtCoeficiente.Size = new System.Drawing.Size(76, 20);
            this.txtCoeficiente.TabIndex = 2;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(700, 394);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(87, 36);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnMostrarGraf
            // 
            this.btnMostrarGraf.Location = new System.Drawing.Point(598, 394);
            this.btnMostrarGraf.Name = "btnMostrarGraf";
            this.btnMostrarGraf.Size = new System.Drawing.Size(97, 36);
            this.btnMostrarGraf.TabIndex = 4;
            this.btnMostrarGraf.Text = "Mostrar gráfico";
            this.btnMostrarGraf.UseVisualStyleBackColor = true;
            this.btnMostrarGraf.Click += new System.EventHandler(this.btnMostrarGraf_Click);
            // 
            // LblHipotesis
            // 
            this.LblHipotesis.AutoSize = true;
            this.LblHipotesis.Location = new System.Drawing.Point(644, 345);
            this.LblHipotesis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblHipotesis.Name = "LblHipotesis";
            this.LblHipotesis.Size = new System.Drawing.Size(0, 13);
            this.LblHipotesis.TabIndex = 5;
            // 
            // FrmChiCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.LblHipotesis);
            this.Controls.Add(this.btnMostrarGraf);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtCoeficiente);
            this.Controls.Add(this.lblCoeficiente);
            this.Controls.Add(this.dgvChiCuadrado);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmChiCuadrado";
            this.Text = "FrmChiCuadrado";
            this.Load += new System.EventHandler(this.FrmChiCuadrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiCuadrado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChiCuadrado;
        private System.Windows.Forms.Label lblCoeficiente;
        private System.Windows.Forms.TextBox txtCoeficiente;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnMostrarGraf;
        private System.Windows.Forms.DataGridViewTextBoxColumn intervalo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn cac;
        private System.Windows.Forms.Label LblHipotesis;
    }
}