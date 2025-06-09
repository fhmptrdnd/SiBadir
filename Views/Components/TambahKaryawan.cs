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
using SiBadir.Controllers;
using SiBadir.Model;

namespace SiBadir.View
{
    public partial class TambahKaryawan : Form
    {
        private readonly bool _editMode;
        private readonly Pengguna? _karyawan;
        public TambahKaryawan()
        {
            InitializeComponent();
            _editMode = false;
            SubmitBtn.Text = "Tambah";
            labelMenu.Text = "Tambah Data Karyawan";
        }
        public TambahKaryawan(Pengguna? karyawan)
        {
            InitializeComponent();

            _editMode = true;
            _karyawan = karyawan;
            SubmitBtn.Text = "Update Data Karyawan";
            labelMenu.Text = "Edit Data Karyawan";
            NamaKaryawanTextBox.Text = karyawan?.NamaUser;
            AlamatKaryawanTextBox.Text = karyawan?.AlamatUser;
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
            if (_editMode)
            {
                _karyawan.NamaUser = NamaKaryawanTextBox.Text;
                _karyawan.AlamatUser = AlamatKaryawanTextBox.Text;
                if (MenuKaryawanController.EditKaryawan(_karyawan))
                {
                    MessageBox.Show("Data Karyawan berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal memperbarui data karyawan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (MenuKaryawanController.TambahKaryawan(NamaKaryawanTextBox.Text, AlamatKaryawanTextBox.Text))
                {
                    MessageBox.Show("Karyawan berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal Menambah Data Karyawan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void TambahKaryawan_Load(object sender, EventArgs e)
        {

        }
    }
}
