using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiBadir.Model;
using SiBadir.Repositories;
using SiBadir.Controllers; 

namespace SiBadir.View
{
    public partial class FormHistoryBahan : Form
    {
        private HistoryStokBahanRepository _historyRepo = new HistoryStokBahanRepository();

        public FormHistoryBahan()
        {
            InitializeComponent();
            LoadHistoryData();
        }

        private void LoadHistoryData()
        {
            try
            {
                List<HistoryStokBahan> historyList = _historyRepo.GetAll();
                dataGridViewHistory.DataSource = historyList;

                // Opsional: Kustomisasi tampilan DataGridView History
                if (dataGridViewHistory.Columns.Contains("IdHistory"))
                    dataGridViewHistory.Columns["IdHistory"].Visible = false;
                if (dataGridViewHistory.Columns.Contains("IdBahan"))
                    dataGridViewHistory.Columns["IdBahan"].HeaderText = "ID Bahan";
                if (dataGridViewHistory.Columns.Contains("IdUser"))
                    dataGridViewHistory.Columns["IdUser"].HeaderText = "ID User";
                if (dataGridViewHistory.Columns.Contains("StokSebelum"))
                    dataGridViewHistory.Columns["StokSebelum"].HeaderText = "Stok Sebelum";
                if (dataGridViewHistory.Columns.Contains("StokSesudah"))
                    dataGridViewHistory.Columns["StokSesudah"].HeaderText = "Stok Sesudah";
                if (dataGridViewHistory.Columns.Contains("TanggalPerubahan"))
                    dataGridViewHistory.Columns["TanggalPerubahan"].HeaderText = "Tanggal Perubahan";
                if (dataGridViewHistory.Columns.Contains("JenisPerubahan"))
                    dataGridViewHistory.Columns["JenisPerubahan"].HeaderText = "Jenis Perubahan";
                if (dataGridViewHistory.Columns.Contains("Keterangan"))
                    dataGridViewHistory.Columns["Keterangan"].HeaderText = "Keterangan";

                // Atur lebar kolom agar sesuai
                dataGridViewHistory.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat memuat data riwayat stok bahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error saat memuat data riwayat stok bahan: {ex.Message}");
            }
        }

        // Tambahkan tombol Refresh jika diperlukan
        private void btnRefreshHistory_Click(object sender, EventArgs e)
        {
            LoadHistoryData();
        }

        private void dataGridViewHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHapusHistory_Click(object sender, EventArgs e)
        {
            if (dataGridViewHistory.SelectedRows.Count > 0)
            {
                HistoryStokBahan selectedHistory = dataGridViewHistory.SelectedRows[0].DataBoundItem as HistoryStokBahan;

                if (selectedHistory != null)
                {
                    DialogResult confirm = MessageBox.Show($"Apakah Anda yakin ingin menghapus riwayat ID {selectedHistory.IdHistory} ({selectedHistory.JenisPerubahan})?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                    {
                        try
                        {
                            if (_historyRepo.Delete(selectedHistory.IdHistory))
                            {
                                MessageBox.Show("Riwayat berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadHistoryData(); 
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Gagal menghapus riwayat: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Console.WriteLine($"Error saat menghapus riwayat: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih riwayat yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}