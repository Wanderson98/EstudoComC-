using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Aula32
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
           Telas.Adicionar adicionar = new Telas.Adicionar();
            adicionar.ShowDialog();
        }

        private void materialListBox1_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            Telas.AdicionarLista adicionarlista = new Telas.AdicionarLista();
            adicionarlista.ShowDialog();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            Telas.Remover remover = new Telas.Remover();
            remover.ShowDialog();
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            Telas.RemoverAt removerAt = new Telas.RemoverAt();
            removerAt.ShowDialog();

        }
    }
}
