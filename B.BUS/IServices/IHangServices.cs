using A.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.BUS.IServices
{
    public interface IHangServices
    {
        bool Add(HangSX hangSX);
        bool Detele(Guid id);
        bool Update(Guid id, HangSX hangSX);
        List<HangSX> GetAll();

        HangSX? Getbyid(Guid id);
    }
}
