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
        bool Update(AoPhong aoPhong);
        bool Delete(AoPhong aoPhong);
        List<AoPhong> GetAll();
    }
}
