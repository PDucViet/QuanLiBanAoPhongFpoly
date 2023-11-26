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
    public class KhachHangRepositories : IKhachHangRepositories
    {
        MyDBContext _dbContext = new MyDBContext();

        public bool Add(KhachHang khachHang)
        {
          _dbContext.Add(khachHang);
          _dbContext.SaveChanges();
            return true;
        }

        public bool Detele(KhachHang khachHang)
        {
            _dbContext.Remove(khachHang);
            _dbContext.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAll()
        {
          return _dbContext.khachHangs.ToList();
        }

        public bool Update(KhachHang khachHang)
        {
            _dbContext.Update(khachHang);
            _dbContext.SaveChanges();
            return true; 
        }
    }
}
