using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiBadir.Model;

namespace SiBadir.Interfaces
{
    internal interface INotifikasiRepository
    {

        List<NotifikasiStok> GetAll(int id_pengguna);
        int cekNotifikasi(int id_pengguna);
        NotifikasiStok RowToNotifikasi(DataRow row);
        void BacaNotifikasi(int id_pengguna);
        void insertNotifikasi(NotifikasiStok notifikasi);
    }
}
