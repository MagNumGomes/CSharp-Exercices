using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_1
{
    public partial class frmMes : Form
    {
        public frmMes()
        {
            InitializeComponent();
        }

        private void bntConversor_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt32(txtNumero.Text);

            if (num == 1)
            {
                lblResposta.Text = "Janeiro";
            }
            else if (num == 2)
            {
                lblResposta.Text = "Fevereiro";
            }
            else if (num == 3)
            {
                lblResposta.Text = "Março";
            }
            else if (num == 4)
            {
                lblResposta.Text = "Abril";
            }
            else if (num == 5)
            {
                lblResposta.Text = "Maio";
            }
            else if (num == 6)
            {
                lblResposta.Text = "Junho";
            }
            else if (num == 7)
            {
                lblResposta.Text = "Julho";
            }
            else if (num == 8)
            {
                lblResposta.Text = "Agosto";
            }
            else if (num == 9)
            {
                lblResposta.Text = "Setembro";
            }
            else if (num == 10)
            {
                lblResposta.Text = "Outubro";
            }
            else if (num == 11)
            {
                lblResposta.Text = "Novembro";
            }
            else if(num == 12)
            {
                lblResposta.Text = "Dezembro";
            }
            else
            {
                lblResposta.Text = "Esse número ´não é válido";
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
           Environment.Exit(0);
        }
    }
}
