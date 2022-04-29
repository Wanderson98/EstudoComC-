using System;
using System.Collections;
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
namespace Aula40Material
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList formaPGTO = new ArrayList();
            formaPGTO.Add(new FormaDePGTO(1, "Dinheiro"));
            formaPGTO.Add(new FormaDePGTO(2, "Cartão"));
            formaPGTO.Add(new FormaDePGTO(3, "Boleto"));
            formaPGTO.Add(new FormaDePGTO(4, "Pix"));

            cbbFormas.DataSource = formaPGTO;
            cbbFormas.DisplayMember = "Descrição ";
            cbbFormas.ValueMember = "Descricao";

            txtValor.Text = "0,00";
        }

        private void cbbFormas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int escolha = cbbFormas.SelectedIndex;
            switch (escolha)
            {
                case 0:
                    lblEscolha.Text = "Dinheiro";
                    break;
                case 1:
                    lblEscolha.Text = "Cartão";
                    break;
                case 2:
                    lblEscolha.Text = "Boleto";
                    break;
                case 3:
                    lblEscolha.Text = "Pix";
                    break;
                default:
                    MessageBox.Show("Escolha invalida!");
                    break;

            }
            cbbParcelamento.Items.Clear();
            if (escolha == 1)
            {
                for (int i = 1; i <= 10; i++)
                {
                    cbbParcelamento.Items.Add(i);
                }
            }
            else
            {
                cbbParcelamento.Items.Add(1);
            }

            if (escolha == 3)
            {
                int chavePix = new Random().Next(11900000, 99999999);
                lblChavePix.Text = $"Chave Pix para Pagamento: {chavePix}";
            }
            else
            {
                lblChavePix.Text = null;
            }
        }

        private void cbbParcelamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            double valor = double.Parse(txtValor.Text);
            int parcelas = int.Parse(cbbParcelamento.SelectedItem.ToString());

            double parcela = valor / parcelas;

            if (cbbParcelamento.SelectedIndex == 0)
            {
                lblFinal.Text = $"Pagamento à Vista no valor de: R$ {valor:F2}";
            }
            else
            {
                lblFinal.Text = $"Pagamento em {parcelas} vez(es) no valor de {parcela:F2} sem juros!";
            }

        }
    }
    public class FormaDePGTO
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public FormaDePGTO(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
    }
}
