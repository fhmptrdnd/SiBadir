﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SiBadir.Interfaces;
using SiBadir.Model;

namespace SiBadir.Repositories
{
    internal class HistoryRepository : IHistoryRepository
    {
        internal IHistoryRepository IHistoryRepository
        {
            get => default;
            set
            {
            }
        }

        public HistoryStokBahan HistoryStokBahan
        {
            get => default;
            set
            {
            }
        }

        public HistoryStokBahan RowToHistory(DataRow row)
        {
            return new HistoryStokBahan
            {
                IdHistory = Convert.ToInt32(row["ID History"]),
                IdBahan = Convert.ToInt32(row["ID Bahan"]),
                IdUser = Convert.ToInt32(row["ID User"]),
                TanggalPerubahan = Convert.ToDateTime(row["Tanggal Perubahan"]),
                NamaBahan = row["Nama Bahan"]?.ToString() ?? "Data Bahan Hilang",
                JenisPerubahan = row["Jenis Perubahan"]?.ToString() ?? "",
                StokSebelum = Convert.ToInt32(row["Stok Sebelum"]),
                StokSesudah = Convert.ToInt32(row["Stok Sesudah"]),
                NamaUser = row["User"]?.ToString() ?? "User Tidak Diketahui",
                Keterangan = row["Keterangan"]?.ToString() ?? ""
            };
        }
        public List<HistoryStokBahan> GetAll(string? nama_bahan = null, DateTime? tanggal_perubahan = null, string? nama_kategori = null, string? jenis_perubahan = null, string? nama_user = null)
        {
            string query = """
            SELECT
                h.id_history AS "ID History",
                h.id_bahan AS "ID Bahan",
                h.id_user AS "ID User",
                h.tanggal_perubahan AS "Tanggal Perubahan",
                b.nama_bahan AS "Nama Bahan",
                h.jenis_perubahan AS "Jenis Perubahan",
                h.stok_sebelum AS "Stok Sebelum",
                h.stok_sesudah AS "Stok Sesudah",
                u.nama_user AS "User",
                h.keterangan AS "Keterangan"
            FROM History_Stok_Bahan h
            JOIN bahan b ON h.id_bahan = b.id_bahan
            LEFT JOIN kategori_bahan k ON b.id_kategori = k.id_kategori
            LEFT JOIN pengguna u ON h.id_user = u.id_user
            """;

            var conditions = new List<string>();
            var parameterValues = new List<object>();

            if (!string.IsNullOrWhiteSpace(nama_bahan))
            {
                conditions.Add($"b.nama_bahan ILIKE @p{parameterValues.Count}");
                parameterValues.Add($"%{nama_bahan}%");
            }

            if (tanggal_perubahan.HasValue)
            {
                conditions.Add($"h.tanggal_perubahan = @p{parameterValues.Count}");
                parameterValues.Add(tanggal_perubahan.Value.Date);
            }

            if (!string.IsNullOrWhiteSpace(nama_kategori))
            {
                conditions.Add($"k.nama_kategori = @p{parameterValues.Count}");
                parameterValues.Add(nama_kategori);
            }

            if (!string.IsNullOrWhiteSpace(jenis_perubahan))
            {
                conditions.Add($"h.jenis_perubahan = @p{parameterValues.Count}");
                parameterValues.Add(jenis_perubahan);
            }

            if (!string.IsNullOrWhiteSpace(nama_user))
            {
                conditions.Add($"u.nama_user ILIKE @p{parameterValues.Count}");
                parameterValues.Add($"%{nama_user}%");
            }

            if (conditions.Count > 0)
            {
                query += " WHERE " + string.Join(" AND ", conditions);
            }

            query += " ORDER BY h.tanggal_perubahan DESC, h.id_history DESC";
            //MessageBox.Show($"{parameterValues} {nama_bahan}", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var dt = DatabaseRepository.Select(query, parameterValues.ToArray());

            var list = new List<HistoryStokBahan>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(RowToHistory(row));
            }
            return list;
        }
        public void Insert(HistoryStokBahan history)
        {
            var columns = new List<string> { "id_bahan", "id_user", "stok_sebelum", "stok_sesudah", "jenis_perubahan", "keterangan" };
            var values = new List<object> {
                history.IdBahan.HasValue ? (object)history.IdBahan.Value : DBNull.Value,
                history.IdUser.HasValue ? (object)history.IdUser.Value : DBNull.Value,
                history.StokSebelum.HasValue ? (object)history.StokSebelum.Value : DBNull.Value,
                history.StokSesudah.HasValue ? (object)history.StokSesudah.Value : DBNull.Value,
                history.JenisPerubahan,
                history.Keterangan
            };

            DatabaseRepository.Insert("history_stok_bahan",
                columns.ToArray(),
                values.ToArray());
        }
    }
}
