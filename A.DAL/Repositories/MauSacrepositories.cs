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
    public class MauSacrepositories : IMauSacrepositories
    {
        MyDBContext _dbContext = new MyDBContext();
        public bool Add(Mau mau)
        {
            try
            {
                _dbContext.maus.Add(mau);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool Detele(Guid id)
        {
            try
            {
                var doituong = _dbContext.maus.FirstOrDefault(c => c.MaMau == id);
                if (doituong == null) return false;
                _dbContext.maus.Remove(doituong);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Mau> GetAll()
        {
            return _dbContext.maus.ToList();
        }

        public Mau? Getbyid(Guid id)
        {
            var obj = _dbContext.maus.FirstOrDefault(c => c.MaMau == id);

            return obj;
        }

        public bool Update(Guid id, Mau mau)
        {
            _dbContext.Update(id);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
