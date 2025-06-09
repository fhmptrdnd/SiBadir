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
        public DateTime TanggalPerubahan { get; set; }
        public required string NamaBahan { get; set; }
        public required string JenisPerubahan { get; set; }
        public int StokSebelum { get; set; }
        public int StokSesudah { get; set; }
        public required string NamaUser { get; set; }
        public required string Keterangan { get; set; }
    }
}
