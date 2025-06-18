using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiBadir.Model;

namespace SiBadir.Interfaces
{
    internal interface IHistoryRepository
    {
        HistoryStokBahan HistoryStokBahan { get; set; }

        HistoryStokBahan RowToHistory(DataRow row);
        List<HistoryStokBahan> GetAll(string? nama_bahan, DateTime? tanggal_perubahan, string? nama_kategori, string? jenis_perubahan, string? nama_user);
    }
}
