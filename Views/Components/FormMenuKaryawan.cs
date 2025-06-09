using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiBadir.Controllers;
using SiBadir.Model;
using static System.Windows.Forms.DataFormats;

namespace SiBadir
{
    public partial class FormMenuKaryawan : Form
    {
        BindingSource binding = new BindingSource();
        private void LoadData()
        {
            binding.DataSource = MenuKaryawanController.GetDataKaryawan();
            DataKaryawan.DataSource = binding;
        }

        private List<Control> originalMenuContainerControls;
        public FormMenuKaryawan()
        {
            InitializeComponent();

            originalMenuContainerControls = new List<Control>();
            foreach (Control control in MenuContainer.Controls)
            {
                originalMenuContainerControls.Add(control);
            }
            MenuContainer.Controls.Clear();

            LoadData();

            RestoreMenuContainerControls();

            Hapus_Karyawan.Click += Hapus_Karyawan_Click;
            Edit_Karyawan.Click += Edit_Karyawan_Click;
            Tambah_Karyawan.Click += Tambah_Karyawan_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void elementHide()
        {
            Hapus_Karyawan.Hide();
            Edit_Karyawan.Hide();
            Tambah_Karyawan.Hide();
            labelMenu.Hide();
        }

        private void elementShow()
        {
            RestoreMenuContainerControls();
        }

        private void RestoreMenuContainerControls()
        {
            MenuContainer.Controls.Clear();
            foreach (Control control in originalMenuContainerControls)
            {
                if (!MenuContainer.Controls.Contains(control))
                {
                    MenuContainer.Controls.Add(control);
                }
                control.Show();
            }
        }

        //private void btnTambahBahan_Click(object sender, EventArgs e)
        //{
        //    elementHide();
        //    View.FormAddEditBahan tambahBahan = new View.FormAddEditBahan();
        //    tambahBahan.FormClosed += (s, args) =>
        //    {
        //        elementShow();
        //        LoadData();
        //    };
        //    SiBadir.Controller.FormController.LoadFormInPanel(this.MenuContainer, tambahBahan);
        //}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tambah_Karyawan_Click(object sender, EventArgs e)
        {
            elementHide();
            Form tambahKaryawan = new View.TambahKaryawan();
            tambahKaryawan.FormClosed += (s, args) =>
            {
                elementShow();
                LoadData();
            };
            SiBadir.Controller.FormController.LoadFormInPanel(this.MenuContainer, tambahKaryawan);
        }

        private void Edit_Karyawan_Click(object sender, EventArgs e)
        {
            if (DataKaryawan.SelectedRows.Count == 1)
            {
                elementHide();
                Pengguna karyawan = (Pengguna)DataKaryawan.SelectedRows[0].DataBoundItem;
                Form tambahKaryawan = new View.TambahKaryawan(karyawan);
                tambahKaryawan.FormClosed += (s, args) =>
                {
                    this.elementShow();
                    LoadData();
                };
                SiBadir.Controller.FormController.LoadFormInPanel(this.MenuContainer, tambahKaryawan);
            }
            else
            {
                MessageBox.Show("Pilih 1 Data Karyawan Untuk Diedit", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Hapus_Karyawan_Click(object sender, EventArgs e)
        {
            if (DataKaryawan.SelectedRows.Count > 0)
            {
                Pengguna karyawanYgDihapus = (Pengguna)DataKaryawan.SelectedRows[0].DataBoundItem;

                string pesanKonfirmasi = $"Apakah kamu yakin ingin menghapus karyawan bernama \"{karyawanYgDihapus.NamaUser}\"?";
                string judulKonfirmasi = "Konfirmasi Hapus Data";

                DialogResult hasil = MessageBox.Show(pesanKonfirmasi, judulKonfirmasi, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (hasil == DialogResult.Yes)
                {
                    try
                    {
                        if (MenuKaryawanController.HapusKaryawan(karyawanYgDihapus.IdUser))
                        {
                            MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Gagal menghapus data dari database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi error saat mencoba menghapus data: " + ex.Message, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Kalau nggak ada baris yang dipilih sama sekali saat tombol hapus diklik
                //MessageBox.Show("Pilih 1 Data Karyawan Untuk Dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
