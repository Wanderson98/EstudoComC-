namespace WF_2
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
            this.lblPrimeiroNumero = new MaterialSkin.Controls.MaterialLabel();
            this.txtPrimeiro = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSegundo = new MaterialSkin.Controls.MaterialTextBox();
            this.lblResultado = new MaterialSkin.Controls.MaterialLabel();
            this.txtResultado = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAdicao = new MaterialSkin.Controls.MaterialButton();
            this.btnSubtracao = new MaterialSkin.Controls.MaterialButton();
            this.btnDivisao = new MaterialSkin.Controls.MaterialButton();
            this.btnMultiplicacao = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblPrimeiroNumero
            // 
            this.lblPrimeiroNumero.AutoSize = true;
            this.lblPrimeiroNumero.Depth = 0;
            this.lblPrimeiroNumero.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrimeiroNumero.Location = new System.Drawing.Point(12, 74);
            this.lblPrimeiroNumero.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrimeiroNumero.Name = "lblPrimeiroNumero";
            this.lblPrimeiroNumero.Size = new System.Drawing.Size(178, 19);
            this.lblPrimeiroNumero.TabIndex = 0;
            this.lblPrimeiroNumero.Text = "Digite o Primeiro Número";
            this.lblPrimeiroNumero.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // txtPrimeiro
            // 
            this.txtPrimeiro.AnimateReadOnly = false;
            this.txtPrimeiro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrimeiro.Depth = 0;
            this.txtPrimeiro.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrimeiro.LeadingIcon = null;
            this.txtPrimeiro.Location = new System.Drawing.Point(15, 96);
            this.txtPrimeiro.MaxLength = 50;
            this.txtPrimeiro.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrimeiro.Multiline = false;
            this.txtPrimeiro.Name = "txtPrimeiro";
            this.txtPrimeiro.Size = new System.Drawing.Size(88, 50);
            this.txtPrimeiro.TabIndex = 1;
            this.txtPrimeiro.Text = "";
            this.txtPrimeiro.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(12, 159);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(182, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Digite o Segundo Número";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // txtSegundo
            // 
            this.txtSegundo.AnimateReadOnly = false;
            this.txtSegundo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSegundo.Depth = 0;
            this.txtSegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSegundo.LeadingIcon = null;
            this.txtSegundo.Location = new System.Drawing.Point(15, 181);
            this.txtSegundo.MaxLength = 50;
            this.txtSegundo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSegundo.Multiline = false;
            this.txtSegundo.Name = "txtSegundo";
            this.txtSegundo.Size = new System.Drawing.Size(88, 50);
            this.txtSegundo.TabIndex = 1;
            this.txtSegundo.Text = "";
            this.txtSegundo.TrailingIcon = null;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Depth = 0;
            this.lblResultado.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblResultado.Location = new System.Drawing.Point(15, 266);
            this.lblResultado.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 19);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.AnimateReadOnly = false;
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultado.Depth = 0;
            this.txtResultado.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtResultado.LeadingIcon = null;
            this.txtResultado.Location = new System.Drawing.Point(15, 288);
            this.txtResultado.MaxLength = 50;
            this.txtResultado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtResultado.Multiline = false;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(116, 50);
            this.txtResultado.TabIndex = 3;
            this.txtResultado.Text = "";
            this.txtResultado.TrailingIcon = null;
            // 
            // btnAdicao
            // 
            this.btnAdicao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdicao.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdicao.Depth = 0;
            this.btnAdicao.HighEmphasis = true;
            this.btnAdicao.Icon = null;
            this.btnAdicao.Location = new System.Drawing.Point(223, 96);
            this.btnAdicao.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdicao.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdicao.Size = new System.Drawing.Size(64, 36);
            this.btnAdicao.TabIndex = 4;
            this.btnAdicao.Text = "+";
            this.btnAdicao.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdicao.UseAccentColor = false;
            this.btnAdicao.UseVisualStyleBackColor = true;
            this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubtracao.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSubtracao.Depth = 0;
            this.btnSubtracao.HighEmphasis = true;
            this.btnSubtracao.Icon = null;
            this.btnSubtracao.Location = new System.Drawing.Point(223, 142);
            this.btnSubtracao.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSubtracao.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSubtracao.Size = new System.Drawing.Size(64, 36);
            this.btnSubtracao.TabIndex = 4;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSubtracao.UseAccentColor = false;
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDivisao.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDivisao.Depth = 0;
            this.btnDivisao.HighEmphasis = true;
            this.btnDivisao.Icon = null;
            this.btnDivisao.Location = new System.Drawing.Point(223, 190);
            this.btnDivisao.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDivisao.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDivisao.Size = new System.Drawing.Size(64, 36);
            this.btnDivisao.TabIndex = 4;
            this.btnDivisao.Text = "/";
            this.btnDivisao.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDivisao.UseAccentColor = false;
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMultiplicacao.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMultiplicacao.Depth = 0;
            this.btnMultiplicacao.HighEmphasis = true;
            this.btnMultiplicacao.Icon = null;
            this.btnMultiplicacao.Location = new System.Drawing.Point(223, 238);
            this.btnMultiplicacao.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMultiplicacao.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMultiplicacao.Size = new System.Drawing.Size(64, 36);
            this.btnMultiplicacao.TabIndex = 4;
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMultiplicacao.UseAccentColor = false;
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 368);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtSegundo);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtPrimeiro);
            this.Controls.Add(this.lblPrimeiroNumero);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblPrimeiroNumero;
        private MaterialSkin.Controls.MaterialTextBox txtPrimeiro;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtSegundo;
        private MaterialSkin.Controls.MaterialLabel lblResultado;
        private MaterialSkin.Controls.MaterialTextBox txtResultado;
        private MaterialSkin.Controls.MaterialButton btnAdicao;
        private MaterialSkin.Controls.MaterialButton btnSubtracao;
        private MaterialSkin.Controls.MaterialButton btnDivisao;
        private MaterialSkin.Controls.MaterialButton btnMultiplicacao;
    }
}

