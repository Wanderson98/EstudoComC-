using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula22.Telas
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {


            foreach (object item in listBox1.Items)
            {

                listBox2.Items.Add(item.ToString());

            }


        }

        private void btnTrazerdeArray_Click(object sender, EventArgs e)
        {

            int[] list = { 90, 17, 83, 53, 93, 25, 1, 92, 59, 100 };
            foreach (int item in list)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
