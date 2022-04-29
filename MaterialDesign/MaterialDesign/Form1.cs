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
using MaterialSkin.Animations;
namespace MaterialDesign
{
    public partial class FrmTelaLogin : MaterialForm
    {
        public FrmTelaLogin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = "pedro";
            string senha = "1234";

            

            if(txtLogin.Text == login && txtSenha.Text == senha)
            {
                TelaPrincipal tela = new TelaPrincipal();
                tela.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Senha Errada", "Erro no Acesso", MessageBoxButtons.OK);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLogin.Clear();
            txtSenha.Clear();
        }
    }
}
