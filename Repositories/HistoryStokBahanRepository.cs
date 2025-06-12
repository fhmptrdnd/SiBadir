using SiBadir.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq; 

namespace SiBadir.Repositories
{
    public class HistoryStokBahanRepository
    {
        public void Insert(HistoryStokBahan history)
        {
            DatabaseRepository.Insert("history_stok_bahan",
                new[] { "id_bahan", "id_user", "stok_sebelum", "stok_sesudah", "jenis_perubahan", "keterangan" },
                new object[] {
                    history.IdBahan,
                    history.IdUser,
                    history.StokSebelum,
                    history.StokSesudah,
                    history.JenisPerubahan,
                    history.Keterangan
                });
        }
        //public void Insert(HistoryStokBahan history)
        //{
        //    // Daftar kolom yang akan di-insert, tidak termasuk tanggal_perubahan
        //    var columns = new List<string> { "id_bahan", "id_user", "stok_sebelum", "stok_sesudah", "jenis_perubahan", "keterangan" };
        //    // Daftar nilai yang akan di-insert
        //    var values = new List<object> {
        //        history.IdBahan.HasValue ? (object)history.IdBahan.Value : DBNull.Value,
        //        history.IdUser.HasValue ? (object)history.IdUser.Value : DBNull.Value,
        //        history.StokSebelum.HasValue ? (object)history.StokSebelum.Value : DBNull.Value,
        //        history.StokSesudah.HasValue ? (object)history.StokSesudah.Value : DBNull.Value,
        //        history.JenisPerubahan,
        //        history.Keterangan
        //    };

        //    DatabaseRepository.Insert("history_stok_bahan",
        //        columns.ToArray(),
        //        values.ToArray());
        //}

        public List<HistoryStokBahan> GetAll()
        {
            var dt = DatabaseRepository.Select("SELECT * FROM history_stok_bahan ORDER BY tanggal_perubahan DESC, id_history DESC");
            var list = new List<HistoryStokBahan>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new HistoryStokBahan
                {
                    IdHistory = Convert.ToInt32(row["id_history"]),
                    IdBahan = row.IsNull("id_bahan") ? null : (int?)Convert.ToInt32(row["id_bahan"]),
                    IdUser = row.IsNull("id_user") ? null : (int?)Convert.ToInt32(row["id_user"]),
                    StokSebelum = row.IsNull("stok_sebelum") ? null : (int?)Convert.ToInt32(row["stok_sebelum"]),
                    StokSesudah = row.IsNull("stok_sesudah") ? null : (int?)Convert.ToInt32(row["stok_sesudah"]),
                    TanggalPerubahan = row.IsNull("tanggal_perubahan") ? null : (DateTime?)Convert.ToDateTime(row["tanggal_perubahan"]),
                    JenisPerubahan = row["jenis_perubahan"].ToString(),
                    Keterangan = row["keterangan"].ToString()
                });
            }
            return list;
        }

        public bool Delete(int idHistory)
        {
            try
            {
                DatabaseRepository.Delete("history_stok_bahan", "id_history = @0", new object[] { idHistory });
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saat menghapus history stok bahan: {ex.Message}");
                throw new Exception($"Gagal menghapus history: {ex.Message}");
            }
        }
    }
}
