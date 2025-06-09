namespace SiBadir
{
    partial class FormMenuKaryawan
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataKaryawan = new DataGridView();
            Tambah_Karyawan = new Button();
            Edit_Karyawan = new Button();
            Hapus_Karyawan = new Button();
            MenuContainer = new Panel();
            labelMenu = new Label();
            ((System.ComponentModel.ISupportInitialize)DataKaryawan).BeginInit();
            MenuContainer.SuspendLayout();
            SuspendLayout();
            // 
            // DataKaryawan
            // 
            DataKaryawan.AllowUserToAddRows = false;
            DataKaryawan.AllowUserToDeleteRows = false;
            DataKaryawan.AllowUserToResizeColumns = false;
            DataKaryawan.AllowUserToResizeRows = false;
            DataKaryawan.BackgroundColor = Color.IndianRed;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataKaryawan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataKaryawan.Location = new Point(-6, 292);
            DataKaryawan.Margin = new Padding(4);
            DataKaryawan.Name = "DataKaryawan";
            DataKaryawan.RowHeadersWidth = 51;
            DataKaryawan.Size = new Size(1206, 585);
            DataKaryawan.TabIndex = 0;
            // 
            // Tambah_Karyawan
            // 
            Tambah_Karyawan.ImageAlign = ContentAlignment.MiddleLeft;
            Tambah_Karyawan.Location = new Point(151, 84);
            Tambah_Karyawan.Margin = new Padding(4);
            Tambah_Karyawan.Name = "Tambah_Karyawan";
            Tambah_Karyawan.Size = new Size(220, 138);
            Tambah_Karyawan.TabIndex = 1;
            Tambah_Karyawan.Text = "Tambah Karyawan";
            Tambah_Karyawan.UseVisualStyleBackColor = true;
            Tambah_Karyawan.Click += Tambah_Karyawan_Click;
            // 
            // Edit_Karyawan
            // 
            Edit_Karyawan.Location = new Point(476, 84);
            Edit_Karyawan.Margin = new Padding(4);
            Edit_Karyawan.Name = "Edit_Karyawan";
            Edit_Karyawan.Size = new Size(220, 138);
            Edit_Karyawan.TabIndex = 2;
            Edit_Karyawan.Text = "Edit Data Karyawan";
            Edit_Karyawan.UseVisualStyleBackColor = true;
            Edit_Karyawan.Click += Edit_Karyawan_Click;
            // 
            // Hapus_Karyawan
            // 
            Hapus_Karyawan.Location = new Point(798, 84);
            Hapus_Karyawan.Margin = new Padding(4);
            Hapus_Karyawan.Name = "Hapus_Karyawan";
            Hapus_Karyawan.Size = new Size(220, 138);
            Hapus_Karyawan.TabIndex = 3;
            Hapus_Karyawan.Text = "Hapus Data Karyawan";
            Hapus_Karyawan.UseVisualStyleBackColor = true;
            Hapus_Karyawan.Click += Hapus_Karyawan_Click;
            // 
            // MenuContainer
            // 
            MenuContainer.BackColor = Color.FromArgb(64, 64, 64);
            MenuContainer.Controls.Add(labelMenu);
            MenuContainer.Controls.Add(Edit_Karyawan);
            MenuContainer.Controls.Add(Hapus_Karyawan);
            MenuContainer.Controls.Add(Tambah_Karyawan);
            MenuContainer.Location = new Point(0, 0);
            MenuContainer.Margin = new Padding(4);
            MenuContainer.Name = "MenuContainer";
            MenuContainer.Size = new Size(1200, 294);
            MenuContainer.TabIndex = 4;
            MenuContainer.Paint += panel1_Paint;
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.BackColor = Color.Transparent;
            labelMenu.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMenu.ForeColor = SystemColors.ControlLightLight;
            labelMenu.Location = new Point(438, 22);
            labelMenu.Margin = new Padding(4, 0, 4, 0);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(303, 45);
            labelMenu.TabIndex = 5;
            labelMenu.Text = "Menu Karyawan";
            // 
            // FormMenuKaryawan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 875);
            Controls.Add(MenuContainer);
            Controls.Add(DataKaryawan);
            Margin = new Padding(4);
            Name = "FormMenuKaryawan";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DataKaryawan).EndInit();
            MenuContainer.ResumeLayout(false);
            MenuContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DataKaryawan;
        private Button Tambah_Karyawan;
        private Button Edit_Karyawan;
        private Button Hapus_Karyawan;
        private Panel MenuContainer;
        private Label labelMenu;
    }
}