using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace SiBadir.Repositories
{
    public static class DatabaseRepository
    {
        private static readonly string _connectionString = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=BaksoNjedir";


        public static int Insert(string namaTable, string[] columns, object[] values, bool return_id = false)
        {
            if (columns.Length != values.Length)
                throw new ArgumentException("Jumlah kolom dan nilai tidak sama.");

            string columnList = string.Join(", ", columns);
            string paramList = string.Join(", ", columns.Select((_, i) => $"@p{i}"));
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
                    cmd.Parameters.AddWithValue($"@p{i}", values[i] ?? DBNull.Value);
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
                    return rowsAffected; // Kembalikan jumlah baris, 1 jika sukses
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
                        cmd.Parameters.AddWithValue($"@p{i}", parameters[i] ?? DBNull.Value);
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

            string setClause = string.Join(", ", columns.Select((col, i) => $"{col} = @p{i}"));
            string query = $"UPDATE {tableName} SET {setClause} WHERE {condition}";

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
                            for (int i = 0; i < values.Length; i++)
                            {
                                cmd.Parameters.AddWithValue($"@p{i}", values[i] ?? DBNull.Value);
                            }

                            if (conditionParams != null)
                            {
                                for (int i = 0; i < conditionParams.Length; i++)
                                {
                                    cmd.Parameters.AddWithValue($"@c{i}", conditionParams[i] ?? DBNull.Value);
                                }
                            }

                            cmd.ExecuteNonQuery();
                            transaksi.Commit();
                            return true;
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR & ROLLBACK: Gagal update tabel {tableName}. Pesan: {ex.Message}");
                return false;
            }
        }

        public static void Delete(string tableName, string condition, object[] conditionParams)
        {
            string query = $"DELETE FROM {tableName} WHERE {condition}";

            using (var conn = new NpgsqlConnection(_connectionString))
            using (var cmd = new NpgsqlCommand(query, conn))
            {
                if (conditionParams != null)
                {
                    for (int i = 0; i < conditionParams.Length; i++)
                    {
                        cmd.Parameters.AddWithValue($"@c{i}", conditionParams[i] ?? DBNull.Value);
                    }
                }

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
