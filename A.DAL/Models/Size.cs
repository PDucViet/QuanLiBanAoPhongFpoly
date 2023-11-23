using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.DAL.Models
{
    public class Size
    {
        [Key]public Guid MaSize { get; set; }
        public string TenSize { get; set; }
        public bool TrangThaiSize { get; set; }
        public List<AoPhongCT> AoPhongCT { get; set; }
    }
}
