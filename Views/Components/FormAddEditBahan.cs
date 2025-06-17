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

namespace SiBadir.View
{
    public partial class FormAddEditBahan : Form
    {
        private readonly bool _editMode;
        private Bahan? _bahan;
        private int _loggedInUserId;
        public FormAddEditBahan(int loggedInUserId)
        {
            InitializeComponent();
            SelectKategori.Items.Clear();
            SelectKategori.Items.AddRange(MenuHistoryController.getListKategori().ToArray());
            SelectKategori.SelectedIndex = 0;

            _editMode = false;
            SubmitBtn.Text = "Tambah Bahan";
            labelMenu.Text = "Tambah Data Bahan";
            StokBahanTextBox.Text = "0";

            _loggedInUserId = loggedInUserId;

            SubmitBtn.Click += SubmitBtn_Click;
            Return_Button.Click += Return_Button_Click;
            this.Load += FormAddEditBahan_Load;
        }

        public FormAddEditBahan(Bahan? bahan, int loggedInUserId)
        {
            InitializeComponent();
            SelectKategori.Items.Clear();
            SelectKategori.Items.AddRange(MenuHistoryController.getListKategori().ToArray());
            SelectKategori.SelectedIndex = 0;

            _editMode = true;
            _bahan = bahan;
            SubmitBtn.Text = "Update Data Bahan";
            labelMenu.Text = "Edit Data Bahan";

            _loggedInUserId = loggedInUserId;

            if (_bahan != null)
            {
                //int IdKategori = MenuHistoryController.checkKategori(SelectKategori.SelectedItem?.ToString());
                NamaBahanTextBox.Text = _bahan.NamaBahan;
                SatuanBahanTextBox.Text = _bahan.SatuanBahan;
                //IdKategoriTextBox.Text = _bahan.IdKategori.HasValue ? _bahan.IdKategori.Value.ToString() : "";
                StokBahanTextBox.Text = _bahan.StokBahan.ToString();
            }

            SubmitBtn.Click += SubmitBtn_Click;
            Return_Button.Click += Return_Button_Click;
            this.Load += FormAddEditBahan_Load;
        }

        public Bahan Bahan
        {
            get => default;
            set
            {
            }
        }

        public MenuHistoryController MenuHistoryController
        {
            get => default;
            set
            {
            }
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            int id_kategori = MenuHistoryController.checkKategori(SelectKategori.SelectedItem?.ToString());
            if (string.IsNullOrWhiteSpace(NamaBahanTextBox.Text) ||
                string.IsNullOrWhiteSpace(SatuanBahanTextBox.Text) ||
                string.IsNullOrWhiteSpace(id_kategori.ToString()) ||
                string.IsNullOrWhiteSpace(StokBahanTextBox.Text))
            {
                MessageBox.Show("Semua kolom harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //if (!int.TryParse(IdKategoriTextBox.Text, out int idKategori) || idKategori <= 0)
            //{
            //    MessageBox.Show("ID Kategori harus berupa angka bulat positif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            if (!int.TryParse(StokBahanTextBox.Text, out int stokBahan) || stokBahan < 0)
            {
                MessageBox.Show("Stok Bahan harus berupa angka bulat non-negatif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_editMode)
                {
                    if (_bahan != null)
                    {
                        _bahan.NamaBahan = NamaBahanTextBox.Text.Trim();
                        _bahan.SatuanBahan = SatuanBahanTextBox.Text.Trim();
                        _bahan.IdKategori = id_kategori;
                        _bahan.StokBahan = stokBahan;

                        if (StokBahanController.EditBahan(_bahan, _loggedInUserId))
                        {
                            MessageBox.Show("Data bahan berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Gagal memperbarui data bahan! (Pesan generik)", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    if (StokBahanController.TambahBahan(NamaBahanTextBox.Text, SatuanBahanTextBox.Text, id_kategori, stokBahan, _loggedInUserId))
                    {
                        MessageBox.Show("Bahan berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Gagal Menambah Data Bahan! (Pesan generik)", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error Operasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddEditBahan_Load(object sender, EventArgs e)
        {

        }

        private void labelMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
