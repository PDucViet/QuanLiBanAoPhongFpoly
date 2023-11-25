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
    public class ChucVuRepositories : IChucVuRepositories
    {
        MyDBContext _dbContext = new MyDBContext();
        public bool Add(ChucVu chucVu)
        {
            _dbContext.Add(chucVu);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu chucVu)
        {
            _dbContext.Remove(chucVu);
            _dbContext.SaveChanges();
            return true;
        }

        public List<ChucVu> GetAll()
        {
            return _dbContext.chucVus.ToList();
        }

        public bool Update(ChucVu chucVu)
        {
            _dbContext.Update(chucVu);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
