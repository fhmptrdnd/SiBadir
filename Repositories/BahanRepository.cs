//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.VisualBasic.ApplicationServices;
//using SiBadir.Model;

//namespace SiBadir.Repositories
//{
//    public class BahanRepository
//    {
//        public void Insert(Bahan b)
//        {
//            DatabaseRepository.Insert("bahan",
//                new[] { "nama_bahan", "satuan_bahan", "stok_bahan", "id_kategori", "is_active" },
//                new object[] { b.NamaBahan, b.SatuanBahan, b.StokBahan, b.IdKategori, b.IsActive });
//        }

//        public void Update(Bahan b)
//        {
//            DatabaseRepository.Update("bahan",
//                new[] { "nama_bahan", "satuan_bahan", "stok_bahan", "id_kategori" },
//                new object[] { b.NamaBahan, b.SatuanBahan, b.StokBahan, b.IdKategori },
//                "id_bahan = @c0", new object[] { b.IdBahan });
//        }

//        public void Delete(int id)
//        {
//            //DatabaseRepository.Delete("bahan", "id_bahan = @c0", new object[] { id });
//            DatabaseRepository.Update("bahan",
//            new[] { "is_active" },
//            new object[] { 0 },
//                "id_bahan = @c0", new object[] { id });
//        }

//        public List<Bahan> GetAll()
//        {
//            var dt = DatabaseRepository.Select("SELECT * FROM bahan");
//            var list = new List<BahanDisplay>();

//            foreach (DataRow row in dt.Rows)
//            {
//                list.Add(new Bahan
//                {
//                    IdBahan = Convert.ToInt32(row["id_bahan"]),
//                    NamaBahan = row["nama_bahan"].ToString(),
//                    SatuanBahan = row["satuan_bahan"].ToString(),
//                    IdKategori = row.IsNull("id_kategori") ? null : (int?)Convert.ToInt32(row["id_kategori"]),
//                    IsActive = row.IsNull("is_active") ? null : (int?)Convert.ToInt32(row["is_active"]),
//                    StokBahan = Convert.ToInt32(row["stok_bahan"])
//                });
//            }

//            return list;
//        }

//        public Bahan GetById(int id)
//        {
//            var dt = DatabaseRepository.Select("SELECT * FROM bahan WHERE id_bahan = @0", new object[] { id });
//            if (dt.Rows.Count > 0)
//            {
//                DataRow row = dt.Rows[0];
//                return new Bahan
//                {
//                    IdBahan = Convert.ToInt32(row["id_bahan"]),
//                    NamaBahan = row["nama_bahan"].ToString(),
//                    SatuanBahan = row["satuan_bahan"].ToString(),
//                    IdKategori = row.IsNull("id_kategori") ? null : (int?)Convert.ToInt32(row["id_kategori"]),
//                    IsActive = row.IsNull("is_active") ? null : (int?)Convert.ToInt32(row["is_active"]),
//                    StokBahan = Convert.ToInt32(row["stok_bahan"])
//                };
//            }
//            return null; 
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using SiBadir.Model;

namespace SiBadir.Repositories
{
    public class BahanRepository
    {
        public int Insert(Bahan b) => DatabaseRepository.Insert("bahan",
                new[] { "nama_bahan", "satuan_bahan", "stok_bahan", "id_kategori", "is_active" },
                new object[] { b.NamaBahan, b.SatuanBahan, b.StokBahan, b.IdKategori, b.IsActive }, true);

        public void Update(Bahan b)
        {
            DatabaseRepository.Update("bahan",
                new[] { "nama_bahan", "satuan_bahan", "stok_bahan", "id_kategori" },
                new object[] { b.NamaBahan, b.SatuanBahan, b.StokBahan, b.IdKategori },
                "id_bahan = @0", new object[] { b.IdBahan });
        }

        public void Delete(int id)
        {
            DatabaseRepository.Update("bahan",
            new[] { "is_active" },
            new object[] { 0 },
                "id_bahan = @c0", new object[] { id });
        }

        public List<BahanDisplay> GetAllBahanDisplay()
        {
            var dt = DatabaseRepository.Select(@"
                SELECT 
                    b.id_bahan, 
                    b.nama_bahan, 
                    b.satuan_bahan, 
                    b.stok_bahan, 
                    b.id_kategori, 
                    b.is_active,
                    kb.nama_kategori
                FROM 
                    bahan b
                LEFT JOIN    
                    kategori_bahan kb ON b.id_kategori = kb.id_kategori
                WHERE 
                    b.is_active = 1
                ORDER BY b.nama_bahan ASC");

            var list = new List<BahanDisplay>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new BahanDisplay
                {
                    IdBahan = Convert.ToInt32(row["id_bahan"]),
                    NamaBahan = row["nama_bahan"].ToString(),
                    SatuanBahan = row["satuan_bahan"].ToString(),
                    StokBahan = Convert.ToInt32(row["stok_bahan"]),
                    IdKategori = row.IsNull("id_kategori") ? null : (int?)Convert.ToInt32(row["id_kategori"]),
                    IsActive = row.IsNull("is_active") ? null : (int?)Convert.ToInt32(row["is_active"]),
                    NamaKategori = row.IsNull("nama_kategori") ? "Tidak Ada Kategori" : row["nama_kategori"].ToString()
                });
            }

            return list;
        }

        // Metode ini tetap ada untuk mengambil objek Bahan tunggal tanpa informasi kategori
        public Bahan GetById(int id)
        {
            var dt = DatabaseRepository.Select("SELECT * FROM bahan WHERE id_bahan = @0", new object[] { id });
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new Bahan
                {
                    IdBahan = Convert.ToInt32(row["id_bahan"]),
                    NamaBahan = row["nama_bahan"].ToString(),
                    SatuanBahan = row["satuan_bahan"].ToString(),
                    IdKategori = row.IsNull("id_kategori") ? null : (int?)Convert.ToInt32(row["id_kategori"]),
                    IsActive = row.IsNull("is_active") ? null : (int?)Convert.ToInt32(row["is_active"]),
                    StokBahan = Convert.ToInt32(row["stok_bahan"])
                };
            }
            return null;
        }
    }
}
