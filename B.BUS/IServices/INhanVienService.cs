using A.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.BUS.IServices
{
    public interface INhanVienService
    {
        public List<NhanVien> GetAll ();
        public bool AddNhanVien (NhanVien nhanVien);
        public bool RemoveNhanVien (NhanVien nhanVien);
        public bool UpdateNhanVien(NhanVien nhanVien);
    }
}
