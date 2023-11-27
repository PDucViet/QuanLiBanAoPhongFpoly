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
    public class NhanVienRepo : INhanVienRepo
    {
        MyDBContext _db = new MyDBContext();
        public bool AddNhanVien(NhanVien nhanVien)
        {
            _db.nhanViens.Add(nhanVien);
            _db.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return _db.nhanViens.ToList();
        }

        public bool RemoveNhanVien(NhanVien nhanVien)
        {
            _db.nhanViens.Remove(nhanVien);
            _db.SaveChanges();
            return true;
        }

        public bool UpdateNhanVien(NhanVien nhanVien)
        {
            _db.nhanViens.Update(nhanVien);
            _db.SaveChanges();
            return true;
        }
    }
}
