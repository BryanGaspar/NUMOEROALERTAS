using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NUMOEROALERTAS
{
    public partial class frmMisionDeCheque : Form
    {
        public frmMisionDeCheque()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //UTILS.numerosLetras.testUnidades();
            if (txtCantidad.Text.Length == 0)
            {
                MessageBox.Show("Ingresa el valor del cheque", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCantidad.Focus();
                return;
            }
            else if (txtPagueseAlaOrdenDe.Text.Length == 0)
            {
                MessageBox.Show("Ingresa el nombre del remitente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPagueseAlaOrdenDe.Focus();
                return;
            }
            else
            {
                int num = Int32.Parse(this.txtCantidad.Text);
                this.txtResultados.Text = UTILS.numerosLetras.getMillones(num) + " Dólares";
            } 

            }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void txtPagueseAlaOrdenDe_TextChanged(object sender, EventArgs e)
        {
           
            pictureBox1.Visible = true;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo números enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
