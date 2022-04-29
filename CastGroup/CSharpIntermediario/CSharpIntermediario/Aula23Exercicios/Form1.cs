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

namespace Aula23Exercicios
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCarregarListBox_Click(object sender, EventArgs e)
        {
            string[] nomes = { "Antônio", "Neide ", "Silvestre", "Erica", "Pedro " };

            foreach (string item in nomes)
            {
                ListArray.AddItem(item);
            }

       
        }

        private void btnCheckar_Click(object sender, EventArgs e)
        {
            if (Checkbox.Checked)
            {
                MaterialMessageBox.Show("Check Box Está Marcada","Teste Check", false);
            }
            else
            {
                MaterialMessageBox.Show("Check Box Não Está Marcada", "Teste Check", false);
            }
        }

        private void btnDroDown_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in ListArray.Items)
                {
                    ComboBox1.Items.Add(item.Text);
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message, "Exceção", false);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime data = DateTime.Parse(txtData.Text);
                txtDia.Text = "Dia: " + data.Day.ToString();
                txtMes.Text = "Mês: " + data.Month.ToString();
                txtAno.Text = "Ano: " + data.Year.ToString();
                txtDiaDoAno.Text = "Dia do Ano: " + data.DayOfYear.ToString();
                txtDiaDaSemana.Text = "Dia da semana: " + data.DayOfWeek.ToString();

               
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message, "Exceção", false);
            }
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
