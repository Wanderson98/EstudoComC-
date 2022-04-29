using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
namespace Aula24Imagens
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string pathText = txtCaminhoPasta.Text;
                DirectoryInfo directory = new DirectoryInfo($@"{pathText}");
                FileInfo[] arquivos = directory.GetFiles("*");
                materialListBox1.Clear();
                foreach (FileInfo item in arquivos)
                {
                    materialListBox1.AddItem(item.ToString());
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message, false);
            }


        }


        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void materialListBox1_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            try
            {
                pictureBox.Image = Image.FromFile(txtCaminhoPasta.Text+ "\\" + materialListBox1.SelectedItem.Text);
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message, false);
            }
        }

        private void cbbDiretorios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string pathText = txtCaminhoPasta.Text;
                DirectoryInfo directory = new DirectoryInfo($@"{pathText}");
                FileInfo[] arquivos = directory.GetFiles("*");
                materialListBox1.Clear();
                foreach (FileInfo item in arquivos)
                {
                    materialListBox1.AddItem(item.ToString());
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message, false);
            }

        }

        private void btnProcurarPasta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.ShowNewFolderButton = true;

            DialogResult result = folderDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtCaminhoPasta.Text = folderDialog.SelectedPath;
                Environment.SpecialFolder root = folderDialog.RootFolder;
            }
        }
    }
}
