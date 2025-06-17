namespace SiBadir.Views.Components
{
    partial class BaseMenuHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelMenu = new Label();
            SearchNamaBahan = new TextBox();
            SearchNamaUser = new TextBox();
            SearchTanggal = new DateTimePicker();
            SearchKategori = new ComboBox();
            SearchJenisPerubahan = new ComboBox();
            SearchBtn = new Button();
            NamaBahanLabel = new Label();
            NamaUserLabel = new Label();
            TanggalPerubahanLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            ResetBtn = new Button();
            SuspendLayout();
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMenu.ForeColor = Color.White;
            labelMenu.Location = new Point(354, 9);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(397, 39);
            labelMenu.TabIndex = 6;
            labelMenu.Text = "Menu History Stok Bahan";
            // 
            // SearchNamaBahan
            // 
            SearchNamaBahan.Location = new Point(215, 82);
            SearchNamaBahan.Name = "SearchNamaBahan";
            SearchNamaBahan.Size = new Size(227, 27);
            SearchNamaBahan.TabIndex = 7;
            // 
            // SearchNamaUser
            // 
            SearchNamaUser.Location = new Point(215, 127);
            SearchNamaUser.Name = "SearchNamaUser";
            SearchNamaUser.Size = new Size(227, 27);
            SearchNamaUser.TabIndex = 8;
            // 
            // SearchTanggal
            // 
            SearchTanggal.Checked = false;
            SearchTanggal.Location = new Point(607, 82);
            SearchTanggal.MaxDate = new DateTime(2025, 6, 9, 0, 0, 0, 0);
            SearchTanggal.Name = "SearchTanggal";
            SearchTanggal.ShowCheckBox = true;
            SearchTanggal.Size = new Size(294, 27);
            SearchTanggal.TabIndex = 9;
            SearchTanggal.Value = new DateTime(2025, 6, 9, 0, 0, 0, 0);
            // 
            // SearchKategori
            // 
            SearchKategori.FormattingEnabled = true;
            SearchKategori.Location = new Point(583, 126);
            SearchKategori.Name = "SearchKategori";
            SearchKategori.Size = new Size(137, 28);
            SearchKategori.TabIndex = 10;
            SearchKategori.Text = "Semua";
            // 
            // SearchJenisPerubahan
            // 
            SearchJenisPerubahan.FormattingEnabled = true;
            SearchJenisPerubahan.Items.AddRange(new object[] { "Semua", "Penambahan", "Pengurangan", "Perubahan Data Bahan" });
            SearchJenisPerubahan.Location = new Point(852, 127);
            SearchJenisPerubahan.Name = "SearchJenisPerubahan";
            SearchJenisPerubahan.Size = new Size(137, 28);
            SearchJenisPerubahan.TabIndex = 11;
            SearchJenisPerubahan.Text = "Semua";
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(583, 174);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(94, 29);
            SearchBtn.TabIndex = 12;
            SearchBtn.Text = "Cari!";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // NamaBahanLabel
            // 
            NamaBahanLabel.AutoSize = true;
            NamaBahanLabel.ForeColor = Color.White;
            NamaBahanLabel.Location = new Point(108, 85);
            NamaBahanLabel.Name = "NamaBahanLabel";
            NamaBahanLabel.Size = new Size(101, 20);
            NamaBahanLabel.TabIndex = 13;
            NamaBahanLabel.Text = "Nama Bahan :";
            // 
            // NamaUserLabel
            // 
            NamaUserLabel.AutoSize = true;
            NamaUserLabel.ForeColor = Color.White;
            NamaUserLabel.Location = new Point(108, 130);
            NamaUserLabel.Name = "NamaUserLabel";
            NamaUserLabel.Size = new Size(89, 20);
            NamaUserLabel.TabIndex = 14;
            NamaUserLabel.Text = "Nama User :";
            // 
            // TanggalPerubahanLabel
            // 
            TanggalPerubahanLabel.AutoSize = true;
            TanggalPerubahanLabel.ForeColor = Color.White;
            TanggalPerubahanLabel.Location = new Point(460, 85);
            TanggalPerubahanLabel.Name = "TanggalPerubahanLabel";
            TanggalPerubahanLabel.Size = new Size(141, 20);
            TanggalPerubahanLabel.TabIndex = 15;
            TanggalPerubahanLabel.Text = "Tanggal Perubahan :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(460, 130);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 16;
            label1.Text = "Nama Kategori :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(726, 130);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 17;
            label2.Text = "Jenis Perubahan :";
            // 
            // ResetBtn
            // 
            ResetBtn.Location = new Point(424, 174);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(121, 29);
            ResetBtn.TabIndex = 18;
            ResetBtn.Text = "Reset Tampilan!";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // BaseMenuHistory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1084, 235);
            Controls.Add(ResetBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TanggalPerubahanLabel);
            Controls.Add(NamaUserLabel);
            Controls.Add(NamaBahanLabel);
            Controls.Add(SearchBtn);
            Controls.Add(SearchJenisPerubahan);
            Controls.Add(SearchKategori);
            Controls.Add(SearchTanggal);
            Controls.Add(SearchNamaUser);
            Controls.Add(SearchNamaBahan);
            Controls.Add(labelMenu);
            Name = "BaseMenuHistory";
            Text = "BaseMenuHistory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMenu;
        private TextBox SearchNamaBahan;
        private TextBox SearchNamaUser;
        private DateTimePicker SearchTanggal;
        private ComboBox SearchKategori;
        private ComboBox SearchJenisPerubahan;
        private Button SearchBtn;
        private Label NamaBahanLabel;
        private Label NamaUserLabel;
        private Label TanggalPerubahanLabel;
        private Label label1;
        private Label label2;
        private Button ResetBtn;
    }
}