using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiBadir.Model
{
    public class NotifikasiStok
    {
        public int IdNotifikasi { get; set; }
        public int? IdBahan { get; set; }
        //public string NamaBahan { get; set; }
        public int? IdPenerima { get; set; }
        //public string NamaPenerima { get; set; }
        public string Pesan { get; set; }
        public int? IsRead { get; set; }
        public DateTime TanggalNotifikasi { get; set; }
    }
}
