using Npgsql;
using SiBadir.Model;
using SiBadir.Repositories;
using System.Windows.Forms;

namespace SiBadir
{
    public partial class Form_Login : Form
    {
        public Form_Login()
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
                // ini buat cek error atau ngga aja, valid atau ngganya usn/pswrd yg diinpput, bisa dicomment
                //MessageBox.Show($"Username: '{usernameInput}'\nPassword: '{passwordInput}'");

                //DatabaseConnectionUser login = new DatabaseConnectionUser(usernameInput, passwordInput);
                //login.openConnection();
                //NpgsqlDataReader reader = login.execQuery();

                PenggunaRepository penggunaRepo = new PenggunaRepository();
                Pengguna akun = penggunaRepo.GetByUsernameAndPassword(usernameInput, passwordInput);

                if (akun != null)
                {
                    User.UserLoggedIn = akun;

                    if (akun.Role == "admin")
                    {
                        label1.Text = "Halo Admin!";
                        // Sembunyikan Form1 dan tampilkan Form2
                        this.Hide();
                        Form_Menu form2 = new Form_Menu();
                        //form2.LoggedInUsername = akun.NamaUser;
                        form2.FormClosed += (s, args) => this.Close(); // Tutup aplikasi jika Form2 ditutup
                        form2.Show();
                    }
                    else if (akun.Role == "karyawan")
                    {
                        label1.Text = $"Halo {akun.NamaUser}!";
                    }
                }
                else
                {
                    MessageBox.Show("Username atau password salah!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
