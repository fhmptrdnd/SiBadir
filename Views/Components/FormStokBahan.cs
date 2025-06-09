using SiBadir.Controllers;
using SiBadir.Model;
using SiBadir.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiBadir.Controller;

namespace SiBadir
{
    public partial class FormStokBahan : Form
    {
        BindingSource binding = new BindingSource();

        private List<Control> originalMenuContainerControls;

        public FormStokBahan()
        {
            InitializeComponent();

            originalMenuContainerControls = new List<Control>();
            foreach (Control control in MenuContainer2.Controls)
            {
                originalMenuContainerControls.Add(control);
            }
            MenuContainer2.Controls.Clear();

            LoadData();

            RestoreMenuContainerControls();

            btnTambahBahan.Click += btnTambahBahan_Click;
            btnEditBahan.Click += btnEditBahan_Click;
            btnHapusBahan.Click += btnHapusBahan_Click;
        }

        private void LoadData()
        {
            List<Bahan> daftarBahan = StokBahanController.GetDataStokBahan();
            binding.DataSource = daftarBahan;
            dataGridViewBahan.DataSource = binding;

            if (dataGridViewBahan.Columns.Contains("IdBahan"))
                dataGridViewBahan.Columns["IdBahan"].Visible = true;
            if (dataGridViewBahan.Columns.Contains("NamaBahan"))
                dataGridViewBahan.Columns["NamaBahan"].HeaderText = "Nama Bahan Baku";
            if (dataGridViewBahan.Columns.Contains("SatuanBahan"))
                dataGridViewBahan.Columns["SatuanBahan"].HeaderText = "Satuan";
            if (dataGridViewBahan.Columns.Contains("StokBahan"))
                dataGridViewBahan.Columns["StokBahan"].HeaderText = "Stok";
            if (dataGridViewBahan.Columns.Contains("IdKategori"))
                dataGridViewBahan.Columns["IdKategori"].HeaderText = "ID Kategori";
            if (dataGridViewBahan.Columns.Contains("IsActive"))
                dataGridViewBahan.Columns["IsActive"].Visible = false;
        }

        private void elementHide()
        {
            btnTambahBahan.Hide();
            btnEditBahan.Hide();
            btnHapusBahan.Hide();
            labelMenu.Hide();
        }

        private void elementShow()
        {
            RestoreMenuContainerControls();
        }

        private void RestoreMenuContainerControls()
        {
            MenuContainer2.Controls.Clear();
            foreach (Control control in originalMenuContainerControls)
            {
                if (!MenuContainer2.Controls.Contains(control))
                {
                    MenuContainer2.Controls.Add(control);
                }
                control.Show();
            }
        }

        private void btnTambahBahan_Click(object sender, EventArgs e)
        {
            elementHide();
            View.FormAddEditBahan tambahBahan = new View.FormAddEditBahan();
            tambahBahan.FormClosed += (s, args) =>
            {
                elementShow();
                LoadData();
            };
            SiBadir.Controller.FormController.LoadFormInPanel(this.MenuContainer2, tambahBahan);
        }

        private void btnEditBahan_Click(object sender, EventArgs e)
        {
            if (dataGridViewBahan.SelectedRows.Count > 0)
            {
                elementHide();
                Bahan selectedBahan = dataGridViewBahan.SelectedRows[0].DataBoundItem as Bahan;

                if (selectedBahan != null)
                {
                    View.FormAddEditBahan formEdit = new View.FormAddEditBahan(selectedBahan);
                    formEdit.FormClosed += (s, args) =>
                    {
                        elementShow();
                        LoadData();
                    };
                    SiBadir.Controller.FormController.LoadFormInPanel(this.MenuContainer2, formEdit);
                }
            }
            else
            {
                MessageBox.Show("Pilih bahan yang ingin diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHapusBahan_Click(object sender, EventArgs e)
        {
            // Periksa apakah ada baris yang dipilih di awal event
            if (dataGridViewBahan.SelectedRows.Count > 0)
            {
                Bahan selectedBahan = dataGridViewBahan.SelectedRows[0].DataBoundItem as Bahan;
                if (selectedBahan != null)
                {
                    DialogResult confirm = MessageBox.Show($"Apakah Anda yakin ingin menghapus bahan '{selectedBahan.NamaBahan}'?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        try
                        {
                            if (StokBahanController.HapusBahan(selectedBahan.IdBahan))
                            {
                                MessageBox.Show("Bahan berhasil dinonaktifkan (dihapus secara logis).", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadData(); // Muat ulang data setelah penghapusan berhasil
                            }
                            else
                            {
                                MessageBox.Show("Gagal menghapus bahan. Periksa konsol untuk detail error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    // Kasus di mana SelectedRows.Count > 0 tapi DataBoundItem null (jarang terjadi tapi bisa)
                    MessageBox.Show("Data bahan yang dipilih tidak valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Hanya tampilkan pesan ini jika tidak ada baris yang dipilih sejak awal
                //MessageBox.Show("Pilih bahan yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
