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
    public class HoaDonChiTietRepositories : IHoaDonChiTietRepositories
    {
        MyDBContext _db = new MyDBContext();
        public bool Add(HoaDonChiTiet hoaDonChiTiet)
        {
            _db.Add(hoaDonChiTiet);
            _db.SaveChanges();
            return true;
        }

        public bool Delete(HoaDonChiTiet hoaDonChiTiet)
        {
            _db.Remove(hoaDonChiTiet);
            _db.SaveChanges();
            return true;
        }

        public List<HoaDonChiTiet> GetAll()
        {
           return _db.hoaDonChiTiets.ToList();
        }

        public bool Update(HoaDonChiTiet hoaDonChiTiet)
        {
            _db.Update(hoaDonChiTiet);
            _db.SaveChanges();
            return true;
        }
    }
}
