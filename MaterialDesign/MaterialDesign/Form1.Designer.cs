namespace MaterialDesign
{
    partial class FrmTelaLogin
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
            this.lblLogin = new MaterialSkin.Controls.MaterialLabel();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new MaterialSkin.Controls.MaterialLabel();
            this.btnEntrar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnLimpar = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Depth = 0;
            this.lblLogin.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLogin.Location = new System.Drawing.Point(37, 107);
            this.lblLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 16);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(40, 126);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(206, 26);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(40, 187);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(206, 26);
            this.txtSenha.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Depth = 0;
            this.lblSenha.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSenha.Location = new System.Drawing.Point(37, 168);
            this.lblSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 16);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha";
            // 
            // btnEntrar
            // 
            this.btnEntrar.AutoSize = true;
            this.btnEntrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEntrar.Depth = 0;
            this.btnEntrar.Icon = null;
            this.btnEntrar.Location = new System.Drawing.Point(40, 235);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEntrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Primary = false;
            this.btnEntrar.Size = new System.Drawing.Size(73, 36);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpar.Depth = 0;
            this.btnLimpar.Icon = null;
            this.btnLimpar.Location = new System.Drawing.Point(175, 235);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Primary = false;
            this.btnLimpar.Size = new System.Drawing.Size(71, 36);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmTelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 340);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private MaterialSkin.Controls.MaterialLabel lblSenha;
        private MaterialSkin.Controls.MaterialFlatButton btnEntrar;
        private MaterialSkin.Controls.MaterialFlatButton btnLimpar;
    }
}

