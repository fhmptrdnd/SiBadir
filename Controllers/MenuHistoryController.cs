using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiBadir.Model;
using SiBadir.Repositories;

namespace SiBadir.Controllers
{
    public class MenuHistoryController
    {
        private static HistoryRepository repo = new();
        public static List<HistoryStokBahan> GetDataHistory(string? nama_bahan = null, DateTime? tanggal_perubahan = null, string? nama_kategori = null, string? jenis_perubahan = null, string? nama_user = null)
        {
            var clean_nama_bahan = string.IsNullOrWhiteSpace(nama_bahan) ? null : nama_bahan;
            var clean_nama_kategori = string.IsNullOrWhiteSpace(nama_kategori) ? null : nama_kategori;
            var clean_jenis_perubahan = jenis_perubahan;
            if (string.IsNullOrWhiteSpace(jenis_perubahan) || jenis_perubahan == "Semua")
            {
                clean_jenis_perubahan = null;
            }
            if (string.IsNullOrWhiteSpace(nama_kategori) || nama_kategori == "Semua")
            {
                clean_nama_kategori = null;
            }
            var clean_nama_user = string.IsNullOrWhiteSpace(nama_user) ? null : nama_user;

            List<HistoryStokBahan> data = repo.GetAll(
                clean_nama_bahan,
                tanggal_perubahan,
                clean_nama_kategori,
                clean_jenis_perubahan,
                clean_nama_user
            );

            return data;
        }
        public static List<string> getListKategori()
        {
            KategoriRepository kategoriRepo = new();
            return kategoriRepo.GetNamaKategori();
        }
    }
}
