using A.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.DAL.IRepositories
{
    public interface IAophongchitietRepositories
    {
        bool Add(AoPhongCT aoPhongCT);
        bool Detele(Guid id);
        bool Update(Guid id, AoPhongCT aoPhongCT);
        List<AoPhongCT> GetAll();

        AoPhongCT? Getbyid(Guid id);
    }
}
