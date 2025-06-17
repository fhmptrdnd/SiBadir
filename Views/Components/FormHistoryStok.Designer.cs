namespace SiBadir.Views.Components
{
    partial class FormHistoryStok
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
            components = new System.ComponentModel.Container();
            DataHistory = new DataGridView();
            MenuPanel = new Panel();
            historyStokBahanBindingSource = new BindingSource(components);
            TanggalPerubahan = new DataGridViewTextBoxColumn();
            NamaBahan = new DataGridViewTextBoxColumn();
            NamaUser = new DataGridViewTextBoxColumn();
            StokSebelum = new DataGridViewTextBoxColumn();
            StokSesudah = new DataGridViewTextBoxColumn();
            JenisPerubahan = new DataGridViewTextBoxColumn();
            Keterangan = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DataHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)historyStokBahanBindingSource).BeginInit();
            SuspendLayout();
            // 
            // DataHistory
            // 
            DataHistory.AllowUserToAddRows = false;
            DataHistory.AllowUserToDeleteRows = false;
            DataHistory.AllowUserToResizeColumns = false;
            DataHistory.AllowUserToResizeRows = false;
            DataHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataHistory.BackgroundColor = Color.IndianRed;
            DataHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataHistory.Columns.AddRange(new DataGridViewColumn[] { TanggalPerubahan, NamaBahan, NamaUser, StokSebelum, StokSesudah, JenisPerubahan, Keterangan });
            DataHistory.Location = new Point(0, 233);
            DataHistory.Name = "DataHistory";
            DataHistory.RowHeadersWidth = 51;
            DataHistory.Size = new Size(1156, 472);
            DataHistory.TabIndex = 1;
            // 
            // MenuPanel
            // 
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(1156, 235);
            MenuPanel.TabIndex = 2;
            MenuPanel.Paint += MenuPanel_Paint;
            // 
            // historyStokBahanBindingSource
            // 
            historyStokBahanBindingSource.DataSource = typeof(Model.HistoryStokBahan);
            // 
            // TanggalPerubahan
            // 
            TanggalPerubahan.DataPropertyName = "TanggalPerubahan";
            TanggalPerubahan.HeaderText = "Tanggal Perubahan";
            TanggalPerubahan.MinimumWidth = 6;
            TanggalPerubahan.Name = "TanggalPerubahan";
            // 
            // NamaBahan
            // 
            NamaBahan.DataPropertyName = "NamaBahan";
            NamaBahan.HeaderText = "Nama Bahan";
            NamaBahan.MinimumWidth = 6;
            NamaBahan.Name = "NamaBahan";
            // 
            // NamaUser
            // 
            NamaUser.DataPropertyName = "NamaUser";
            NamaUser.HeaderText = "Nama User";
            NamaUser.MinimumWidth = 6;
            NamaUser.Name = "NamaUser";
            // 
            // StokSebelum
            // 
            StokSebelum.DataPropertyName = "StokSebelum";
            StokSebelum.HeaderText = "Stok Sebelum";
            StokSebelum.MinimumWidth = 6;
            StokSebelum.Name = "StokSebelum";
            // 
            // StokSesudah
            // 
            StokSesudah.DataPropertyName = "StokSesudah";
            StokSesudah.HeaderText = "Stok Sesudah";
            StokSesudah.MinimumWidth = 6;
            StokSesudah.Name = "StokSesudah";
            // 
            // JenisPerubahan
            // 
            JenisPerubahan.DataPropertyName = "JenisPerubahan";
            JenisPerubahan.HeaderText = "Jenis Perubahan";
            JenisPerubahan.MinimumWidth = 6;
            JenisPerubahan.Name = "JenisPerubahan";
            // 
            // Keterangan
            // 
            Keterangan.DataPropertyName = "Keterangan";
            Keterangan.HeaderText = "Keterangan";
            Keterangan.MinimumWidth = 6;
            Keterangan.Name = "Keterangan";
            // 
            // FormHistoryStok
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1155, 705);
            Controls.Add(MenuPanel);
            Controls.Add(DataHistory);
            Name = "FormHistoryStok";
            Text = "FormHistoryStok";
            ((System.ComponentModel.ISupportInitialize)DataHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)historyStokBahanBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataHistory;
        private Panel MenuPanel;
        private BindingSource historyStokBahanBindingSource;
        private DataGridViewTextBoxColumn TanggalPerubahan;
        private DataGridViewTextBoxColumn NamaBahan;
        private DataGridViewTextBoxColumn NamaUser;
        private DataGridViewTextBoxColumn StokSebelum;
        private DataGridViewTextBoxColumn StokSesudah;
        private DataGridViewTextBoxColumn JenisPerubahan;
        private DataGridViewTextBoxColumn Keterangan;
    }
}