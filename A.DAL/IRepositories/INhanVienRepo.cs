using A.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.DAL.IRepositories
{
    public interface INhanVienRepo
    {
        public List<NhanVien> GetAll();
        public bool AddNhanVien(NhanVien nhanVien);
        public bool RemoveNhanVien(NhanVien nhanVien);
        public bool UpdateNhanVien(NhanVien nhanVien);
    }
}
