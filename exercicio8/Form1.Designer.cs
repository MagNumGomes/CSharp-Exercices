namespace Exercicio_8___Aula_2
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
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtNomeBox = new System.Windows.Forms.TextBox();
            this.txtSalarioBox = new System.Windows.Forms.TextBox();
            this.txtTotalBox = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResposta1 = new System.Windows.Forms.Label();
            this.lblResposta2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(34, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(59, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(34, 67);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(105, 20);
            this.lblSalario.TabIndex = 1;
            this.lblSalario.Text = "Salário Fixo: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(34, 99);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(139, 20);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total de vendas: ";
            // 
            // txtNomeBox
            // 
            this.txtNomeBox.Location = new System.Drawing.Point(143, 30);
            this.txtNomeBox.Name = "txtNomeBox";
            this.txtNomeBox.Size = new System.Drawing.Size(129, 22);
            this.txtNomeBox.TabIndex = 3;
            // 
            // txtSalarioBox
            // 
            this.txtSalarioBox.Location = new System.Drawing.Point(143, 64);
            this.txtSalarioBox.Name = "txtSalarioBox";
            this.txtSalarioBox.Size = new System.Drawing.Size(129, 22);
            this.txtSalarioBox.TabIndex = 4;
            // 
            // txtTotalBox
            // 
            this.txtTotalBox.Location = new System.Drawing.Point(143, 97);
            this.txtTotalBox.Name = "txtTotalBox";
            this.txtTotalBox.Size = new System.Drawing.Size(129, 22);
            this.txtTotalBox.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(312, 29);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(173, 89);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResposta1
            // 
            this.lblResposta1.AutoSize = true;
            this.lblResposta1.Location = new System.Drawing.Point(81, 145);
            this.lblResposta1.Name = "lblResposta1";
            this.lblResposta1.Size = new System.Drawing.Size(0, 20);
            this.lblResposta1.TabIndex = 7;
            // 
            // lblResposta2
            // 
            this.lblResposta2.AutoSize = true;
            this.lblResposta2.Location = new System.Drawing.Point(81, 175);
            this.lblResposta2.Name = "lblResposta2";
            this.lblResposta2.Size = new System.Drawing.Size(0, 20);
            this.lblResposta2.TabIndex = 8;
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 253);
            this.Controls.Add(this.lblResposta2);
            this.Controls.Add(this.lblResposta1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotalBox);
            this.Controls.Add(this.txtSalarioBox);
            this.Controls.Add(this.txtNomeBox);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNome);
            this.Name = "frmTelaPrincipal";
            this.Text = "Sálarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtNomeBox;
        private System.Windows.Forms.TextBox txtSalarioBox;
        private System.Windows.Forms.TextBox txtTotalBox;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResposta1;
        private System.Windows.Forms.Label lblResposta2;
    }
}

