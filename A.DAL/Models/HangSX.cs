using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.DAL.Models
{
    public class HangSX
    {
        [Key] public Guid MaHSX { get; set; }
        public string TenHSX { get; set; }
        public bool TrangThaiHSX { get; set; }
        public List<AoPhongCT> AoPhongCT { get; set; }
    }
}
