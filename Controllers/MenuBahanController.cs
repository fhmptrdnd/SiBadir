using System;
using System.Collections.Generic;
using System.Linq;
using SiBadir.Model;
using SiBadir.Repositories;

namespace SiBadir.Controllers
{
    public class StokBahanController
    {
        private static BahanRepository repo = new();

        public static List<Bahan> GetDataStokBahan()
        {
            try
            {
                return repo.GetAll().Where(b => b.IsActive == 1).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saat mengambil data stok bahan: {ex.Message}");
                return new List<Bahan>();
            }
        }

        public static bool TambahBahan(string namaBahan, string satuanBahan, int idKategori, int stokBahan)
        {
            if (string.IsNullOrWhiteSpace(namaBahan) || string.IsNullOrWhiteSpace(satuanBahan) || idKategori <= 0)
            {
                return false;
            }

            try
            {
                Bahan newBahan = new Bahan
                {
                    NamaBahan = namaBahan.Trim(),
                    SatuanBahan = satuanBahan.Trim(),
                    IdKategori = idKategori,
                    StokBahan = stokBahan,
                    IsActive = 1
                };

                repo.Insert(newBahan);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saat menambahkan bahan: {ex.Message}");
                return false;
            }
        }

        public static bool EditBahan(Bahan bahan)
        {
            if (bahan == null || bahan.IdBahan <= 0 || string.IsNullOrWhiteSpace(bahan.NamaBahan) ||
                string.IsNullOrWhiteSpace(bahan.SatuanBahan) || bahan.IdKategori <= 0)
            {
                return false;
            }

            try
            {
                repo.Update(bahan);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saat mengedit bahan: {ex.Message}");
                return false;
            }
        }

        public static bool HapusBahan(int IdBahan)
        {
            if (IdBahan <= 0)
            {
                return false;
            }

            try
            {
                repo.Delete(IdBahan);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saat menghapus (menonaktifkan) bahan: {ex.Message}");
                return false;
            }
        }
    }
}
