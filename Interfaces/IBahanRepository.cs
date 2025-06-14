using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiBadir.Model;

namespace SiBadir.Interfaces
{
    internal interface IBahanRepository
    {
        int Add(Bahan entity);
        List<Bahan> GetAll();
        Bahan GetById(int id);
        void Update(Bahan entity);
        void Delete(int id);
    }
}
