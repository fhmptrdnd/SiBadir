using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiBadir.Controllers
{
    public static class PasswordGenerator
    {
        private static Random _random = new();

        public static string GeneratePassword(string namaDepan, int id)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            string randomStr = new(Enumerable.Repeat(chars, 4)
                .Select(s => s[_random.Next(s.Length)]).ToArray());

            return namaDepan.ToLower() + id + randomStr;
        }
    }
}
