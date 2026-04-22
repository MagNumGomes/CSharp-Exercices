using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_4___Aula_2
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt32(txtBox.Text);

            

            if ((num % 2) == 0)
            {
                MessageBox.Show("O número é Par");
            }
            else
            {
                MessageBox.Show("O número é Impar");
            }
        }
    }
}
