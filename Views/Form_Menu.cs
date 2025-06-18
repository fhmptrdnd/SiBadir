using SiBadir.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiBadir;
using SiBadir.View;
using SiBadir.Views.Components;
using SiBadir.Controllers;
using SiBadir.Model;

namespace SiBadir
{
    public partial class Form_Menu : Form
    {
        private void CekNotifikasi()
        {
            NotifikasiController.cekNotifikasi(NotifikasiBtn);
        }
        public Form_Menu()
        {
            InitializeComponent();
            NotifikasiController.cekNotifikasi(NotifikasiBtn);
            string role = User.UserLoggedIn.Role;

            if (role == "karyawan")
            {
                label1.Text = "Employee Ver.";
            }
            else
            {
                label1.Text = "Admin Ver.";
            }
        }
        private void BtnKeluar_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Lht_Stok_Bahan_Click(object sender, EventArgs e)
        {
            FormStokBahan formStokBahan = new();
            SiBadir.Controller.FormController.LoadFormInPanel(this.panel1, formStokBahan);
            formStokBahan.StokChanged += CekNotifikasi;
        }

        private void bt_Daftar_Karyawan_Click(object sender, EventArgs e)
        {
            SiBadir.Controller.FormController.LoadFormInPanel(this.panel1, new FormMenuKaryawan());
        }

        private void Greeting_Click(object sender, EventArgs e)
        {

        }

        private void bt_History_Click(object sender, EventArgs e)
        {
            SiBadir.Controller.FormController.LoadFormInPanel(this.panel1, new FormHistoryStok());
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login form1 = new Form_Login();
            form1.FormClosed += (s, args) => this.Close();
            form1.Show();
        }

        private void NotifikasiBtn_Click(object sender, EventArgs e)
        {
            SiBadir.Controller.FormController.LoadFormInPanel(this.panel1, new FormNotifikasi());
            NotifikasiBtn.Text = "Notifikasi";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pilih_Menu_Click(object sender, EventArgs e)
        {

        }

        public FormController FormController
        {
            get => default;
            set
            {
            }
        }

        public NotifikasiController NotifikasiController
        {
            get => default;
            set
            {
            }
        }

        public FormMenuKaryawan FormMenuKaryawan
        {
            get => default;
            set
            {
            }
        }

        public FormHistoryStok FormHistoryStok
        {
            get => default;
            set
            {
            }
        }
    }
}
