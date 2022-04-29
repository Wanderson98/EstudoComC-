namespace Aula40Material
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtValor = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cbbFormas = new MaterialSkin.Controls.MaterialComboBox();
            this.cbbParcelamento = new MaterialSkin.Controls.MaterialComboBox();
            this.lblEscolha = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblFinal = new MaterialSkin.Controls.MaterialLabel();
            this.lblChavePix = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(23, 85);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(38, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.AnimateReadOnly = false;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Depth = 0;
            this.txtValor.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtValor.LeadingIcon = null;
            this.txtValor.Location = new System.Drawing.Point(26, 107);
            this.txtValor.MaxLength = 50;
            this.txtValor.MouseState = MaterialSkin.MouseState.OUT;
            this.txtValor.Multiline = false;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(195, 50);
            this.txtValor.TabIndex = 1;
            this.txtValor.Text = "";
            this.txtValor.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(23, 174);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(162, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Formas de Pagamento";
            // 
            // cbbFormas
            // 
            this.cbbFormas.AutoResize = false;
            this.cbbFormas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbFormas.Depth = 0;
            this.cbbFormas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbFormas.DropDownHeight = 174;
            this.cbbFormas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFormas.DropDownWidth = 121;
            this.cbbFormas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbFormas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbFormas.FormattingEnabled = true;
            this.cbbFormas.IntegralHeight = false;
            this.cbbFormas.ItemHeight = 43;
            this.cbbFormas.Location = new System.Drawing.Point(26, 205);
            this.cbbFormas.MaxDropDownItems = 4;
            this.cbbFormas.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbFormas.Name = "cbbFormas";
            this.cbbFormas.Size = new System.Drawing.Size(195, 49);
            this.cbbFormas.StartIndex = 0;
            this.cbbFormas.TabIndex = 3;
            this.cbbFormas.SelectedIndexChanged += new System.EventHandler(this.cbbFormas_SelectedIndexChanged);
            // 
            // cbbParcelamento
            // 
            this.cbbParcelamento.AutoResize = false;
            this.cbbParcelamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbParcelamento.Depth = 0;
            this.cbbParcelamento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbParcelamento.DropDownHeight = 174;
            this.cbbParcelamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbParcelamento.DropDownWidth = 121;
            this.cbbParcelamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbParcelamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbParcelamento.FormattingEnabled = true;
            this.cbbParcelamento.IntegralHeight = false;
            this.cbbParcelamento.ItemHeight = 43;
            this.cbbParcelamento.Location = new System.Drawing.Point(239, 205);
            this.cbbParcelamento.MaxDropDownItems = 4;
            this.cbbParcelamento.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbParcelamento.Name = "cbbParcelamento";
            this.cbbParcelamento.Size = new System.Drawing.Size(81, 49);
            this.cbbParcelamento.StartIndex = 0;
            this.cbbParcelamento.TabIndex = 4;
            this.cbbParcelamento.SelectedIndexChanged += new System.EventHandler(this.cbbParcelamento_SelectedIndexChanged);
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Depth = 0;
            this.lblEscolha.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEscolha.Location = new System.Drawing.Point(23, 307);
            this.lblEscolha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(1, 0);
            this.lblEscolha.TabIndex = 5;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(23, 272);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(253, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Forma de Pagamento Selecionada: ";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Depth = 0;
            this.lblFinal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFinal.Location = new System.Drawing.Point(23, 353);
            this.lblFinal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(1, 0);
            this.lblFinal.TabIndex = 7;
            // 
            // lblChavePix
            // 
            this.lblChavePix.AutoSize = true;
            this.lblChavePix.Depth = 0;
            this.lblChavePix.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblChavePix.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lblChavePix.Location = new System.Drawing.Point(23, 388);
            this.lblChavePix.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblChavePix.Name = "lblChavePix";
            this.lblChavePix.Size = new System.Drawing.Size(1, 0);
            this.lblChavePix.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 462);
            this.Controls.Add(this.lblChavePix);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.cbbParcelamento);
            this.Controls.Add(this.cbbFormas);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtValor;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cbbFormas;
        private MaterialSkin.Controls.MaterialComboBox cbbParcelamento;
        private MaterialSkin.Controls.MaterialLabel lblEscolha;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblFinal;
        private MaterialSkin.Controls.MaterialLabel lblChavePix;
    }
}

