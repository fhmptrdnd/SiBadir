using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiBadir.Model;
using SiBadir.Repositories;

namespace SiBadir.Controllers
{
    public class MenuKaryawanController
    {
        private static PenggunaRepository repo = new();

        public Pengguna Pengguna
        {
            get => default;
            set
            {
            }
        }

        public static List<Pengguna> GetDataKaryawan()
        {
            List<Pengguna> data = repo.GetAll();
            return data;
        }

        public static bool TambahKaryawan(string nama_karyawan, string alamat_karyawan)
        {
            if (string.IsNullOrEmpty(nama_karyawan) || string.IsNullOrEmpty(alamat_karyawan))
            {
                return false;
            }
            string[] nama_lengkap = nama_karyawan.Split(' ');
            string nama_depan = nama_lengkap[0];
            Pengguna karyawan = new Pengguna
            {
                NamaUser = nama_karyawan.Trim(),
                AlamatUser = alamat_karyawan.Trim(),
                Role = "karyawan",
                Username = nama_depan.ToLower(),
                Password = "null", // Sementara
                IsActive = 1
            };
            int newUserId = repo.Insert(karyawan);

            // Cek jika insert berhasil (ID > 0)
            if (newUserId > 0)
            {
                karyawan.IdUser = newUserId;
                karyawan.Username = karyawan.Username + $"{newUserId}_k";
                karyawan.Password = PasswordGenerator.GeneratePassword(nama_depan, newUserId);

                if (repo.Update(karyawan, true))
                {
                    return true;
                }
            }

            return false; // Ada yang gagal
        }

        public static bool EditKaryawan(Pengguna karyawan)
        {
            if (karyawan == null || karyawan.IdUser <= 0)
            {
                return false;
            }
            try
            {
                return repo.Update(karyawan);
            }
            catch (Exception)
            {
                return false; // Gagal mengupdate
            }
        }

        public static bool HapusKaryawan(int id_karyawan)
        {
            if (id_karyawan <= 0)
            {
                return false;
            }
            try
            {
                repo.Delete(id_karyawan);
                return true;
            }
            catch (Exception)
            {
                return false; // Gagal menghapus
            }
        }
    }
}
