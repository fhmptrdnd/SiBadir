using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiBadir.Model;
using SiBadir.Repositories;

namespace SiBadir.Controllers
{
    public class NotifikasiController
    {
        private static NotifikasiRepository repo = new();
        public static void cekNotifikasi(Button button)
        {
            int cek = repo.cekNotifikasi(User.UserLoggedIn.IdUser);
            if (cek > 0)
            {
                button.Text = "Notifikasi ("+cek.ToString()+")";
            }
        }
        public static void cekNotifikasi(Label label)
        {
            int cek = repo.cekNotifikasi(User.UserLoggedIn.IdUser);
            if (cek > 0)
            {
                label.Text = "Anda memiliki " + cek.ToString() + " notifikasi yang belum terbaca!";
            }
        }
        public static List<NotifikasiStok> GetAll()
        {
            return repo.GetAll(User.UserLoggedIn.IdUser);
        }
        public static void BacaNotifikasi()
        {
            repo.BacaNotifikasi(User.UserLoggedIn.IdUser);
        }
    }
}
