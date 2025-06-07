using SiBadir.Properties;

namespace SiBadir
{
    partial class Form_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            Pilih_Menu = new Label();
            bt_Daftar_Karyawan = new Button();
            bt_Lht_Stok_Bahan = new Button();
            bt_History = new Button();
            Btn_keluar = new Button();
            Greeting = new Label();
            SuspendLayout();
            // 
            // Pilih_Menu
            // 
            Pilih_Menu.AutoSize = true;
            Pilih_Menu.BackColor = Color.Transparent;
            Pilih_Menu.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pilih_Menu.ForeColor = SystemColors.ButtonHighlight;
            Pilih_Menu.Location = new Point(590, 119);
            Pilih_Menu.Name = "Pilih_Menu";
            Pilih_Menu.Size = new Size(187, 39);
            Pilih_Menu.TabIndex = 0;
            Pilih_Menu.Text = "Pilih Menu";
            Pilih_Menu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bt_Daftar_Karyawan
            // 
            bt_Daftar_Karyawan.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_Daftar_Karyawan.ForeColor = Color.Black;
            bt_Daftar_Karyawan.Location = new Point(504, 207);
            bt_Daftar_Karyawan.Name = "bt_Daftar_Karyawan";
            bt_Daftar_Karyawan.Size = new Size(354, 77);
            bt_Daftar_Karyawan.TabIndex = 1;
            bt_Daftar_Karyawan.Text = "Daftar Karyawan";
            bt_Daftar_Karyawan.UseVisualStyleBackColor = true;
            bt_Daftar_Karyawan.Click += bt_Daftar_Karyawan_Click;
            // 
            // bt_Lht_Stok_Bahan
            // 
            bt_Lht_Stok_Bahan.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_Lht_Stok_Bahan.ForeColor = Color.Black;
            bt_Lht_Stok_Bahan.Location = new Point(504, 301);
            bt_Lht_Stok_Bahan.Name = "bt_Lht_Stok_Bahan";
            bt_Lht_Stok_Bahan.Size = new Size(354, 77);
            bt_Lht_Stok_Bahan.TabIndex = 2;
            bt_Lht_Stok_Bahan.Text = "Lihat Stok Bahan";
            bt_Lht_Stok_Bahan.UseVisualStyleBackColor = true;
            bt_Lht_Stok_Bahan.Click += bt_Lht_Stok_Bahan_Click;
            // 
            // bt_History
            // 
            bt_History.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_History.ForeColor = Color.Black;
            bt_History.Location = new Point(504, 398);
            bt_History.Name = "bt_History";
            bt_History.Size = new Size(354, 77);
            bt_History.TabIndex = 3;
            bt_History.Text = "History";
            bt_History.UseVisualStyleBackColor = true;
            // 
            // Btn_keluar
            // 
            Btn_keluar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Btn_keluar.ForeColor = Color.Brown;
            Btn_keluar.Location = new Point(600, 527);
            Btn_keluar.Name = "Btn_keluar";
            Btn_keluar.Size = new Size(163, 43);
            Btn_keluar.TabIndex = 4;
            Btn_keluar.Text = "Keluar";
            Btn_keluar.UseVisualStyleBackColor = true;
            Btn_keluar.Click += BtnKeluar_click;
            // 
            // Greeting
            // 
            Greeting.AutoSize = true;
            Greeting.BackColor = Color.Transparent;
            Greeting.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            Greeting.ForeColor = SystemColors.Control;
            Greeting.Location = new Point(542, 70);
            Greeting.Name = "Greeting";
            Greeting.Size = new Size(275, 39);
            Greeting.TabIndex = 5;
            Greeting.Text = "Selamat Datang";
            // 
            // Form_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1330, 700);
            Controls.Add(Greeting);
            Controls.Add(Btn_keluar);
            Controls.Add(bt_History);
            Controls.Add(bt_Lht_Stok_Bahan);
            Controls.Add(bt_Daftar_Karyawan);
            Controls.Add(Pilih_Menu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Pilih_Menu;
        private Button bt_Daftar_Karyawan;
        private Button bt_Lht_Stok_Bahan;
        private Button bt_History;
        private Button Btn_keluar;
        private Label Greeting;
    }
}