using A.DAL.DBContext;
using A.DAL.IRepositories;
using A.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.DAL.Repositories
{
    public class AoPhongRepositories : IAoPhongRepositories
    {
        MyDBContext _dbContext= new MyDBContext();

        public bool Add(AoPhong aoPhong)
        {
            _dbContext.Add(aoPhong);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Detele(AoPhong aoPhong)
        {
            _dbContext.Remove(aoPhong);
            _dbContext.SaveChanges();
            return true;
        }

        public List<AoPhong> GetAll()
        {
            return _dbContext.aoPhongs.ToList();
        }

        public bool Update(AoPhong aoPhong)
        {
            _dbContext.Update(aoPhong);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
