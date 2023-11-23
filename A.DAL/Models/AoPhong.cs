using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.DAL.Models
{
    public class AoPhong
    {
        [Key]public Guid MaAoPhong {  get; set; }
        public string TenAoPhong { get; set; }
        public bool TrangThaiAoPhong { get; set; }
        public List<AoPhongCT> AoPhongCT { get; set; }
    }
}
