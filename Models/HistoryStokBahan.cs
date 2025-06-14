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
        public int? IdBahan { get; set; }
        public string NamaBahan { get; set; }
        public int? IdUser { get; set; }
        public string NamaUser { get; set; }
        public int? StokSebelum { get; set; }
        public int? StokSesudah { get; set; }
        public DateTime? TanggalPerubahan { get; set; }
        public string JenisPerubahan { get; set; }
        public string Keterangan { get; set; }
    }
}
