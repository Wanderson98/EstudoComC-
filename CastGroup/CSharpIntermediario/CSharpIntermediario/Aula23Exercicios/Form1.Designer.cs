namespace Aula23Exercicios
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
            this.ListArray = new MaterialSkin.Controls.MaterialListBox();
            this.btnCarregarListBox = new MaterialSkin.Controls.MaterialButton();
            this.btnDroDown = new MaterialSkin.Controls.MaterialButton();
            this.btnCheckar = new MaterialSkin.Controls.MaterialButton();
            this.ComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCheckedListBox1 = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.Checkbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtData = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.txtDia = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMes = new MaterialSkin.Controls.MaterialTextBox();
            this.txtAno = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDiaDoAno = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDiaDaSemana = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialCheckedListBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListArray
            // 
            this.ListArray.BackColor = System.Drawing.Color.White;
            this.ListArray.BorderColor = System.Drawing.Color.LightGray;
            this.ListArray.Depth = 0;
            this.ListArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ListArray.Location = new System.Drawing.Point(17, 151);
            this.ListArray.MouseState = MaterialSkin.MouseState.HOVER;
            this.ListArray.Name = "ListArray";
            this.ListArray.SelectedIndex = -1;
            this.ListArray.SelectedItem = null;
            this.ListArray.Size = new System.Drawing.Size(177, 286);
            this.ListArray.TabIndex = 2;
            // 
            // btnCarregarListBox
            // 
            this.btnCarregarListBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCarregarListBox.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCarregarListBox.Depth = 0;
            this.btnCarregarListBox.HighEmphasis = true;
            this.btnCarregarListBox.Icon = null;
            this.btnCarregarListBox.Location = new System.Drawing.Point(17, 106);
            this.btnCarregarListBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCarregarListBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCarregarListBox.Name = "btnCarregarListBox";
            this.btnCarregarListBox.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCarregarListBox.Size = new System.Drawing.Size(162, 36);
            this.btnCarregarListBox.TabIndex = 4;
            this.btnCarregarListBox.Text = "Carregar List Box";
            this.btnCarregarListBox.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCarregarListBox.UseAccentColor = false;
            this.btnCarregarListBox.UseVisualStyleBackColor = true;
            this.btnCarregarListBox.Click += new System.EventHandler(this.btnCarregarListBox_Click);
            // 
            // btnDroDown
            // 
            this.btnDroDown.AutoSize = false;
            this.btnDroDown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDroDown.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDroDown.Depth = 0;
            this.btnDroDown.HighEmphasis = true;
            this.btnDroDown.Icon = null;
            this.btnDroDown.Location = new System.Drawing.Point(236, 106);
            this.btnDroDown.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDroDown.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDroDown.Name = "btnDroDown";
            this.btnDroDown.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDroDown.Size = new System.Drawing.Size(168, 36);
            this.btnDroDown.TabIndex = 5;
            this.btnDroDown.Text = "Carregar Drop Down";
            this.btnDroDown.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDroDown.UseAccentColor = false;
            this.btnDroDown.UseVisualStyleBackColor = true;
            this.btnDroDown.Click += new System.EventHandler(this.btnDroDown_Click);
            // 
            // btnCheckar
            // 
            this.btnCheckar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCheckar.Depth = 0;
            this.btnCheckar.HighEmphasis = true;
            this.btnCheckar.Icon = null;
            this.btnCheckar.Location = new System.Drawing.Point(530, 106);
            this.btnCheckar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCheckar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCheckar.Name = "btnCheckar";
            this.btnCheckar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCheckar.Size = new System.Drawing.Size(88, 36);
            this.btnCheckar.TabIndex = 6;
            this.btnCheckar.Text = "Checkar";
            this.btnCheckar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCheckar.UseAccentColor = false;
            this.btnCheckar.UseVisualStyleBackColor = true;
            this.btnCheckar.Click += new System.EventHandler(this.btnCheckar_Click);
            // 
            // ComboBox1
            // 
            this.ComboBox1.AutoResize = false;
            this.ComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBox1.Depth = 0;
            this.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBox1.DropDownHeight = 174;
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.DropDownWidth = 121;
            this.ComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.IntegralHeight = false;
            this.ComboBox1.ItemHeight = 43;
            this.ComboBox1.Location = new System.Drawing.Point(236, 151);
            this.ComboBox1.MaxDropDownItems = 4;
            this.ComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(257, 49);
            this.ComboBox1.StartIndex = 0;
            this.ComboBox1.TabIndex = 8;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(685, 551);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(37, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Logo";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialCheckedListBox1
            // 
            this.materialCheckedListBox1.AutoScroll = true;
            this.materialCheckedListBox1.BackColor = System.Drawing.SystemColors.Control;
            this.materialCheckedListBox1.Controls.Add(this.Checkbox);
            this.materialCheckedListBox1.Depth = 0;
            this.materialCheckedListBox1.Location = new System.Drawing.Point(530, 152);
            this.materialCheckedListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckedListBox1.Name = "materialCheckedListBox1";
            this.materialCheckedListBox1.Size = new System.Drawing.Size(208, 67);
            this.materialCheckedListBox1.Striped = false;
            this.materialCheckedListBox1.StripeDarkColor = System.Drawing.Color.Empty;
            this.materialCheckedListBox1.TabIndex = 11;
            // 
            // Checkbox
            // 
            this.Checkbox.AutoSize = true;
            this.Checkbox.Depth = 0;
            this.Checkbox.Location = new System.Drawing.Point(15, 12);
            this.Checkbox.Margin = new System.Windows.Forms.Padding(0);
            this.Checkbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Checkbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.ReadOnly = false;
            this.Checkbox.Ripple = true;
            this.Checkbox.Size = new System.Drawing.Size(104, 37);
            this.Checkbox.TabIndex = 0;
            this.Checkbox.Text = "Checkbox";
            this.Checkbox.UseVisualStyleBackColor = true;
            // 
            // txtData
            // 
            this.txtData.AnimateReadOnly = false;
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtData.Depth = 0;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtData.LeadingIcon = null;
            this.txtData.Location = new System.Drawing.Point(236, 245);
            this.txtData.MaxLength = 50;
            this.txtData.MouseState = MaterialSkin.MouseState.OUT;
            this.txtData.Multiline = false;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(208, 50);
            this.txtData.TabIndex = 12;
            this.txtData.Text = "";
            this.txtData.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(233, 223);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(35, 19);
            this.materialLabel2.TabIndex = 13;
            this.materialLabel2.Text = "Data";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(236, 304);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(122, 36);
            this.materialButton1.TabIndex = 14;
            this.materialButton1.Text = "Extrair Data";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // txtDia
            // 
            this.txtDia.AnimateReadOnly = false;
            this.txtDia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDia.Depth = 0;
            this.txtDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDia.LeadingIcon = null;
            this.txtDia.Location = new System.Drawing.Point(236, 349);
            this.txtDia.MaxLength = 50;
            this.txtDia.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDia.Multiline = false;
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(208, 50);
            this.txtDia.TabIndex = 15;
            this.txtDia.Text = "";
            this.txtDia.TrailingIcon = null;
            // 
            // txtMes
            // 
            this.txtMes.AnimateReadOnly = false;
            this.txtMes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMes.Depth = 0;
            this.txtMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMes.LeadingIcon = null;
            this.txtMes.Location = new System.Drawing.Point(236, 405);
            this.txtMes.MaxLength = 50;
            this.txtMes.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMes.Multiline = false;
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(208, 50);
            this.txtMes.TabIndex = 15;
            this.txtMes.Text = "";
            this.txtMes.TrailingIcon = null;
            // 
            // txtAno
            // 
            this.txtAno.AnimateReadOnly = false;
            this.txtAno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAno.Depth = 0;
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAno.LeadingIcon = null;
            this.txtAno.Location = new System.Drawing.Point(236, 461);
            this.txtAno.MaxLength = 50;
            this.txtAno.MouseState = MaterialSkin.MouseState.OUT;
            this.txtAno.Multiline = false;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(208, 50);
            this.txtAno.TabIndex = 15;
            this.txtAno.Text = "";
            this.txtAno.TrailingIcon = null;
            // 
            // txtDiaDoAno
            // 
            this.txtDiaDoAno.AnimateReadOnly = false;
            this.txtDiaDoAno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaDoAno.Depth = 0;
            this.txtDiaDoAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDiaDoAno.LeadingIcon = null;
            this.txtDiaDoAno.Location = new System.Drawing.Point(236, 517);
            this.txtDiaDoAno.MaxLength = 50;
            this.txtDiaDoAno.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDiaDoAno.Multiline = false;
            this.txtDiaDoAno.Name = "txtDiaDoAno";
            this.txtDiaDoAno.Size = new System.Drawing.Size(208, 50);
            this.txtDiaDoAno.TabIndex = 15;
            this.txtDiaDoAno.Text = "";
            this.txtDiaDoAno.TrailingIcon = null;
            // 
            // txtDiaDaSemana
            // 
            this.txtDiaDaSemana.AnimateReadOnly = false;
            this.txtDiaDaSemana.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaDaSemana.Depth = 0;
            this.txtDiaDaSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDiaDaSemana.LeadingIcon = null;
            this.txtDiaDaSemana.Location = new System.Drawing.Point(236, 573);
            this.txtDiaDaSemana.MaxLength = 50;
            this.txtDiaDaSemana.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDiaDaSemana.Multiline = false;
            this.txtDiaDaSemana.Name = "txtDiaDaSemana";
            this.txtDiaDaSemana.Size = new System.Drawing.Size(208, 50);
            this.txtDiaDaSemana.TabIndex = 15;
            this.txtDiaDaSemana.Text = "";
            this.txtDiaDaSemana.TrailingIcon = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aula23Exercicios.Properties.Resources._1638362117941_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(679, 573);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(749, 648);
            this.Controls.Add(this.txtDiaDaSemana);
            this.Controls.Add(this.txtDiaDoAno);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.materialCheckedListBox1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.btnCheckar);
            this.Controls.Add(this.btnDroDown);
            this.Controls.Add(this.btnCarregarListBox);
            this.Controls.Add(this.ListArray);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.materialCheckedListBox1.ResumeLayout(false);
            this.materialCheckedListBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialListBox ListArray;
        private MaterialSkin.Controls.MaterialButton btnCarregarListBox;
        private MaterialSkin.Controls.MaterialButton btnDroDown;
        private MaterialSkin.Controls.MaterialButton btnCheckar;
        private MaterialSkin.Controls.MaterialComboBox ComboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckedListBox materialCheckedListBox1;
        private MaterialSkin.Controls.MaterialCheckbox Checkbox;
        private MaterialSkin.Controls.MaterialTextBox txtData;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox txtDia;
        private MaterialSkin.Controls.MaterialTextBox txtMes;
        private MaterialSkin.Controls.MaterialTextBox txtAno;
        private MaterialSkin.Controls.MaterialTextBox txtDiaDoAno;
        private MaterialSkin.Controls.MaterialTextBox txtDiaDaSemana;
    }
}

