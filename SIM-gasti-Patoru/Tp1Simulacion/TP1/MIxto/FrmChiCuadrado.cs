using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp1Simulacion.MIxto
{
    public partial class FrmChiCuadrado : Form
    {
        double frecE = 0;

        private List<double> numerosRND;
        private int intervalos;
        private bool hipotesis = false;
        public FrmChiCuadrado(int cantI, List<double> nrsRnd)
        {
            intervalos = cantI;
            numerosRND = nrsRnd;
            

            InitializeComponent();

        }

        private void FrmChiCuadrado_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private List<string> cargarTabla()
        {
            double linf = 0;
            double lsup = 0;
            double l = intervalos;
            double fe = numerosRND.Count / l; // Obtenemos la frecuencia esperada para cada intervalo
            int cantIntervalo = 0;
            string nomIntervalo;
            double c;
            double cAcum = 0;
            List<string> intervalosTabla = new List<string>();
            double marcaClase;

            for (int i = 0; i < intervalos; i++)
            {

                double intervalo = (1 / l);
                lsup += intervalo;
                cantIntervalo = calcularIntervalos(linf, lsup);
                nomIntervalo = Math.Round(linf,4) + " - " + Math.Round(lsup, 4);
                c = calcularChi(fe, cantIntervalo);
                marcaClase = (linf + lsup) / 2;
                cAcum += c;
                dgvChiCuadrado.Rows.Add(nomIntervalo, cantIntervalo, Math.Round(fe,4), Math.Round(marcaClase,4), Math.Round(c, 4), Math.Round(cAcum, 4 ));

                intervalosTabla.Add(nomIntervalo);

                linf = lsup;
            }
            txtCoeficiente.Text = cAcum.ToString();
            if (cAcum <= obtenerValorTabulado())
            {
                hipotesis = true;
            }
            if (hipotesis)
            {
                LblHipotesis.Text = "No se rechaza la hipotesis";
            }
            else
            {
                LblHipotesis.Text = "Se rechaza la hipotesis";
            }
            return intervalosTabla;
        }

        private double calcularChi(double fe, int fo)
        {
            return Math.Pow((fo - fe), 2) / fe;
        }

        private List<int> ContarCantidades()
        {
            double linf = 0;
            double lsup = 0;
            double l = intervalos;
            int cantIntervalo = 0;
            List<int> cantidades = new List<int>();


            for (int i = 0; i < intervalos; i++)
            {
                double intervalo = (1 / l);
                lsup += intervalo;
                cantIntervalo = calcularIntervalos(linf, lsup);
                cantidades.Add(cantIntervalo);
                linf = lsup;
            }
            return cantidades;
        }
        


        private int calcularIntervalos(double linf,double lsup)
        {
            int cantidad = 0;
            foreach (var n in numerosRND)
            {
                if (n >= linf && n < lsup)
                    cantidad++;
            }
            return cantidad;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMostrarGraf_Click(object sender, EventArgs e)
        {
            dgvChiCuadrado.Rows.Clear();

            List<int> vectorCantidades = ContarCantidades();
            List <string>vectoresInt= cargarTabla();
            frecE = Math.Round((double)numerosRND.Count / intervalos, 4);
            new FrmGraf(vectoresInt, vectorCantidades, frecE).ShowDialog();
        }

        private double obtenerValorTabulado()
        {
            // el grado de coso es de 95%
            double valorCritico = 0;
            int gradLib = intervalos - 1;
            if(gradLib == 4)
            {
                valorCritico = 9.49;
            }
            if(gradLib == 7)
            {
                valorCritico = 14.1;
            }
            if(gradLib == 9)
            {
                valorCritico = 16.9;
            }
            if(gradLib == 11)
            {
                valorCritico = 19.7;
            }
            return valorCritico;
        }
    }
}
