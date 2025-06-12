
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Npgsql;

namespace SiBadir.Repositories
{
    public static class DatabaseRepository
    {
        private static readonly string _connectionString = "Host=localhost;Port=5432;Username=postgres;Password=d1naraFahmi;Database=Si_Badir_New";

        public static int Insert(string namaTable, string[] columns, object[] values, bool return_id = false)
        {
            if (columns.Length != values.Length)
                throw new ArgumentException("Jumlah kolom dan nilai tidak sama.");

            string columnList = string.Join(", ", columns);
            string paramList = string.Join(", ", columns.Select((col, i) => $"@{i}"));
            string query = $"INSERT INTO {namaTable} ({columnList}) VALUES ({paramList})";

            if (return_id)
            {
                if (namaTable == "pengguna")
                {
                    query += $" RETURNING id_user";
                }
                else
                {
                    query += $" RETURNING id_{namaTable.ToLower()}";
                }
            }

            using (var conn = new NpgsqlConnection(_connectionString))
            using (var cmd = new NpgsqlCommand(query, conn))
            {
                for (int i = 0; i < values.Length; i++)
                {
                    cmd.Parameters.AddWithValue($"@{i}", values[i] ?? DBNull.Value);
                }

                conn.Open();
                if (return_id)
                {
                    object newId = cmd.ExecuteScalar();
                    return newId != null ? Convert.ToInt32(newId) : 0;
                }
                else
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
        }

        public static DataTable Select(string query, object[] parameters = null)
        {
            using (var conn = new NpgsqlConnection(_connectionString))
            using (var cmd = new NpgsqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        cmd.Parameters.AddWithValue($"@{i}", parameters[i] ?? DBNull.Value);
                    }
                }

                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public static bool Update(string tableName, string[] columns, object[] values, string condition, object[] conditionParams)
        {
            if (columns.Length != values.Length)
                throw new ArgumentException("Jumlah kolom dan nilai tidak sama.");

            // Gunakan nama parameter yang unik untuk SET clause
            string setClause = string.Join(", ", columns.Select((col, i) => $"{col} = @p_set_{i}"));

            string finalCondition = condition;
            List<NpgsqlParameter> allParameters = new List<NpgsqlParameter>();

            // Tambahkan parameter untuk SET clause
            for (int i = 0; i < values.Length; i++)
            {
                allParameters.Add(new NpgsqlParameter($"@p_set_{i}", values[i] ?? DBNull.Value));
            }

            // Tambahkan parameter untuk WHERE clause
            if (conditionParams != null)
            {
                for (int i = 0; i < conditionParams.Length; i++)
                {
                    // Pastikan placeholder di 'condition' adalah @0, @1, dst.
                    // dan ganti dengan nama parameter yang unik untuk WHERE
                    string oldParamPlaceholder = $"@{i}"; // Menggunakan @{i} karena BahanRepo.Update mengirim "id_bahan = @0"
                    string newParamName = $"@p_where_{i}";
                    finalCondition = finalCondition.Replace(oldParamPlaceholder, newParamName);
                    allParameters.Add(new NpgsqlParameter(newParamName, conditionParams[i] ?? DBNull.Value));
                }
            }

            string query = $"UPDATE {tableName} SET {setClause} WHERE {finalCondition}";

            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    using (var transaksi = conn.BeginTransaction())
                    {
                        using (var cmd = new NpgsqlCommand(query, conn))
                        {
                            cmd.Transaction = transaksi;
                            cmd.Parameters.AddRange(allParameters.ToArray());

                            int rowsAffected = cmd.ExecuteNonQuery(); // Tangkap jumlah baris yang terpengaruh
                            transaksi.Commit();
                            return rowsAffected > 0; // Mengembalikan true hanya jika ada baris yang diupdate
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR & ROLLBACK: Gagal update tabel {tableName}. Pesan: {ex.Message}");
                // Penting: Melempar exception agar controller dapat menangkapnya
                throw;
            }
        }

        public static bool Delete(string tableName, string condition, object[] conditionParams)
        {
            // Jika ini digunakan untuk logical delete (misalnya bahan), maka akan memanggil Update
            // Parameter 'condition' harus menggunakan '@0', '@1', dst. (misalnya "id_bahan = @0")
            if (tableName == "bahan" && condition.StartsWith("id_bahan = @0"))
            {
                // Memanggil metode Update yang sama
                return Update(tableName, new[] { "is_active" }, new object[] { 0 }, condition, conditionParams);
            }
            else // Ini adalah logika DELETE fisik
            {
                string query = $"DELETE FROM {tableName} WHERE {condition}";

                using (var conn = new NpgsqlConnection(_connectionString))
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    if (conditionParams != null)
                    {
                        for (int i = 0; i < conditionParams.Length; i++)
                        {
                            cmd.Parameters.AddWithValue($"@{i}", conditionParams[i] ?? DBNull.Value);
                        }
                    }

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0; // Mengembalikan true jika ada baris yang dihapus
                }
            }
        }
    }
}
