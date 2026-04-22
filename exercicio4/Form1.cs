namespace Exercicio_4___Aula_2
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string nome = txtNome.Text;


            if (radioButton1.Checked)
            {
                lblResposta.Text = $"{txtNome.Text} você gosta da cor Azul";
            }
            else if (radioButton2.Checked)
            {

                lblResposta.Text = $"{txtNome.Text} você gosta da cor Rosa";
            }
            else
            {
                lblResposta.Text = "Por favor, selecione uma cor";
            }

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblResposta_Click(object sender, EventArgs e)
        {

        }
    }
}
