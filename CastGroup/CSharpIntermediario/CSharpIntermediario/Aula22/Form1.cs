using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula22.Telas;

namespace Aula22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnCadastroCliente_Click(object sender, EventArgs e)
        {
            Clientes tlClientes = new Clientes();
            tlClientes.MdiParent = this;
            tlClientes.Show();
        }

        private void mnCadastroContas_Click(object sender, EventArgs e)
        {
            Contas contas = new Contas();
            contas.MdiParent = this;
            contas.Show();
        }

        private void mnCadastroFornecedores_Click(object sender, EventArgs e)
        {
            Fornecedores forn = new Fornecedores();
            forn.MdiParent = this;
            forn.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja sair ?", "Sair Aplicação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
                       
        }
    }
}
