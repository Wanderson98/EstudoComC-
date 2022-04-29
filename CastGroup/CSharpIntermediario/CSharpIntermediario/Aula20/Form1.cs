using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                decimal x = decimal.Parse(txtPrimeiroNumero.Text);
                decimal y = decimal.Parse(txtSegundoNumero.Text);
                decimal resultado = x / y;
                xtResultadoDivisao.Text = $"{resultado}";
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Exception ",MessageBoxButtons.OK );
                txtPrimeiroNumero.Clear();
                txtSegundoNumero.Clear();
                xtResultadoDivisao.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK );
                txtPrimeiroNumero.Clear();
                txtSegundoNumero.Clear();
                xtResultadoDivisao.Text = null; ;
            }
        }
    }
}
