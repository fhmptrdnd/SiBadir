using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiBadir.Model;

namespace SiBadir.Repositories
{
    internal class KategoriRepository : Interfaces.IKategoriRepository
    {
        public List<string> GetNamaKategori()
        {
            var dt = DatabaseRepository.Select("SELECT * FROM kategori_bahan");
            var list = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(row["nama_kategori"].ToString() ?? "");
            }

            return list;
        }
    }
}
