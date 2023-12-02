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
    public class AophongchitietRepositories : IAophongchitietRepositories
    {
        private List<AoPhongCT> _aophongchitiet;
        private MyDBContext _dbContext ;

        public AophongchitietRepositories()
        {
            _aophongchitiet = new List<AoPhongCT>();
            _dbContext = new MyDBContext();
        }

        public bool Add(AoPhongCT aoPhongCT)
        {
            try
            {
                _dbContext.aoPhongCTs.Add(aoPhongCT);
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
                var doituong = _dbContext.aoPhongCTs.FirstOrDefault(c => c.MaAoPhongCT == id);
                if (doituong == null) return false;
                _dbContext.aoPhongCTs.Remove(doituong);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<AoPhongCT> GetAll()
        {
            _aophongchitiet = _dbContext.aoPhongCTs.ToList();
            return _aophongchitiet;
        }

        public AoPhongCT? Getbyid(Guid id)
        {
            var obj = _dbContext.aoPhongCTs.FirstOrDefault(c => c.MaAoPhongCT == id);

            return obj;
        }

        public bool Update(AoPhongCT aoPhongCT)
        {
            try
            {             

                _dbContext.Update(aoPhongCT);
                _dbContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
