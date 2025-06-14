using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiBadir.Controllers;

namespace SiBadir.Views.Components
{
    public partial class FormNotifikasi : Form
    {
        BindingSource binding = new BindingSource();
        private void LoadData()
        {
            binding.DataSource = NotifikasiController.GetAll();
            DaftarNotifikasi.AutoGenerateColumns = false;
            DaftarNotifikasi.DataSource = binding;
        }
        public FormNotifikasi()
        {
            InitializeComponent();
            NotifikasiController.cekNotifikasi(reminderLabel);
            LoadData();
            NotifikasiController.BacaNotifikasi();
        }
    }
}
