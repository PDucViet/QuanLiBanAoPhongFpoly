using A.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.BUS.IServices
{
    public interface IAoPhongServices
    {
        bool Add(AoPhong aoPhong);
        bool Detele(Guid id);
        bool Update(Guid id, AoPhong aoPhong);
        List<AoPhong> GetAll();

        AoPhong? Getbyid(Guid id);
        bool checktrung(string ten);
    }
}
