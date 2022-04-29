using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_1
{
    public partial class TelaCliente : Form
    {
        public TelaCliente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            lblRecebeNome.Text = txtCliente.Text;
            lblRecebeEndereco.Text = txtEndereco.Text;
            lblRecebeTelefone.Text = txtTelefone.Text;
            lblRecebeEmail.Text = txtEmail.Text;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
