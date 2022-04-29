namespace WF_1
{
    partial class TelaCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblRecebeNome = new System.Windows.Forms.Label();
            this.lblRecebeEndereco = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRecebeTelefone = new System.Windows.Forms.Label();
            this.lblRecebeEmail = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(68, 24);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(16, 36);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(222, 29);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(12, 89);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(94, 24);
            this.lblEndereco.TabIndex = 0;
            this.lblEndereco.Text = "Endereco";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(16, 116);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(222, 29);
            this.txtEndereco.TabIndex = 1;
            this.txtEndereco.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(12, 166);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(85, 24);
            this.lblTelefone.TabIndex = 0;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(16, 193);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(222, 29);
            this.txtTelefone.TabIndex = 1;
            this.txtTelefone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 244);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 24);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(16, 271);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(222, 29);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(16, 337);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(108, 41);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblRecebeNome
            // 
            this.lblRecebeNome.AutoSize = true;
            this.lblRecebeNome.Location = new System.Drawing.Point(27, 49);
            this.lblRecebeNome.Name = "lblRecebeNome";
            this.lblRecebeNome.Size = new System.Drawing.Size(0, 24);
            this.lblRecebeNome.TabIndex = 3;
            this.lblRecebeNome.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblRecebeEndereco
            // 
            this.lblRecebeEndereco.AutoSize = true;
            this.lblRecebeEndereco.Location = new System.Drawing.Point(27, 97);
            this.lblRecebeEndereco.Name = "lblRecebeEndereco";
            this.lblRecebeEndereco.Size = new System.Drawing.Size(0, 24);
            this.lblRecebeEndereco.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRecebeEmail);
            this.groupBox1.Controls.Add(this.lblRecebeEndereco);
            this.groupBox1.Controls.Add(this.lblRecebeTelefone);
            this.groupBox1.Controls.Add(this.lblRecebeNome);
            this.groupBox1.Location = new System.Drawing.Point(442, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 245);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Cadastrados";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblRecebeTelefone
            // 
            this.lblRecebeTelefone.AutoSize = true;
            this.lblRecebeTelefone.Location = new System.Drawing.Point(27, 142);
            this.lblRecebeTelefone.Name = "lblRecebeTelefone";
            this.lblRecebeTelefone.Size = new System.Drawing.Size(0, 24);
            this.lblRecebeTelefone.TabIndex = 3;
            this.lblRecebeTelefone.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblRecebeEmail
            // 
            this.lblRecebeEmail.AutoSize = true;
            this.lblRecebeEmail.Location = new System.Drawing.Point(27, 190);
            this.lblRecebeEmail.Name = "lblRecebeEmail";
            this.lblRecebeEmail.Size = new System.Drawing.Size(0, 24);
            this.lblRecebeEmail.TabIndex = 3;
            // 
            // TelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 626);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "TelaCliente";
            this.Text = "TelaCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblRecebeNome;
        private System.Windows.Forms.Label lblRecebeEndereco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRecebeEmail;
        private System.Windows.Forms.Label lblRecebeTelefone;
    }
}