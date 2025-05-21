using Npgsql;
using SiBadir.Model;

namespace SiBadir
{
    public partial class Form1 : Form
    {
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
                // ini buat cek error atau ngga aja, valid atau ngganya usn/pswrd, bisa dicomment
                MessageBox.Show($"Username: '{usernameInput}'\nPassword: '{passwordInput}'");

                DatabaseConnectionUser login = new DatabaseConnectionUser(usernameInput, passwordInput);
                login.openConnection();
                NpgsqlDataReader reader = login.execQuery();

                if (reader.Read())
                {
                    string namaUser = reader["nama_User"].ToString() ?? "";
                    string role = reader["role"].ToString() ?? "";

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
                login.closeConnection();
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
