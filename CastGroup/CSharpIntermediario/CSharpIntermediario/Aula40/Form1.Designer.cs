namespace Aula40
{
    partial class Form1
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
            this.cbbFormas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dfsfsdf = new System.Windows.Forms.Label();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbParcelamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblChavePix = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbFormas
            // 
            this.cbbFormas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFormas.FormattingEnabled = true;
            this.cbbFormas.Location = new System.Drawing.Point(20, 102);
            this.cbbFormas.Name = "cbbFormas";
            this.cbbFormas.Size = new System.Drawing.Size(164, 33);
            this.cbbFormas.TabIndex = 0;
            this.cbbFormas.SelectedIndexChanged += new System.EventHandler(this.cbbFormas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formas de Pagamento";
            // 
            // dfsfsdf
            // 
            this.dfsfsdf.AutoSize = true;
            this.dfsfsdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dfsfsdf.Location = new System.Drawing.Point(16, 151);
            this.dfsfsdf.Name = "dfsfsdf";
            this.dfsfsdf.Size = new System.Drawing.Size(313, 24);
            this.dfsfsdf.TabIndex = 2;
            this.dfsfsdf.Text = "Forma de Pagamento Selecionada: ";
            this.dfsfsdf.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolha.Location = new System.Drawing.Point(15, 191);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(0, 25);
            this.lblEscolha.TabIndex = 3;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(83, 18);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(161, 31);
            this.txtValor.TabIndex = 4;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor";
            // 
            // cbbParcelamento
            // 
            this.cbbParcelamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbParcelamento.FormattingEnabled = true;
            this.cbbParcelamento.Location = new System.Drawing.Point(190, 102);
            this.cbbParcelamento.Name = "cbbParcelamento";
            this.cbbParcelamento.Size = new System.Drawing.Size(54, 33);
            this.cbbParcelamento.TabIndex = 6;
            this.cbbParcelamento.SelectedIndexChanged += new System.EventHandler(this.cbbParcelamento_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor Final:";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.Location = new System.Drawing.Point(15, 312);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(0, 25);
            this.lblFinal.TabIndex = 8;
            // 
            // lblChavePix
            // 
            this.lblChavePix.AutoSize = true;
            this.lblChavePix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChavePix.Location = new System.Drawing.Point(17, 344);
            this.lblChavePix.Name = "lblChavePix";
            this.lblChavePix.Size = new System.Drawing.Size(0, 20);
            this.lblChavePix.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 425);
            this.Controls.Add(this.lblChavePix);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbParcelamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.dfsfsdf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbFormas);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbFormas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dfsfsdf;
        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbParcelamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblChavePix;
    }
}

