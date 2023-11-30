using A.DAL.DBContext;
using A.DAL.IRepositories;
using A.DAL.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.DAL.Repositories
{
    public class Hangrepositories : IHangrepositories
    {
        MyDBContext _dbContext = new MyDBContext();
        public bool Add(HangSX hangSX)
        {
            try
            {
                _dbContext.hangSXes.Add(hangSX);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool checktrung(string ten)
        {
            var obj = _dbContext.hangSXes.FirstOrDefault(c => c.TenHSX == ten);

            if (obj == null)
            {
                return false;
            }

            return true;
        }

        public bool Detele(Guid id)
        {
            try
            {
                var doituong = _dbContext.hangSXes.FirstOrDefault(c => c.MaHSX == id);
                if (doituong == null) return false;
                _dbContext.hangSXes.Remove(doituong);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<HangSX> GetAll()
        {
            return _dbContext.hangSXes.ToList();
        }

        public HangSX? Getbyid(Guid id)
        {
            var obj = _dbContext.hangSXes.FirstOrDefault(c => c.MaHSX == id);

            return obj;
        }

        public bool Update(Guid id, HangSX hangSX)
        {
            _dbContext.Update(id);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
