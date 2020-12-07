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
            int num = Int32.Parse(this.txtCantidad.Text);
            this.txtResultados.Text = UTILS.numerosLetras.getCentenas(num);
        }
        }
}
