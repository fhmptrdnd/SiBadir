using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiBadir.Model
{
    public class Pengguna
    {
        public int IdUser { get; set; }
        public string NamaUser { get; set; }
        public string AlamatUser { get; set; }
        public string Role { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? IsActive { get; set; }

        public Repositories.PenggunaRepository PenggunaRepository
        {
            get => default;
            set
            {
            }
        }

        public FormMenuKaryawan FormMenuKaryawan
        {
            get => default;
            set
            {
            }
        }

        public FormStokBahan FormStokBahan
        {
            get => default;
            set
            {
            }
        }

        public View.TambahKaryawan TambahKaryawan
        {
            get => default;
            set
            {
            }
        }

        public Form_Login Form_Login
        {
            get => default;
            set
            {
            }
        }
    }
}
