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


namespace Tp1Simulacion.Multiplicativo
{
    public partial class FrmMultuplicativo : Form
    {
        
        private Menu principal;
        public FrmMultuplicativo(Menu _principal)
        {
            principal = _principal;
            InitializeComponent();
        }
        
        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            principal.Show();
            this.Dispose();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            double g = Convert.ToDouble(NumG.Value);
            double l = Math.Pow(2, g);
            long m = Convert.ToInt64(l);
            int N = Convert.ToInt32(NumN.Value);
            int a = 1 + 4 * Convert.ToInt32(NumK.Value);
            int X0 = Convert.ToInt32(NumX0.Value);
            if (ValidarCampos(N, m, X0))
            {
                new FrmTablaRND( a, X0,  0,  m, N, this).Show();
                this.Hide();
            }
        }
        private Boolean ValidarCampos(int N, long m, int X0)
        {

            if (N > m)
            {
                MessageBox.Show("No debe seleccionar un N mayor a: " + m, "Informacion", MessageBoxButtons.OK);
                return false;
            }
            if (X0 % 2 == 0)
            {
                DialogResult resultado = MessageBox.Show("Se recomienda que X0 sea impar", "Recomendacion ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return false;
            }
    
            return true;
            //if ( !CalcularMCD(X0,m))
            //{
            //    MessageBox.Show("La semilla X0 debe ser relativamente primo a M", "Cuidado!", MessageBoxButtons.OK);
            //}
        }
        private Boolean CalcularMCD(int num1, int num2)
        {
            //Seleccionamos el mayor y el menor para asignar a "a" y "b".
            int a = Math.Max(num1, num2);
            int b = Math.Min(num1, num2);
            int res;
            //Comienza el ciclo
            do
            {
                res = b;    //Guardamos el divisor en el resultado
                b = a % b;  //Guardamos el resto en el divisor
                a = res;    // El divisor pasa al dividendo
            } while (b != 0);
            if (res == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void FrmMultuplicativo_Load(object sender, EventArgs e)
        {

        }
    }


}
