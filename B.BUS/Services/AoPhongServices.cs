using A.DAL.IRepositories;
using A.DAL.Models;
using A.DAL.Repositories;
using B.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.BUS.Services
{
    public class AoPhongServices : IAoPhongServices
    {
        IAoPhongRepositories _db = new AoPhongRepositories();
        public bool Add(AoPhong aoPhong)
        {
          _db.Add(aoPhong);
            return true;
        }

        public bool Delete(AoPhong aoPhong)
        {
            _db.Detele(aoPhong);
            return true;
        }

        public List<AoPhong> GetAll()
        {
         return _db.GetAll();
        }

        public bool Update(AoPhong aoPhong)
        {
            _db.Update(aoPhong);
            return true;
        }
    }
}
