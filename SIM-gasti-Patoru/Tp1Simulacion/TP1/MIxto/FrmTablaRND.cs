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
    public partial class FrmTablaRND : Form
    {
        private double A;
        private double C;
        private double X0;
        private double M;
        private double N;
        private List<double> numerosRND;
        private Form frmVolver;


        public FrmTablaRND(double a, double x0, double c,double m ,double n, Form frmAnterior)
        {
            A = a;
            X0 = x0;
            C = c;
            M = m;
            N = n;
            frmVolver = frmAnterior;
            InitializeComponent();
        }

        private void FrmTablaMixto_Load(object sender, EventArgs e)
        {
            var numeros = GenerarNumeros(A, X0, C, M, N);
        }
        
        private List<double> GenerarNumeros(double a, double X0, double c, double m, double n)
        {
            
            List<double> numerosRnd = new List<double>();
            int i = 0;
            do
            {
                double xic = (a * X0 + c);
                double num = xic % m;
                X0 = num;
                double rnd = Math.Round(num / m, 4);
                numerosRnd.Add(rnd);
                n -= 1;

                DgvRnds.Rows.Add(i,xic,X0, rnd);
                
                i += 1;
            } while (n != 0);
            numerosRND = numerosRnd;
            return numerosRnd;
        }

        private void PuebaCH(object sender, EventArgs e)
        {
          
            if (ValidarInt())
            {
                int seleccionIntervalos = Convert.ToInt32(cmbIntervalos.SelectedItem);
                new FrmChiCuadrado(seleccionIntervalos, numerosRND).ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una opcion de cantidad de intervalos", "Informacion", MessageBoxButtons.OK);
            }
           
        }

        private bool ValidarInt()
        {
            if(cmbIntervalos.SelectedItem == null)
            {
                return false;
            }
            return true;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmVolver.Show();
            this.Dispose();
        }
    }
}
