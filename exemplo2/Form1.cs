using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo2
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt32(txtNumero.Text);

            if (num > 10 && num < 20)
            {
                lblResposta.Text = "Número no intervalo 10 e 20";
            }
            else
            {
                lblResposta.Text = "Número fora do intervalo 10 e 20";
            }
        }
    }
}