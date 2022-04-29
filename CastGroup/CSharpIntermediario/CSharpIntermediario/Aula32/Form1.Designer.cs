namespace Aula32
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
            this.lblTexto = new MaterialSkin.Controls.MaterialLabel();
            this.btnAdicionar = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
            this.txtTextoResposta = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Depth = 0;
            this.lblTexto.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTexto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTexto.Location = new System.Drawing.Point(75, 89);
            this.lblTexto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(203, 19);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "O que você deseja aprender?";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.AutoSize = false;
            this.btnAdicionar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdicionar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdicionar.Depth = 0;
            this.btnAdicionar.HighEmphasis = true;
            this.btnAdicionar.Icon = null;
            this.btnAdicionar.Location = new System.Drawing.Point(87, 128);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdicionar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdicionar.Size = new System.Drawing.Size(154, 38);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdicionar.UseAccentColor = false;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(87, 191);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(154, 38);
            this.materialButton2.TabIndex = 1;
            this.materialButton2.Text = "Adicionar Lista";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(87, 259);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(154, 38);
            this.materialButton3.TabIndex = 1;
            this.materialButton3.Text = "Remover";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSize = false;
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(87, 329);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(154, 38);
            this.materialButton4.TabIndex = 1;
            this.materialButton4.Text = "RemoverAt";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // materialButton5
            // 
            this.materialButton5.AutoSize = false;
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton5.Depth = 0;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = null;
            this.materialButton5.Location = new System.Drawing.Point(87, 405);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton5.Size = new System.Drawing.Size(154, 38);
            this.materialButton5.TabIndex = 1;
            this.materialButton5.Text = "Remover Range";
            this.materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton5.UseAccentColor = false;
            this.materialButton5.UseVisualStyleBackColor = true;
            // 
            // txtTextoResposta
            // 
            this.txtTextoResposta.AutoSize = true;
            this.txtTextoResposta.Depth = 0;
            this.txtTextoResposta.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTextoResposta.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.txtTextoResposta.Location = new System.Drawing.Point(6, 191);
            this.txtTextoResposta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTextoResposta.Name = "txtTextoResposta";
            this.txtTextoResposta.Size = new System.Drawing.Size(1, 0);
            this.txtTextoResposta.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 493);
            this.Controls.Add(this.txtTextoResposta);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton5);
            this.Controls.Add(this.materialButton4);
            this.Controls.Add(this.materialButton3);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblTexto);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Aula List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTexto;
        private MaterialSkin.Controls.MaterialButton btnAdicionar;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialLabel txtTextoResposta;
    }
}

