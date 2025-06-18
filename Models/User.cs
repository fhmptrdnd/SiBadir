using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiBadir.Model
{
    public static class User
    {
        public static Pengguna UserLoggedIn { get; set; }

        public static Pengguna Pengguna
        {
            get => default;
            set
            {
            }
        }
    }
}
