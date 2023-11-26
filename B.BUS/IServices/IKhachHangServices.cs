using A.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.BUS.IServices
{
    public interface IKhachHangServices
    {
        bool Add(KhachHang khachHang);
        bool Delete(KhachHang khachHang);
        bool Update(KhachHang khachHang);
        List<KhachHang> GetAll();
    }
}

