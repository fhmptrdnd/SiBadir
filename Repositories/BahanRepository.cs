using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using SiBadir.Model;

namespace SiBadir.Repositories
{
    public class BahanRepository
    {
        public void Insert(Bahan b)
        {
            DatabaseRepository.Insert("bahan",
                new[] { "nama_bahan", "satuan_bahan", "stok_bahan", "id_kategori", "is_active" },
                new object[] { b.NamaBahan, b.SatuanBahan, b.StokBahan, b.IdKategori, b.IsActive });
        }

        public void Update(Bahan b)
        {
            DatabaseRepository.Update("bahan",
                new[] { "nama_bahan", "satuan_bahan", "stok_bahan", "id_kategori" },
                new object[] { b.NamaBahan, b.SatuanBahan, b.StokBahan, b.IdKategori },
                "id_bahan = @c0", new object[] { b.IdBahan });
        }

        public void Delete(int id)
        {
            //DatabaseRepository.Delete("bahan", "id_bahan = @c0", new object[] { id });
            DatabaseRepository.Update("bahan",
            new[] { "is_active" },
            new object[] { 0 },
                "id_user = @c0", new object[] { id });
        }

        public List<Bahan> GetAll()
        {
            var dt = DatabaseRepository.Select("SELECT * FROM bahan");
            var list = new List<Bahan>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Bahan
                {
                    IdBahan = Convert.ToInt32(row["id_bahan"]),
                    NamaBahan = row["nama_bahan"].ToString(),
                    SatuanBahan = row["satuan_bahan"].ToString(),
                    IdKategori = row.IsNull("id_kategori") ? null : (int?)Convert.ToInt32(row["id_kategori"]),
                    IsActive = row.IsNull("is_active") ? null : (int?)Convert.ToInt32(row["is_active"]),
                    StokBahan = Convert.ToInt32(row["stok_bahan"])
                });
            }

            return list;
        }
    }
}
