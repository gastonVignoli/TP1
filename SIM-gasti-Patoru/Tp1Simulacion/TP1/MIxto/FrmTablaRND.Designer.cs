
namespace Tp1Simulacion.MIxto
{
    partial class FrmTablaRND
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
            this.DgvRnds = new System.Windows.Forms.DataGridView();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.axiC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Random = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbIntervalos = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRnds)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvRnds
            // 
            this.DgvRnds.AllowUserToAddRows = false;
            this.DgvRnds.AllowUserToDeleteRows = false;
            this.DgvRnds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRnds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.i,
            this.axiC,
            this.Region,
            this.Random});
            this.DgvRnds.Location = new System.Drawing.Point(30, 12);
            this.DgvRnds.MultiSelect = false;
            this.DgvRnds.Name = "DgvRnds";
            this.DgvRnds.ReadOnly = true;
            this.DgvRnds.RowHeadersWidth = 51;
            this.DgvRnds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRnds.Size = new System.Drawing.Size(310, 386);
            this.DgvRnds.TabIndex = 32;
            // 
            // i
            // 
            this.i.HeaderText = "i";
            this.i.MinimumWidth = 6;
            this.i.Name = "i";
            this.i.ReadOnly = true;
            this.i.Width = 50;
            // 
            // axiC
            // 
            this.axiC.FillWeight = 50F;
            this.axiC.HeaderText = "a*Xi+c";
            this.axiC.MinimumWidth = 6;
            this.axiC.Name = "axiC";
            this.axiC.ReadOnly = true;
            this.axiC.Width = 50;
            // 
            // Region
            // 
            this.Region.HeaderText = "Xi + 1";
            this.Region.MinimumWidth = 6;
            this.Region.Name = "Region";
            this.Region.ReadOnly = true;
            this.Region.Width = 60;
            // 
            // Random
            // 
            this.Random.FillWeight = 65F;
            this.Random.HeaderText = "RND";
            this.Random.MinimumWidth = 6;
            this.Random.Name = "Random";
            this.Random.ReadOnly = true;
            this.Random.Width = 65;
            // 
            // cmbIntervalos
            // 
            this.cmbIntervalos.FormattingEnabled = true;
            this.cmbIntervalos.Items.AddRange(new object[] {
            "5",
            "8",
            "10",
            "12"});
            this.cmbIntervalos.Location = new System.Drawing.Point(30, 413);
            this.cmbIntervalos.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIntervalos.Name = "cmbIntervalos";
            this.cmbIntervalos.Size = new System.Drawing.Size(135, 21);
            this.cmbIntervalos.TabIndex = 33;
            this.cmbIntervalos.Text = "Cantidad de intervalos";
            this.cmbIntervalos.ValueMember = "5";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(234, 403);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 31);
            this.button1.TabIndex = 34;
            this.button1.Text = "Prueba chi cuadrado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PuebaCH);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(265, 446);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 27);
            this.btnVolver.TabIndex = 35;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmTablaMixto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 484);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbIntervalos);
            this.Controls.Add(this.DgvRnds);
            this.Name = "FrmTablaMixto";
            this.Text = "Tabla Generada";
            this.Load += new System.EventHandler(this.FrmTablaMixto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRnds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRnds;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn axiC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn Random;
        private System.Windows.Forms.ComboBox cmbIntervalos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVolver;
    }
}