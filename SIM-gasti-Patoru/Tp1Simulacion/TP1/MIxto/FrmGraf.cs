using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Tp1Simulacion.MIxto
{
    
    public partial class FrmGraf : Form
    {
        private List <string> Vi;
        private List<int> Vic;
        private double Fe;

        public FrmGraf(List <string> vector, List<int> vector2, double fe)
        {
            Vi = vector;
            Vic = vector2;
            Fe = fe;
            InitializeComponent();
        }


        private void FrmGraf_Load(object sender, EventArgs e)
        {
            fillChart();
        }
        private void fillChart()
        {
            //AddXY value in chart1 in series named as Salary
            
            for (int i = 0; i < Vi.Count; i++)
            {

                chart1.Series["Cant. x Int."].Points.AddXY(Vi[i], Vic[i]);
                            }

            chart1.Palette = ChartColorPalette.Pastel;
            chart1.Titles.Add("Histograma de Frecuencias ");
            lblFe.Text = "Frecuencia Esperada: " + Fe;
           
            for (int i = 0; i < Vi.Count; i++)
            {

                chart2.Series["Frec. Esperada"].Points.AddXY(Vi[i], Fe);
            }

        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

