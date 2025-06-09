//using System;
//using System.Data;
//using System.Linq;
//using Npgsql;

//public class DbNjedir
//{
//    private readonly string _connectionString = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=Si_Badir_New";


//    public void Insert(string namaTable, string[] columns, object[] values)
//    {
//        if (columns.Length != values.Length)
//            throw new ArgumentException("Jumlah kolom dan nilai tidak sama.");

//        string columnList = string.Join(", ", columns);
//        string paramList = string.Join(", ", columns.Select((_, i) => $"@p{i}"));
//        string query = $"INSERT INTO {namaTable} ({columnList}) VALUES ({paramList})";

//        using (var conn = new NpgsqlConnection(_connectionString))
//        using (var cmd = new NpgsqlCommand(query, conn))
//        {
//            for (int i = 0; i < values.Length; i++)
//            {
//                cmd.Parameters.AddWithValue($"@p{i}", values[i] ?? DBNull.Value);
//            }

//            conn.Open();
//            cmd.ExecuteNonQuery();
//        }
//    }

//    public DataTable Select(string query, object[] parameters = null)
//    {
//        using (var conn = new NpgsqlConnection(_connectionString))
//        using (var cmd = new NpgsqlCommand(query, conn))
//        {
//            if (parameters != null)
//            {
//                for (int i = 0; i < parameters.Length; i++)
//                {
//                    cmd.Parameters.AddWithValue($"@p{i}", parameters[i] ?? DBNull.Value);
//                }
//            }

//            using (var adapter = new NpgsqlDataAdapter(cmd))
//            {
//                var dt = new DataTable();
//                adapter.Fill(dt);
//                return dt;
//            }
//        }
//    }

//    public void Update(string tableName, string[] columns, object[] values, string condition, object[] conditionParams)
//    {
//        if (columns.Length != values.Length)
//            throw new ArgumentException("Jumlah kolom dan nilai tidak sama.");

//        string setClause = string.Join(", ", columns.Select((col, i) => $"{col} = @p{i}"));
//        string query = $"UPDATE {tableName} SET {setClause} WHERE {condition}";

//        using (var conn = new NpgsqlConnection(_connectionString))
//        using (var cmd = new NpgsqlCommand(query, conn))
//        {
//            for (int i = 0; i < values.Length; i++)
//            {
//                cmd.Parameters.AddWithValue($"@p{i}", values[i] ?? DBNull.Value);
//            }

//            if (conditionParams != null)
//            {
//                for (int i = 0; i < conditionParams.Length; i++)
//                {
//                    cmd.Parameters.AddWithValue($"@c{i}", conditionParams[i] ?? DBNull.Value);
//                }
//            }

//            conn.Open();
//            cmd.ExecuteNonQuery();
//        }
//    }

//    public void Delete(string tableName, string condition, object[] conditionParams)
//    {
//        string query = $"DELETE FROM {tableName} WHERE {condition}";

//        using (var conn = new NpgsqlConnection(_connectionString))
//        using (var cmd = new NpgsqlCommand(query, conn))
//        {
//            if (conditionParams != null)
//            {
//                for (int i = 0; i < conditionParams.Length; i++)
//                {
//                    cmd.Parameters.AddWithValue($"@c{i}", conditionParams[i] ?? DBNull.Value);
//                }
//            }

//            conn.Open();
//            cmd.ExecuteNonQuery();
//        }
//    }
//}



////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;
////using Npgsql;

////namespace SiBadir.Model
////{
////    class DatabaseConnection
////    {
////        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=postgres;Database=BaksoNjedir";
////        protected NpgsqlConnection conn;

////        public DatabaseConnection()
////        {
////            conn = new NpgsqlConnection(connectionString);
////        }
////        public void openConnection ()
////        {
////            conn.Open();
////        }
////        public void closeConnection()
////        {
////            conn.Close();
////        }
////    }

////    public interface IUserRepository
////    {
////        NpgsqlDataReader GetUser(string username, string password);
////    }

////    class DatabaseConnectionUser : DatabaseConnection, IUserRepository
////    {
////        private string query = @"SELECT nama_User, role 
////                             FROM pengguna 
////                             WHERE LOWER(username) = @username 
////                             AND password = @password";

////        public NpgsqlDataReader GetUser(string username, string password)
////        {
////            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
////            cmd.Parameters.AddWithValue("@username", username.ToLower());
////            cmd.Parameters.AddWithValue("@password", password);

////            return cmd.ExecuteReader();
////        }
////    }

////    //class DatabaseConnectionUser : DatabaseConnection, IUserRepository
////    //{
////    //    private string query = @"SELECT p.nama_User, p.role 
////    //                       FROM user_login ul 
////    //                       JOIN pengguna p USING (id_User) 
////    //                       WHERE LOWER(ul.username) = @username 
////    //                       AND ul.password = @password";
////    //    private string username;
////    //    private string password;

////    //    public DatabaseConnectionUser(string username, string password)
////    //    {
////    //        this.username = username;
////    //        this.password = password;
////    //    }

////    //    public NpgsqlDataReader execQuery()
////    //    {
////    //        using (NpgsqlCommand cmd = new NpgsqlCommand(query, this.conn))
////    //        {
////    //            cmd.Parameters.AddWithValue("@username", username.ToLower());
////    //            cmd.Parameters.AddWithValue("@password", password);

////    //            NpgsqlDataReader reader = cmd.ExecuteReader();
////    //            return reader;
////    //        }
////    //    }
////}
////}