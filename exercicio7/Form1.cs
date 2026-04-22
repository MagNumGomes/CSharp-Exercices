using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_7___Aula_2
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nome = Convert.ToString(txtNomeBox.Text);
            int horas = Convert.ToInt32(txtHorasBox.Text);
            double valor = Convert.ToDouble(txtValorBox.Text);

            if (horas <= 20)
            {
                lblResposta1.Text = $"{nome} usou {horas}";
                lblResposta2.Text = $"e deve pagar R$ {valor}";  
            }
            else if (horas > 20)
            {
                valor = valor / 0.5;
                lblResposta1.Text = $"{nome} usou {horas}";
                lblResposta2.Text = $"e deve pagar R$ {valor}";
            }
            else
            {
                lblResposta1.Text = "Preencha os espaços a cima";
            }

        }
    }
}
