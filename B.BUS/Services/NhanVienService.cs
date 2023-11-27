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
    public class NhanVienService : INhanVienService
    {
        INhanVienRepo _repo = new NhanVienRepo();

        public bool AddNhanVien(NhanVien nhanVien)
        {
            _repo.AddNhanVien(nhanVien);
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return _repo.GetAll();
        }

        public bool RemoveNhanVien(NhanVien nhanVien)
        {
            _repo.RemoveNhanVien(nhanVien);
            return true;
        }

        public bool UpdateNhanVien(NhanVien nhanVien)
        {
            _repo.UpdateNhanVien(nhanVien);
            return true;
        }
    }
}
