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
            panel1 = new Panel();
            label1 = new Label();
            btBack = new Button();
            SuspendLayout();
            // 
            // Pilih_Menu
            // 
            Pilih_Menu.AutoSize = true;
            Pilih_Menu.BackColor = Color.Transparent;
            Pilih_Menu.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pilih_Menu.ForeColor = SystemColors.ButtonHighlight;
            Pilih_Menu.Location = new Point(87, 227);
            Pilih_Menu.Margin = new Padding(4, 0, 4, 0);
            Pilih_Menu.Name = "Pilih_Menu";
            Pilih_Menu.Size = new Size(185, 25);
            Pilih_Menu.TabIndex = 0;
            Pilih_Menu.Text = "Silakan pilih menu...";
            Pilih_Menu.TextAlign = ContentAlignment.MiddleCenter;
            Pilih_Menu.Click += Pilih_Menu_Click;
            // 
            // bt_Daftar_Karyawan
            // 
            bt_Daftar_Karyawan.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_Daftar_Karyawan.ForeColor = Color.Black;
            bt_Daftar_Karyawan.Location = new Point(52, 294);
            bt_Daftar_Karyawan.Margin = new Padding(4);
            bt_Daftar_Karyawan.Name = "bt_Daftar_Karyawan";
            bt_Daftar_Karyawan.Size = new Size(242, 41);
            bt_Daftar_Karyawan.TabIndex = 1;
            bt_Daftar_Karyawan.Text = "Daftar Karyawan";
            bt_Daftar_Karyawan.UseVisualStyleBackColor = true;
            bt_Daftar_Karyawan.Click += bt_Daftar_Karyawan_Click;
            // 
            // bt_Lht_Stok_Bahan
            // 
            bt_Lht_Stok_Bahan.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_Lht_Stok_Bahan.ForeColor = Color.Black;
            bt_Lht_Stok_Bahan.Location = new Point(52, 361);
            bt_Lht_Stok_Bahan.Margin = new Padding(4);
            bt_Lht_Stok_Bahan.Name = "bt_Lht_Stok_Bahan";
            bt_Lht_Stok_Bahan.Size = new Size(242, 41);
            bt_Lht_Stok_Bahan.TabIndex = 2;
            bt_Lht_Stok_Bahan.Text = "Lihat Stok Bahan";
            bt_Lht_Stok_Bahan.UseVisualStyleBackColor = true;
            bt_Lht_Stok_Bahan.Click += bt_Lht_Stok_Bahan_Click;
            // 
            // bt_History
            // 
            bt_History.Font = new Font("Microsoft Sans Serif", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_History.ForeColor = Color.Black;
            bt_History.Location = new Point(52, 425);
            bt_History.Margin = new Padding(4);
            bt_History.Name = "bt_History";
            bt_History.Size = new Size(242, 41);
            bt_History.TabIndex = 3;
            bt_History.Text = "History";
            bt_History.UseVisualStyleBackColor = true;
            bt_History.Click += bt_History_Click;
            // 
            // Btn_keluar
            // 
            Btn_keluar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn_keluar.ForeColor = Color.Red;
            Btn_keluar.Location = new Point(14, 641);
            Btn_keluar.Margin = new Padding(4);
            Btn_keluar.Name = "Btn_keluar";
            Btn_keluar.Size = new Size(96, 46);
            Btn_keluar.TabIndex = 4;
            Btn_keluar.Text = "Keluar";
            Btn_keluar.UseVisualStyleBackColor = true;
            Btn_keluar.Click += BtnKeluar_click;
            // 
            // Greeting
            // 
            Greeting.AutoSize = true;
            Greeting.BackColor = Color.Transparent;
            Greeting.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Greeting.ForeColor = SystemColors.ControlLight;
            Greeting.Location = new Point(14, 181);
            Greeting.Margin = new Padding(4, 0, 4, 0);
            Greeting.Name = "Greeting";
            Greeting.Size = new Size(331, 46);
            Greeting.TabIndex = 5;
            Greeting.Text = "Selamat Datang!";
            Greeting.Click += Greeting_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Location = new Point(355, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1173, 882);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, -3);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 7;
            label1.Text = "Admin Ver.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // btBack
            // 
            btBack.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btBack.ForeColor = Color.Red;
            btBack.Location = new Point(43, 492);
            btBack.Margin = new Padding(4);
            btBack.Name = "btBack";
            btBack.Size = new Size(257, 40);
            btBack.TabIndex = 8;
            btBack.Text = "Kembali ke Menu Login";
            btBack.UseVisualStyleBackColor = true;
            btBack.Click += btBack_Click;
            // 
            // Form_Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1525, 700);
            Controls.Add(btBack);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(Greeting);
            Controls.Add(Btn_keluar);
            Controls.Add(bt_History);
            Controls.Add(bt_Lht_Stok_Bahan);
            Controls.Add(bt_Daftar_Karyawan);
            Controls.Add(Pilih_Menu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
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
        private Panel panel1;
        private Label label1;
        private Button btBack;
    }
}