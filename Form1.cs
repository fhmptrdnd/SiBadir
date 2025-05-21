using Npgsql;

namespace SiBadir
{
    public partial class Form1 : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=d1naraFahmi;Database=Si_Badir";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usernameInput = textBox2.Text.Trim().ToLower();
            string passwordInput = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(usernameInput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Username dan password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    // Query
                    string query = @"
                        select p.nama_User, p.role 
                        from user_login ul
                        join Pengguna p using (id_User)
                        WHERE LOWER(ul.username) = @username AND ul.password = @password";


                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {

                        cmd.Parameters.Add(new NpgsqlParameter("@username", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = usernameInput });
                        cmd.Parameters.Add(new NpgsqlParameter("@password", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = passwordInput });

                        // ini buat cek error atau ngga aja, valid atau ngganya usn/pswrd, bisa dicomment
                        MessageBox.Show($"Username: '{usernameInput}'\nPassword: '{passwordInput}'");

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string namaUser = reader["nama_User"].ToString();
                                string role = reader["role"].ToString();

                                if (role == "admin")
                                {
                                    label1.Text = "Halo Admin!";
                                }
                                else if (role == "karyawan")
                                {
                                    label1.Text = $"Halo {namaUser}!";
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username atau password salah!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
