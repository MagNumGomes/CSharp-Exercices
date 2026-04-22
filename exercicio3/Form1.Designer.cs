namespace Exercicio_4___Aula_2
{
    partial class frmTelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMensagem = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnProcessar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(165, 33);
            this.lblMensagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(305, 16);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Digite um número pare verificar se é par ou impar: ";
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(169, 65);
            this.txtBox.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(319, 22);
            this.txtBox.TabIndex = 1;
            this.txtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(221, 110);
            this.btnProcessar.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(212, 30);
            this.btnProcessar.TabIndex = 2;
            this.btnProcessar.Text = "Par ou Impar";
            this.btnProcessar.UseVisualStyleBackColor = true;
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 192);
            this.Controls.Add(this.btnProcessar);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lblMensagem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTelaPrincipal";
            this.Text = "Par ou Impar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnProcessar;
    }
}

