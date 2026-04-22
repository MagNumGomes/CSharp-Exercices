namespace Exercicio_7___Aula_2
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblResposta1 = new System.Windows.Forms.Label();
            this.lblResposta2 = new System.Windows.Forms.Label();
            this.txtNomeBox = new System.Windows.Forms.TextBox();
            this.txtHorasBox = new System.Windows.Forms.TextBox();
            this.txtValorBox = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(25, 41);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(25, 75);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(123, 20);
            this.lblHoras.TabIndex = 1;
            this.lblHoras.Text = "Horas Usadas:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(25, 108);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(70, 16);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor (R$):";
            // 
            // lblResposta1
            // 
            this.lblResposta1.AutoSize = true;
            this.lblResposta1.Location = new System.Drawing.Point(88, 155);
            this.lblResposta1.Name = "lblResposta1";
            this.lblResposta1.Size = new System.Drawing.Size(0, 20);
            this.lblResposta1.TabIndex = 3;
            // 
            // lblResposta2
            // 
            this.lblResposta2.AutoSize = true;
            this.lblResposta2.Location = new System.Drawing.Point(88, 184);
            this.lblResposta2.Name = "lblResposta2";
            this.lblResposta2.Size = new System.Drawing.Size(0, 20);
            this.lblResposta2.TabIndex = 4;
            // 
            // txtNomeBox
            // 
            this.txtNomeBox.Location = new System.Drawing.Point(129, 41);
            this.txtNomeBox.Name = "txtNomeBox";
            this.txtNomeBox.Size = new System.Drawing.Size(148, 22);
            this.txtNomeBox.TabIndex = 5;
            // 
            // txtHorasBox
            // 
            this.txtHorasBox.Location = new System.Drawing.Point(129, 72);
            this.txtHorasBox.Name = "txtHorasBox";
            this.txtHorasBox.Size = new System.Drawing.Size(148, 22);
            this.txtHorasBox.TabIndex = 6;
            // 
            // txtValorBox
            // 
            this.txtValorBox.Location = new System.Drawing.Point(129, 108);
            this.txtValorBox.Name = "txtValorBox";
            this.txtValorBox.Size = new System.Drawing.Size(148, 22);
            this.txtValorBox.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(316, 49);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(164, 80);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 293);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorBox);
            this.Controls.Add(this.txtHorasBox);
            this.Controls.Add(this.txtNomeBox);
            this.Controls.Add(this.lblResposta2);
            this.Controls.Add(this.lblResposta1);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblNome);
            this.Name = "frmTelaPrincipal";
            this.Text = "Lan House";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblResposta1;
        private System.Windows.Forms.Label lblResposta2;
        private System.Windows.Forms.TextBox txtNomeBox;
        private System.Windows.Forms.TextBox txtHorasBox;
        private System.Windows.Forms.TextBox txtValorBox;
        private System.Windows.Forms.Button btnCalcular;
    }
}

