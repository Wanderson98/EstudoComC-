namespace Aula24Imagens
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.materialListBox1 = new MaterialSkin.Controls.MaterialListBox();
            this.cbbDiretorios = new MaterialSkin.Controls.MaterialComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtCaminhoPasta = new MaterialSkin.Controls.MaterialTextBox();
            this.btnProcurarPasta = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(466, 178);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(286, 285);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(37, 472);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscar.Size = new System.Drawing.Size(77, 36);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar.UseAccentColor = false;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // materialListBox1
            // 
            this.materialListBox1.BackColor = System.Drawing.Color.White;
            this.materialListBox1.BorderColor = System.Drawing.Color.LightGray;
            this.materialListBox1.Depth = 0;
            this.materialListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialListBox1.Location = new System.Drawing.Point(37, 178);
            this.materialListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialListBox1.Name = "materialListBox1";
            this.materialListBox1.SelectedIndex = -1;
            this.materialListBox1.SelectedItem = null;
            this.materialListBox1.Size = new System.Drawing.Size(366, 285);
            this.materialListBox1.TabIndex = 3;
            this.materialListBox1.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.materialListBox1_SelectedIndexChanged);
            // 
            // cbbDiretorios
            // 
            this.cbbDiretorios.AutoResize = false;
            this.cbbDiretorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbDiretorios.Depth = 0;
            this.cbbDiretorios.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbDiretorios.DropDownHeight = 174;
            this.cbbDiretorios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDiretorios.DropDownWidth = 121;
            this.cbbDiretorios.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbDiretorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbDiretorios.FormattingEnabled = true;
            this.cbbDiretorios.IntegralHeight = false;
            this.cbbDiretorios.ItemHeight = 43;
            this.cbbDiretorios.Location = new System.Drawing.Point(37, 95);
            this.cbbDiretorios.MaxDropDownItems = 4;
            this.cbbDiretorios.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbDiretorios.Name = "cbbDiretorios";
            this.cbbDiretorios.Size = new System.Drawing.Size(366, 49);
            this.cbbDiretorios.StartIndex = 0;
            this.cbbDiretorios.TabIndex = 4;
            this.cbbDiretorios.SelectedIndexChanged += new System.EventHandler(this.cbbDiretorios_SelectedIndexChanged);
            // 
            // txtCaminhoPasta
            // 
            this.txtCaminhoPasta.AnimateReadOnly = false;
            this.txtCaminhoPasta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCaminhoPasta.Depth = 0;
            this.txtCaminhoPasta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCaminhoPasta.LeadingIcon = null;
            this.txtCaminhoPasta.Location = new System.Drawing.Point(466, 96);
            this.txtCaminhoPasta.MaxLength = 50;
            this.txtCaminhoPasta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCaminhoPasta.Multiline = false;
            this.txtCaminhoPasta.Name = "txtCaminhoPasta";
            this.txtCaminhoPasta.Size = new System.Drawing.Size(286, 50);
            this.txtCaminhoPasta.TabIndex = 5;
            this.txtCaminhoPasta.Text = "";
            this.txtCaminhoPasta.TrailingIcon = null;
            // 
            // btnProcurarPasta
            // 
            this.btnProcurarPasta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProcurarPasta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnProcurarPasta.Depth = 0;
            this.btnProcurarPasta.HighEmphasis = true;
            this.btnProcurarPasta.Icon = null;
            this.btnProcurarPasta.Location = new System.Drawing.Point(759, 108);
            this.btnProcurarPasta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProcurarPasta.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnProcurarPasta.Name = "btnProcurarPasta";
            this.btnProcurarPasta.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnProcurarPasta.Size = new System.Drawing.Size(147, 36);
            this.btnProcurarPasta.TabIndex = 6;
            this.btnProcurarPasta.Text = "Procurar Pasta";
            this.btnProcurarPasta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnProcurarPasta.UseAccentColor = false;
            this.btnProcurarPasta.UseVisualStyleBackColor = true;
            this.btnProcurarPasta.Click += new System.EventHandler(this.btnProcurarPasta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 530);
            this.Controls.Add(this.btnProcurarPasta);
            this.Controls.Add(this.txtCaminhoPasta);
            this.Controls.Add(this.cbbDiretorios);
            this.Controls.Add(this.materialListBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
        private MaterialSkin.Controls.MaterialListBox materialListBox1;
        private MaterialSkin.Controls.MaterialComboBox cbbDiretorios;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private MaterialSkin.Controls.MaterialTextBox txtCaminhoPasta;
        private MaterialSkin.Controls.MaterialButton btnProcurarPasta;
    }
}

