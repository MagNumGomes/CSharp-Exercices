using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//atenção vc foi hackeado todos os seus dados estão na derpweb neste exato momento
namespace Exercicio_3___Aula_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblMensagem2_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            int num1;
            num1 = Convert.ToInt32(txtNum1.Text);

            int num2;
            num2 = Convert.ToInt32(txtNum2.Text);

            if (num1 < num2)
            {
                lblResposta1.Text = $"{num1}";
                lblResposta2.Text = $"{num2}";
            }
            else
            {
                lblResposta1.Text = $"{num2}";
                lblResposta2.Text = $"{num1}";
            }
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
