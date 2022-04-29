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
namespace WF_2
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtPrimeiro.Text);
            double y = double.Parse(txtSegundo.Text);
            txtPrimeiro.Clear();
            txtSegundo.Clear();
            txtResultado.Text = (x +y).ToString();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtPrimeiro.Text);
            double y = double.Parse(txtSegundo.Text);
            txtPrimeiro.Clear();
            txtSegundo.Clear();
            txtResultado.Text = (x - y).ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtPrimeiro.Text);
            double y = double.Parse(txtSegundo.Text);
            txtPrimeiro.Clear();
            txtSegundo.Clear();
            txtResultado.Text = (x / y).ToString();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtPrimeiro.Text);
            double y = double.Parse(txtSegundo.Text);
            txtPrimeiro.Clear();
            txtSegundo.Clear();
            txtResultado.Text = (x * y).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
