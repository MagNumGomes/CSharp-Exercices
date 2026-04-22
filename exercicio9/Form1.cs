using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_9___Aula_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nome = Convert.ToString(txtNomeBox.Text);
            double saldo = Convert.ToDouble(txtSaldoBox.Text);

            if ( saldo <= 200)
            {
                lblResposta.Text = $"{nome} receberá R$ {saldo}";
            }
            else if ( saldo >= 201 && saldo <= 400)
            {
                double credito = saldo / 0.2 ;
                lblResposta.Text = $"{nome} tem 20% de crédito receberá R$ {credito}";
            }
            else if ( saldo >= 401 && saldo <= 600)
            {
                double credito = saldo / 0.3;
                lblResposta.Text = $"{nome} tem 20% de crédito receberá R$ {credito}";
            }
            else if ( saldo >= 601 )
            {
                double credito = saldo / 0.4;
                lblResposta.Text = $"{nome} tem 20% de crédito receberá R$ {credito}";
            }
            else
            {
                lblResposta.Text = "Preencha os espaços a cima!";
            }
        }
    }
}
