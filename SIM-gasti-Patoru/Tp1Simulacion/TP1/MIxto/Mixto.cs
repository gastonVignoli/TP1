using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp1Simulacion.MIxto;

namespace Tp1Simulacion
{
    public partial class frmGenerarMixto : Form
    {
        private Menu principal;
        public frmGenerarMixto(Menu _principal)
        {
            principal = _principal;
            InitializeComponent();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            double g = Convert.ToDouble(NumG.Value);
            double l = Math.Pow(2, g);
            long m = Convert.ToInt64(l);
            int N = Convert.ToInt32(NumN.Value);
            int a = 1 + 4 * Convert.ToInt32(NumK.Value);
            int c = Convert.ToInt32(NumC.Value);
            int X0 = Convert.ToInt32(NumX0.Value);
            if (ValidarCampos(N , m , c, X0))
            {
                var frmTablaMixto = new FrmTablaRND(a, X0, c, m, N, this);
                frmTablaMixto.Show();
                this.Hide();
            }
            
        }
        //private void BtnMixto_Click(object sender, EventArgs e)
        //{
        //    var frmMixto = new frmGenerarMixto(this);
        //    frmMixto.Show();
        //    this.Hide();


            private Boolean CalcularMCD (int num1 , long num2)
        {
            //Seleccionamos el mayor y el menor para asignar a "a" y "b".
            long a = Math.Max(num1, num2);
            long b = Math.Min(num1, num2);
            long res;
            //Comienza el ciclo
            do
            {
                res = b;    //Guardamos el divisor en el resultado
                b = a % b;  //Guardamos el resto en el divisor
                a = res;    // El divisor pasa al dividendo
            } while (b != 0);
            if(res == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            
        private Boolean ValidarCampos(int N , long m , int c , int X0)
        {
            
            if ( N > m)
            {
                DialogResult resultado = MessageBox.Show("No debe seleccionar un N mayor a: " + m, "Informacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return false;
            }

            if (c != 0)
            {
                if (!CalcularMCD(c , m ))
                {
                    MessageBox.Show("Para la variable C se recomienda que sea relativamente primo a "+ m, "Atención!", MessageBoxButtons.OK);
                    return true;
                }
             }
            return true;
            //if ( !CalcularMCD(X0,m))
            //{
            //    MessageBox.Show("La semilla X0 debe ser relativamente primo a M", "Cuidado!", MessageBoxButtons.OK);
            //}
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {   principal.Show();
            this.Dispose();
            
        }

        private void frmGenerarMixto_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
