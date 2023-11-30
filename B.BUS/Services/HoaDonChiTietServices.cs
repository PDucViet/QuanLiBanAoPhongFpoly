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
    public class HoaDonChiTietServices : IHoaDonChiTietServices
    {
        IHoaDonChiTietRepositories _db= new HoaDonChiTietRepositories();
        public bool Add(HoaDonChiTiet hoaDonChiTiet)
        {
           _db.Add(hoaDonChiTiet);
            return true;
        }

        public bool Delete(HoaDonChiTiet hoaDonChiTiet)
        {
            _db.Delete(hoaDonChiTiet);
            return true;
        }

        public List<HoaDonChiTiet> GetAll()
        {
          return  _db.GetAll();
        }

        public bool Update(HoaDonChiTiet hoaDonChiTiet)
        {
            _db.Update(hoaDonChiTiet);
            return true;
        }
    }
}
