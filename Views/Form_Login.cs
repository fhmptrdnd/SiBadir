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

        public Pengguna Pengguna
        {
            get => default;
            set
            {
            }
        }

        public Form_Menu Form_Menu
        {
            get => default;
            set
            {
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
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
                PenggunaRepository penggunaRepo = new PenggunaRepository();
                Pengguna akun = penggunaRepo.GetByUsernameAndPassword(usernameInput, passwordInput);

                if (akun != null)
                {
                    User.UserLoggedIn = akun;
                    this.Hide();
                    Form_Menu form2 = new Form_Menu();
                    form2.FormClosed += (s, args) => this.Close(); // Tutup aplikasi jika Form2 ditutup
                    form2.Show();
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

      
    }
}
