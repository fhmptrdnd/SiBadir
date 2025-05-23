using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace SiBadir.Model
{
    class DatabaseConnection
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=d1naraFahmi;Database=Si_Badir";
        protected NpgsqlConnection conn;

        public DatabaseConnection()
        {
            conn = new NpgsqlConnection(connectionString);
        }
        public void openConnection ()
        {
            conn.Open();
        }
        public void closeConnection()
        {
            conn.Close();
        }
    }

    public interface IUserRepository
    {
        NpgsqlDataReader GetUser(string username, string password);
    }

    class DatabaseConnectionUser : DatabaseConnection, IUserRepository
    {
        private string query = @"SELECT p.nama_User, p.role 
                             FROM user_login ul 
                             JOIN pengguna p USING (id_User) 
                             WHERE LOWER(ul.username) = @username 
                             AND ul.password = @password";

        public NpgsqlDataReader GetUser(string username, string password)
        {
            openConnection();

            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username.ToLower());
            cmd.Parameters.AddWithValue("@password", password);

            return cmd.ExecuteReader(); // Jangan closeConnection() karena reader masih aktif
        }
    }

    //class DatabaseConnectionUser : DatabaseConnection, IUserRepository
    //{
    //    private string query = @"SELECT p.nama_User, p.role 
    //                       FROM user_login ul 
    //                       JOIN pengguna p USING (id_User) 
    //                       WHERE LOWER(ul.username) = @username 
    //                       AND ul.password = @password";
    //    private string username;
    //    private string password;

    //    public DatabaseConnectionUser(string username, string password)
    //    {
    //        this.username = username;
    //        this.password = password;
    //    }

    //    public NpgsqlDataReader execQuery()
    //    {
    //        using (NpgsqlCommand cmd = new NpgsqlCommand(query, this.conn))
    //        {
    //            cmd.Parameters.AddWithValue("@username", username.ToLower());
    //            cmd.Parameters.AddWithValue("@password", password);

    //            NpgsqlDataReader reader = cmd.ExecuteReader();
    //            return reader;
    //        }
    //    }
    //}
}
