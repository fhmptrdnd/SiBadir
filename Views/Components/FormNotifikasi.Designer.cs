namespace SiBadir.Views.Components
{
    partial class FormNotifikasi
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
            title = new Label();
            reminderLabel = new Label();
            DaftarNotifikasi = new DataGridView();
            Pesan = new DataGridViewTextBoxColumn();
            Tanggal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DaftarNotifikasi).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title.ForeColor = Color.White;
            title.Location = new Point(485, 41);
            title.Name = "title";
            title.Size = new Size(246, 39);
            title.TabIndex = 0;
            title.Text = "Menu Notifikasi";
            // 
            // reminderLabel
            // 
            reminderLabel.AutoSize = true;
            reminderLabel.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reminderLabel.ForeColor = Color.White;
            reminderLabel.Location = new Point(403, 105);
            reminderLabel.Name = "reminderLabel";
            reminderLabel.Size = new Size(407, 26);
            reminderLabel.TabIndex = 1;
            reminderLabel.Text = "Tidak ada notifikasi yang belum terbaca";
            // 
            // DaftarNotifikasi
            // 
            DaftarNotifikasi.AllowUserToAddRows = false;
            DaftarNotifikasi.AllowUserToDeleteRows = false;
            DaftarNotifikasi.AllowUserToResizeRows = false;
            DaftarNotifikasi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DaftarNotifikasi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DaftarNotifikasi.BackgroundColor = Color.IndianRed;
            DaftarNotifikasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DaftarNotifikasi.Columns.AddRange(new DataGridViewColumn[] { Pesan, Tanggal });
            DaftarNotifikasi.Location = new Point(0, 147);
            DaftarNotifikasi.Name = "DaftarNotifikasi";
            DaftarNotifikasi.RowHeadersWidth = 51;
            DaftarNotifikasi.Size = new Size(1157, 560);
            DaftarNotifikasi.TabIndex = 2;
            // 
            // Pesan
            // 
            Pesan.DataPropertyName = "Pesan";
            Pesan.HeaderText = "Pesan";
            Pesan.MinimumWidth = 6;
            Pesan.Name = "Pesan";
            Pesan.Width = 75;
            // 
            // Tanggal
            // 
            Tanggal.DataPropertyName = "TanggalNotifikasi";
            Tanggal.HeaderText = "Tanggal Notifikasi";
            Tanggal.MinimumWidth = 6;
            Tanggal.Name = "Tanggal";
            Tanggal.Width = 144;
            // 
            // FormNotifikasi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1155, 705);
            Controls.Add(DaftarNotifikasi);
            Controls.Add(reminderLabel);
            Controls.Add(title);
            Name = "FormNotifikasi";
            Text = "FormNotifikasi";
            ((System.ComponentModel.ISupportInitialize)DaftarNotifikasi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label reminderLabel;
        private DataGridView DaftarNotifikasi;
        private DataGridViewTextBoxColumn Pesan;
        private DataGridViewTextBoxColumn Tanggal;
    }
}