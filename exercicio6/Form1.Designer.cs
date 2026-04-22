namespace Exercicio_6___Aula_6
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
            this.lblConsumo = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.txtNomeBox = new System.Windows.Forms.TextBox();
            this.txtConsumoBox = new System.Windows.Forms.TextBox();
            this.txtValorBox = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResposta1 = new System.Windows.Forms.Label();
            this.lblResposta2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(35, 37);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(59, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(35, 72);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(84, 20);
            this.lblConsumo.TabIndex = 1;
            this.lblConsumo.Text = "Consumo:";
            this.lblConsumo.Click += new System.EventHandler(this.lblConsumo_Click);
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(35, 106);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(90, 16);
            this.lblvalor.TabIndex = 2;
            this.lblvalor.Text = "Valor Unit(R$)";
            this.lblvalor.Click += new System.EventHandler(this.lblvalor_Click);
            // 
            // txtNomeBox
            // 
            this.txtNomeBox.Location = new System.Drawing.Point(131, 34);
            this.txtNomeBox.Name = "txtNomeBox";
            this.txtNomeBox.Size = new System.Drawing.Size(190, 22);
            this.txtNomeBox.TabIndex = 3;
            // 
            // txtConsumoBox
            // 
            this.txtConsumoBox.Location = new System.Drawing.Point(131, 72);
            this.txtConsumoBox.Name = "txtConsumoBox";
            this.txtConsumoBox.Size = new System.Drawing.Size(190, 22);
            this.txtConsumoBox.TabIndex = 4;
            // 
            // txtValorBox
            // 
            this.txtValorBox.Location = new System.Drawing.Point(131, 106);
            this.txtValorBox.Name = "txtValorBox";
            this.txtValorBox.Size = new System.Drawing.Size(190, 22);
            this.txtValorBox.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(345, 34);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(195, 94);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResposta1
            // 
            this.lblResposta1.AutoSize = true;
            this.lblResposta1.Location = new System.Drawing.Point(247, 151);
            this.lblResposta1.Name = "lblResposta1";
            this.lblResposta1.Size = new System.Drawing.Size(0, 20);
            this.lblResposta1.TabIndex = 7;
            // 
            // lblResposta2
            // 
            this.lblResposta2.AutoSize = true;
            this.lblResposta2.Location = new System.Drawing.Point(247, 184);
            this.lblResposta2.Name = "lblResposta2";
            this.lblResposta2.Size = new System.Drawing.Size(0, 20);
            this.lblResposta2.TabIndex = 8;
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 273);
            this.Controls.Add(this.lblResposta2);
            this.Controls.Add(this.lblResposta1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorBox);
            this.Controls.Add(this.txtConsumoBox);
            this.Controls.Add(this.txtNomeBox);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.lblNome);
            this.Name = "frmTelaPrincipal";
            this.Text = "Gasto de consumo mensal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.TextBox txtNomeBox;
        private System.Windows.Forms.TextBox txtConsumoBox;
        private System.Windows.Forms.TextBox txtValorBox;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResposta1;
        private System.Windows.Forms.Label lblResposta2;
    }
}

