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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblCliente.Text = "Wanderson Andrade";
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
           TelaCliente tela = new TelaCliente();
           Form1 form = new Form1();
            
            tela.ShowDialog();
            form.Dispose();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
