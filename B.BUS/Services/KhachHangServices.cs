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
    public class KhachHangServices : IKhachHangServices
    {
        IKhachHangRepositories _db = new KhachHangRepositories();
        public bool Add(KhachHang khachHang)
        {
           _db.Add(khachHang);
            return true;
        }

        public bool Delete(KhachHang khachHang)
        {
            _db.Detele(khachHang);
            return true;
        }

        public List<KhachHang> GetAll()
        {
            return _db.GetAll();
        }

        public bool Update(KhachHang khachHang)
        {
            _db.Update(khachHang);
            return true;
        }
    }
}
