using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiBadir.Model
{
    public class Bahan : KategoriBahan
    {
        public int IdBahan { get; set; }
        public string NamaBahan { get; set; }
        public string SatuanBahan { get; set; }
        public int? IsActive { get; set; }
        public int StokBahan { get; set; }
    }
}
