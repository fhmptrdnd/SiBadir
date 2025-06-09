using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiBadir.Controllers; // Untuk mengakses StokBahanController
using SiBadir.Model;      // Untuk mengakses model Bahan

namespace SiBadir.View
{
    public partial class FormAddEditBahan : Form
    {
        private readonly bool _editMode; // Flag untuk mengetahui apakah mode edit atau tambah
        private Bahan? _bahan; // Objek Bahan yang akan diedit (null jika mode tambah)


        public FormAddEditBahan()
        {
            InitializeComponent();
            _editMode = false; 
            SubmitBtn.Text = "Tambah Bahan"; 
            labelMenu.Text = "Tambah Data Bahan";
            StokBahanTextBox.Text = "0";

            SubmitBtn.Click += SubmitBtn_Click;
            Return_Button.Click += Return_Button_Click;
            this.Load += FormAddEditBahan_Load; 
        }

        public FormAddEditBahan(Bahan? bahan)
        {
            InitializeComponent();

            _editMode = true;
            _bahan = bahan;   
            SubmitBtn.Text = "Update Data Bahan"; 
            labelMenu.Text = "Edit Data Bahan";


            if (_bahan != null)
            {
                NamaBahanTextBox.Text = _bahan.NamaBahan;
                SatuanBahanTextBox.Text = _bahan.SatuanBahan;
                IdKategoriTextBox.Text = _bahan.IdKategori.HasValue ? _bahan.IdKategori.Value.ToString() : "";
                StokBahanTextBox.Text = _bahan.StokBahan.ToString();
            }

            SubmitBtn.Click += SubmitBtn_Click;
            Return_Button.Click += Return_Button_Click;
            this.Load += FormAddEditBahan_Load; 
        }

        private void Return_Button_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NamaBahanTextBox.Text) ||
                string.IsNullOrWhiteSpace(SatuanBahanTextBox.Text) ||
                string.IsNullOrWhiteSpace(IdKategoriTextBox.Text) ||
                string.IsNullOrWhiteSpace(StokBahanTextBox.Text))
            {
                MessageBox.Show("Semua kolom harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (!int.TryParse(IdKategoriTextBox.Text, out int idKategori) || idKategori <= 0)
            {
                MessageBox.Show("ID Kategori harus berupa angka bulat positif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(StokBahanTextBox.Text, out int stokBahan) || stokBahan < 0)
            {
                MessageBox.Show("Stok Bahan harus berupa angka bulat non-negatif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (_editMode)
            {
                if (_bahan != null)
                {
                    _bahan.NamaBahan = NamaBahanTextBox.Text.Trim();
                    _bahan.SatuanBahan = SatuanBahanTextBox.Text.Trim();
                    _bahan.IdKategori = idKategori;
                    _bahan.StokBahan = stokBahan;

                    if (StokBahanController.EditBahan(_bahan))
                    {
                        MessageBox.Show("Data bahan berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); 
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui data bahan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {             
                if (StokBahanController.TambahBahan(NamaBahanTextBox.Text, SatuanBahanTextBox.Text, idKategori, stokBahan))
                {
                    MessageBox.Show("Bahan berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Gagal Menambah Data Bahan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
