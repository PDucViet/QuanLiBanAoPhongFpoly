using A.DAL.DBContext;
using A.DAL.IRepositories;
using A.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace A.DAL.Repositories
{
    public class AoPhongRepositories : IAoPhongRepositories
    {
        private MyDBContext _dbContext;
        private List<AoPhong> _lstaophong;
        public AoPhongRepositories()
        {
            _lstaophong = new List<AoPhong>();
            _dbContext = new MyDBContext();
        }

        public bool Add(AoPhong aoPhong)
        {
            try
            {
                _dbContext.aoPhongs.Add(aoPhong);
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
            var obj = _dbContext.aoPhongs.FirstOrDefault(c => c.TenAoPhong == ten);

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
                var doituong = _dbContext.aoPhongs.FirstOrDefault(c => c.MaAoPhong == id);
                if (doituong == null) return false;
                _dbContext.aoPhongs.Remove(doituong);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<AoPhong> GetAll()
        {
            _lstaophong = _dbContext.aoPhongs.ToList();
            return _lstaophong;
        }

        public AoPhong? Getbyid(Guid id)
        {
            var obj = _dbContext.aoPhongs.FirstOrDefault(c => c.MaAoPhong == id);

            return obj;
        }

        public bool Update(Guid id, AoPhong aoPhong)
        {
            _dbContext.Update(id);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
