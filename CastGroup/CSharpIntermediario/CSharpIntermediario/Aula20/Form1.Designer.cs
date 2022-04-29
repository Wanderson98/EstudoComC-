namespace Aula20
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
            this.lblPrimeiroNumero = new System.Windows.Forms.Label();
            this.txtPrimeiroNumero = new System.Windows.Forms.TextBox();
            this.lblSegundoNumero = new System.Windows.Forms.Label();
            this.txtSegundoNumero = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnDividir = new System.Windows.Forms.Button();
            this.xtResultadoDivisao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrimeiroNumero
            // 
            this.lblPrimeiroNumero.AutoSize = true;
            this.lblPrimeiroNumero.Location = new System.Drawing.Point(12, 9);
            this.lblPrimeiroNumero.Name = "lblPrimeiroNumero";
            this.lblPrimeiroNumero.Size = new System.Drawing.Size(84, 13);
            this.lblPrimeiroNumero.TabIndex = 0;
            this.lblPrimeiroNumero.Text = "Primeiro Número";
            // 
            // txtPrimeiroNumero
            // 
            this.txtPrimeiroNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimeiroNumero.Location = new System.Drawing.Point(15, 35);
            this.txtPrimeiroNumero.Name = "txtPrimeiroNumero";
            this.txtPrimeiroNumero.Size = new System.Drawing.Size(145, 26);
            this.txtPrimeiroNumero.TabIndex = 1;
            // 
            // lblSegundoNumero
            // 
            this.lblSegundoNumero.AutoSize = true;
            this.lblSegundoNumero.Location = new System.Drawing.Point(12, 77);
            this.lblSegundoNumero.Name = "lblSegundoNumero";
            this.lblSegundoNumero.Size = new System.Drawing.Size(90, 13);
            this.lblSegundoNumero.TabIndex = 0;
            this.lblSegundoNumero.Text = "Segundo Número";
            // 
            // txtSegundoNumero
            // 
            this.txtSegundoNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoNumero.Location = new System.Drawing.Point(15, 103);
            this.txtSegundoNumero.Name = "txtSegundoNumero";
            this.txtSegundoNumero.Size = new System.Drawing.Size(145, 26);
            this.txtSegundoNumero.TabIndex = 1;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(12, 218);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(93, 13);
            this.lblresultado.TabIndex = 0;
            this.lblresultado.Text = "Resultado Divisão";
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(15, 155);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 2;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // xtResultadoDivisao
            // 
            this.xtResultadoDivisao.AutoSize = true;
            this.xtResultadoDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtResultadoDivisao.Location = new System.Drawing.Point(15, 251);
            this.xtResultadoDivisao.Name = "xtResultadoDivisao";
            this.xtResultadoDivisao.Size = new System.Drawing.Size(0, 24);
            this.xtResultadoDivisao.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 324);
            this.Controls.Add(this.xtResultadoDivisao);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtSegundoNumero);
            this.Controls.Add(this.lblSegundoNumero);
            this.Controls.Add(this.txtPrimeiroNumero);
            this.Controls.Add(this.lblPrimeiroNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeiroNumero;
        private System.Windows.Forms.TextBox txtPrimeiroNumero;
        private System.Windows.Forms.Label lblSegundoNumero;
        private System.Windows.Forms.TextBox txtSegundoNumero;
        private System.Windows.Forms.TextBox txtResultadoDivisao;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Label xtResultadoDivisao;
        private System.Windows.Forms.Label lblresultado;
    }
}

