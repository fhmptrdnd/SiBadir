
using SiBadir.Controllers;
using SiBadir.Model;

namespace SiBadir.Views.Components
{
    public partial class BaseMenuHistory : Form
    {
        private void ResetFilter()
        {
            SearchNamaBahan.Text = "";
            SearchNamaUser.Text = "";
            if (SearchKategori.Items.Count > 0)
            {
                SearchKategori.SelectedIndex = 0;
            }
            if (SearchJenisPerubahan.Items.Count > 0)
            {
                SearchJenisPerubahan.SelectedIndex = 0;
            }
            SearchTanggal.Checked = false;
        }
        public BaseMenuHistory()
        {
            InitializeComponent();
            SearchKategori.Items.Clear();
            SearchKategori.Items.Add("Semua");
            SearchKategori.Items.AddRange(MenuHistoryController.getListKategori().ToArray());
            SearchKategori.SelectedIndex = 0;
        }

        public event Action<List<HistoryStokBahan>>? SearchCompleted;

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            DateTime? tanggalFilter = null;

            if (SearchTanggal.Checked)
            {
                tanggalFilter = SearchTanggal.Value;
            }
            string namaBahan = SearchNamaBahan.Text;
            string namaUser = SearchNamaUser.Text;
            DateTime? tanggal = tanggalFilter;
            string kategori = SearchKategori.SelectedItem?.ToString();
            string jenisPerubahan = SearchJenisPerubahan.SelectedItem?.ToString();
            List<HistoryStokBahan> data = MenuHistoryController.GetDataHistory(namaBahan, tanggal, kategori, jenisPerubahan, namaUser);
            SearchCompleted?.Invoke(data);
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ResetFilter();
            List<HistoryStokBahan> data = MenuHistoryController.GetDataHistory();
            SearchCompleted?.Invoke(data);
        }
    }
}
