using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using SiBadir.Interfaces;
using SiBadir.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SiBadir.Repositories
{
    public class NotifikasiRepository : INotifikasiRepository
    {
        public List<NotifikasiStok> GetAll(int id_pengguna)
        {
            string query = """
                            SELECT
                                ns.*,
                                CASE
                                    WHEN ns.is_read = 0 THEN '** Stok ' || b.nama_bahan || ' sudah dibawah 10 ' || b.satuan_bahan || '!!'
                                    WHEN ns.is_read = 1 THEN 'Stok ' || b.nama_bahan || ' sudah dibawah 10 ' || b.satuan_bahan || '!!'
                                END AS Pesan
                            FROM
                                notifikasi_stok ns
                            JOIN
                                bahan b USING(id_bahan)
                            WHERE
                                ns.id_penerima = @p0
                            ORDER BY
                                ns.is_read ASC,
                                ns.tanggal_notifikasi DESC
                        """;
            var dt = DatabaseRepository.Select(query, new object[] { id_pengguna });
            var list = new List<NotifikasiStok>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(RowToNotifikasi(row));
            }

            return list;
        }

        public int cekNotifikasi(int id_pengguna)
        {
            var dt = DatabaseRepository.Select("SELECT COUNT(*) FROM notifikasi_stok WHERE id_penerima = @p0 AND is_read = 0", new object[] { id_pengguna });
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0][0]);
            }
            return 0;
        }

        public NotifikasiStok RowToNotifikasi(DataRow row)
        {
            return new NotifikasiStok
            {
                IdNotifikasi = Convert.ToInt32(row["id_notifikasi"]),
                IdBahan = Convert.ToInt32(row["id_bahan"]),
                //NamaBahan = row["Nama Bahan"].ToString(),
                //NamaPenerima = row["Nama Penerima"].ToString(),
                Pesan = row["Pesan"].ToString(),
                IdPenerima = row.IsNull("id_penerima") ? null : (int?)Convert.ToInt32(row["id_penerima"]),
                IsRead = row.IsNull("is_read") ? null : (int?)Convert.ToInt32(row["is_read"]),
                TanggalNotifikasi = row.IsNull("tanggal_notifikasi") ? DateTime.MinValue : Convert.ToDateTime(row["tanggal_notifikasi"])
            };
        }
        public void BacaNotifikasi(int id_pengguna)
        {
            DatabaseRepository.Update("notifikasi_stok",
            new[] { "is_read" },
            new object[] { 1 },
                "id_penerima = @c0 AND is_read = 0", new object[] { id_pengguna });
        }
        public void insertNotifikasi(NotifikasiStok notifikasi)
        {
            DatabaseRepository.Insert("notifikasi_stok",
                new[] { "id_bahan"},
                new object[] { notifikasi.IdBahan }, false, true);
        }
    }
}
