using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.DAL.Models
{
    public class ChucVu
    {
        [Key]public Guid MaChucVu { get; set; }
        public string TenChucVu { get; set; }
        public List<NhanVien> NhanVien { get; set;}

    }
}
