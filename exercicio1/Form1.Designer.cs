namespace Exercicio_1
{
    partial class frmMes
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.bntConversor = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(157, 30);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(151, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Informe um número de 10 a 20";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(117, 49);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(219, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // bntConversor
            // 
            this.bntConversor.Location = new System.Drawing.Point(117, 87);
            this.bntConversor.Name = "bntConversor";
            this.bntConversor.Size = new System.Drawing.Size(107, 30);
            this.bntConversor.TabIndex = 2;
            this.bntConversor.Text = "Conversor";
            this.bntConversor.UseVisualStyleBackColor = true;
            this.bntConversor.Click += new System.EventHandler(this.bntConversor_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(230, 87);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(107, 30);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(189, 136);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(0, 13);
            this.lblResposta.TabIndex = 4;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(114, 136);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(60, 13);
            this.lblMensagem.TabIndex = 5;
            this.lblMensagem.Text = "Seu mês é:";
            // 
            // frmMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 244);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.bntConversor);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Name = "frmMes";
            this.Text = "Conversão de mês";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button bntConversor;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label lblMensagem;
    }
}

