using A.DAL.Models;
using A.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.DAL.IRepositories
{
    public interface IAoPhongRepositories
    {
        bool Add(AoPhong aoPhong);
        bool Detele(AoPhong aoPhong);
        bool Update(AoPhong aoPhong);
        List<AoPhong> GetAll();
    }
}
