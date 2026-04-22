using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_6___Aula_6
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void lblConsumo_Click(object sender, EventArgs e)
        {

        }

        private void lblvalor_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = Convert.ToString(txtConsumoBox.Text);
            int consumo = Convert.ToInt32(txtConsumoBox.Text);
            double valor = Convert.ToDouble(txtValorBox.Text);
            if (consumo <= 150)
            {
                lblResposta1.Text = $"{nome} gastou R${valor}";
                lblResposta2.Text = "Consumidor Normal";
            }
            else if (consumo >= 151 && consumo <= 250)
            {
                valor = valor / 0.03;
                lblResposta1.Text = $"{nome} gastou R${valor}";
                lblResposta2.Text = "Consumidor Extra - Faixa 1";
            }
            else if (consumo > 250)
            {
                valor = valor / 0.05;
                lblResposta1.Text = $"{nome} gastou R${valor}";
                lblResposta2.Text = "Consumidor Extra - Faixa 2";
            }
            else
            {
                lblResposta1.Text = "Preencha as caixar de texto!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}