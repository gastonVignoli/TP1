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
using Tp1Simulacion.Multiplicativo;

namespace Tp1Simulacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BtnMultiplicativo_Click(object sender, EventArgs e)
        {
            var frmMulti = new FrmMultuplicativo(this);
            frmMulti.Show();
            this.Hide();

        }

        private void BtnMixto_Click(object sender, EventArgs e)
        {
            var frmMixto = new frmGenerarMixto(this);
            frmMixto.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
