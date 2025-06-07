using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiBadir
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }
        private void BtnKeluar_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Lht_Stok_Bahan_Click(object sender, EventArgs e)
        {

        }

        private void bt_Daftar_Karyawan_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu form2 = new MainMenu();
            form2.FormClosed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
