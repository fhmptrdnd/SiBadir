using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiBadir.Model;

namespace SiBadir.Interfaces
{
    internal interface IPenggunaRepository
    {
        int Insert(Pengguna user);
        bool Update(Pengguna user, bool new_data = false);
        void Delete(int idUser);
        List<Pengguna> GetAll();
        Pengguna GetByUsernameAndPassword(string username, string password);
        Pengguna RowToPengguna(DataRow row);
    }
}
