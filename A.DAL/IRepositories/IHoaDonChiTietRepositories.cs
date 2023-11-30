using A.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.DAL.IRepositories
{
    public interface IHoaDonChiTietRepositories
    {
        bool Add(HoaDonChiTiet hoaDonChiTiet);
        bool Update(HoaDonChiTiet hoaDonChiTiet);
        bool Delete(HoaDonChiTiet hoaDonChiTiet);
        List<HoaDonChiTiet> GetAll();
    }
}
