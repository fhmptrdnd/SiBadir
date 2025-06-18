using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiBadir.Controller;
using SiBadir.Controllers;
using SiBadir.Model;

namespace SiBadir.Views.Components
{
    public partial class FormHistoryStok : Form
    {
        BindingSource binding = new BindingSource();
        private void LoadData()
        {
            binding.DataSource = MenuHistoryController.GetDataHistory();
            DataHistory.AutoGenerateColumns = false;
            DataHistory.DataSource = binding;
        }

        public FormHistoryStok()
        {
            InitializeComponent();
            LoadData();
            BaseMenuHistory menuForm = new();
            menuForm.SearchCompleted += HandleSearchCompleted;
            FormController.LoadFormInPanel(this.MenuPanel, menuForm);
        }
        private void HandleSearchCompleted(List<HistoryStokBahan> dataHasilPencarian)
        {
            binding.DataSource = dataHasilPencarian;
            binding.ResetBindings(false);
        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public FormController FormController
        {
            get => default;
            set
            {
            }
        }

        public MenuHistoryController MenuHistoryController
        {
            get => default;
            set
            {
            }
        }

        public HistoryStokBahan HistoryStokBahan
        {
            get => default;
            set
            {
            }
        }
    }
}
