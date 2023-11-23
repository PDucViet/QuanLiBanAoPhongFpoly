using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.DAL.Models
{
    public class Mau
    {
        [Key] public Guid MaMau {  get; set; }
        public string TenMau { get; set; }
        public bool TrangThaiMu { get; set; }
        public List<AoPhongCT> AoPhongCT { get; set; }
    }
}
