namespace SiBadir
{
    partial class FormStokBahan
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
            labelMenu = new Label();
            MenuContainer2 = new Panel();
            btnHapusBahan = new Button();
            btnEditBahan = new Button();
            btnTambahBahan = new Button();
            dataGridViewBahan = new DataGridView();
            MenuContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBahan).BeginInit();
            SuspendLayout();
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.BackColor = Color.Transparent;
            labelMenu.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMenu.ForeColor = SystemColors.ControlLightLight;
            labelMenu.Location = new Point(540, 25);
            labelMenu.Margin = new Padding(5, 0, 5, 0);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(332, 45);
            labelMenu.TabIndex = 5;
            labelMenu.Text = "Menu Stok Bahan";
            // 
            // MenuContainer2
            // 
            MenuContainer2.BackColor = Color.IndianRed;
            MenuContainer2.Controls.Add(btnHapusBahan);
            MenuContainer2.Controls.Add(labelMenu);
            MenuContainer2.Controls.Add(btnEditBahan);
            MenuContainer2.Controls.Add(btnTambahBahan);
            MenuContainer2.Location = new Point(-6, -1);
            MenuContainer2.Margin = new Padding(5, 5, 5, 5);
            MenuContainer2.Name = "MenuContainer2";
            MenuContainer2.Size = new Size(1454, 368);
            MenuContainer2.TabIndex = 6;
            // 
            // btnHapusBahan
            // 
            btnHapusBahan.Location = new Point(996, 105);
            btnHapusBahan.Margin = new Padding(5, 5, 5, 5);
            btnHapusBahan.Name = "btnHapusBahan";
            btnHapusBahan.Size = new Size(275, 172);
            btnHapusBahan.TabIndex = 6;
            btnHapusBahan.Text = "Hapus Data Bahan";
            btnHapusBahan.UseVisualStyleBackColor = true;
            // 
            // btnEditBahan
            // 
            btnEditBahan.Location = new Point(609, 105);
            btnEditBahan.Margin = new Padding(5, 5, 5, 5);
            btnEditBahan.Name = "btnEditBahan";
            btnEditBahan.Size = new Size(275, 172);
            btnEditBahan.TabIndex = 2;
            btnEditBahan.Text = "Edit Data Bahan";
            btnEditBahan.UseVisualStyleBackColor = true;
            // 
            // btnTambahBahan
            // 
            btnTambahBahan.ImageAlign = ContentAlignment.MiddleLeft;
            btnTambahBahan.Location = new Point(224, 105);
            btnTambahBahan.Margin = new Padding(5, 5, 5, 5);
            btnTambahBahan.Name = "btnTambahBahan";
            btnTambahBahan.Size = new Size(275, 172);
            btnTambahBahan.TabIndex = 1;
            btnTambahBahan.Text = "Tambah Data Bahan";
            btnTambahBahan.UseVisualStyleBackColor = true;
            btnTambahBahan.Click += btnTambahBahan_Click;
            // 
            // dataGridViewBahan
            // 
            dataGridViewBahan.AllowUserToAddRows = false;
            dataGridViewBahan.AllowUserToDeleteRows = false;
            dataGridViewBahan.AllowUserToResizeColumns = false;
            dataGridViewBahan.AllowUserToResizeRows = false;
            dataGridViewBahan.BackgroundColor = Color.IndianRed;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewBahan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewBahan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBahan.Location = new Point(-6, 364);
            dataGridViewBahan.Margin = new Padding(5, 5, 5, 5);
            dataGridViewBahan.Name = "dataGridViewBahan";
            dataGridViewBahan.RowHeadersWidth = 51;
            dataGridViewBahan.Size = new Size(1454, 515);
            dataGridViewBahan.TabIndex = 5;
            // 
            // FormStokBahan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1444, 794);
            Controls.Add(MenuContainer2);
            Controls.Add(dataGridViewBahan);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormStokBahan";
            Text = "Form1";
            MenuContainer2.ResumeLayout(false);
            MenuContainer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBahan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelMenu;
        private Panel MenuContainer2;
        private Button btnHapusBahan;
        private Button btnEditBahan;
        private Button btnTambahBahan;
        private DataGridView dataGridViewBahan;
    }
}