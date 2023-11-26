using A.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.DAL.IRepositories
{
    public interface IKhachHangRepositories
    {
        bool Add(KhachHang khachHang);
        bool Detele(KhachHang khachHang);
        bool Update(KhachHang khachHang);
        List<KhachHang> GetAll();
    }
}
