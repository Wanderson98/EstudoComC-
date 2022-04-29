namespace Aula22
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCadastroCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCadastroContas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCadastroFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnCadastroProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCadastros,
            this.relatóriosToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnCadastros
            // 
            this.mnCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCadastroCliente,
            this.mnCadastroContas,
            this.mnCadastroFornecedores,
            this.toolStripSeparator1,
            this.mnCadastroProdutos});
            this.mnCadastros.Name = "mnCadastros";
            this.mnCadastros.Size = new System.Drawing.Size(71, 20);
            this.mnCadastros.Text = "&Cadastros";
            // 
            // mnCadastroCliente
            // 
            this.mnCadastroCliente.Name = "mnCadastroCliente";
            this.mnCadastroCliente.Size = new System.Drawing.Size(145, 22);
            this.mnCadastroCliente.Text = "C&lientes";
            this.mnCadastroCliente.Click += new System.EventHandler(this.mnCadastroCliente_Click);
            // 
            // mnCadastroContas
            // 
            this.mnCadastroContas.Name = "mnCadastroContas";
            this.mnCadastroContas.Size = new System.Drawing.Size(145, 22);
            this.mnCadastroContas.Text = "C&ontas";
            this.mnCadastroContas.Click += new System.EventHandler(this.mnCadastroContas_Click);
            // 
            // mnCadastroFornecedores
            // 
            this.mnCadastroFornecedores.Name = "mnCadastroFornecedores";
            this.mnCadastroFornecedores.Size = new System.Drawing.Size(145, 22);
            this.mnCadastroFornecedores.Text = "&Fornecedores";
            this.mnCadastroFornecedores.Click += new System.EventHandler(this.mnCadastroFornecedores_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // mnCadastroProdutos
            // 
            this.mnCadastroProdutos.Name = "mnCadastroProdutos";
            this.mnCadastroProdutos.Size = new System.Drawing.Size(145, 22);
            this.mnCadastroProdutos.Text = "&Produtos";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnCadastros;
        private System.Windows.Forms.ToolStripMenuItem mnCadastroCliente;
        private System.Windows.Forms.ToolStripMenuItem mnCadastroContas;
        private System.Windows.Forms.ToolStripMenuItem mnCadastroFornecedores;
        private System.Windows.Forms.ToolStripMenuItem mnCadastroProdutos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

