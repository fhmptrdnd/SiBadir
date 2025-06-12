using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiBadir.Model
{
    public class HistoryStokBahan
    {
        public int IdHistory { get; set; }
<<<<<<< HEAD
        public int? IdBahan { get; set; }
        public int? IdUser { get; set; }
        public int? StokSebelum { get; set; }
        public int? StokSesudah { get; set; }
        public DateTime? TanggalPerubahan { get; set; }
        public string JenisPerubahan { get; set; }
        public string Keterangan { get; set; }
=======
        public DateTime TanggalPerubahan { get; set; }
        public required string NamaBahan { get; set; }
        public required string JenisPerubahan { get; set; }
        public int StokSebelum { get; set; }
        public int StokSesudah { get; set; }
        public required string NamaUser { get; set; }
        public required string Keterangan { get; set; }
>>>>>>> abf6d71e8d77a59fc33a05aa35b285575b416475
    }
}
