using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_8___Aula_2
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nome = Convert.ToString(txtNomeBox.Text);
            double salario = Convert.ToDouble(txtSalarioBox.Text);
            double vendas = Convert.ToDouble(txtTotalBox.Text);

            if (salario <= 5000)
            {
                double salarioFinal = salario + 0.02 + 100;
                lblResposta1.Text = $"{nome} vendeu R$ {vendas}";
                lblResposta2.Text = $"Salário final: R$ {salarioFinal}";
            }
            else if (salario >= 5001 &&  salario <= 7500)
            {
                double salarioFinal = salario + 0.03 + 200;
                lblResposta1.Text = $"{nome} vendeu R$ {vendas}";
                lblResposta2.Text = $"Salário final: R$ {salarioFinal}";
            }
            else if (salario > 7500)
            {
                double salarioFinal = salario + 0.04 + 300;
                lblResposta1.Text = $"{nome} vendeu R$ {vendas}";
                lblResposta2.Text = $"Salário final: R$ {salarioFinal}";
            }
            else 
            {
                lblResposta1.Text = "Preencha os espaços a cima!";
            }
        }
    }
}
