using A.DAL.Models;
using B.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.BUS.IServices
{
    public interface IAophongchitietServices
    {
        bool Add(AoPhongCT aoPhongCT);
        bool Detele(Guid id);
        bool Update( AoPhongCT aoPhongCT);
        List<AoPhongCT> GetAll();

        AoPhongCT? Getbyid(Guid id);

        List<Viewaophongchitiet> getViewAophongCT();
    }
}
