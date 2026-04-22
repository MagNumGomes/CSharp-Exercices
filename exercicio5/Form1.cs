using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_5___Aula_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void rdbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            double altura = Convert.ToDouble(txtAltura.Text);
            
            if (rdbMasculino.Checked)
            {
                double masculino = (72.7 * altura- 58);
                lblResposta.Text = $"{masculino}";
            }
            else
            {
                double feminino = (61.1 * altura - 44.7);
                lblResposta.Text = $"{feminino}";
            }

        }
    }
}
