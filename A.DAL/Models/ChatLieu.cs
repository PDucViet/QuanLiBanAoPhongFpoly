using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.DAL.Models
{
    public class ChatLieu
    {
        [Key] public Guid MaChatLieu {  get; set; }
        public string TenChatLieu { get; set; }
        public bool TrangThaiChatLieu { get; set; }
        public List<AoPhongCT> AoPhongCT { get; set; }
    }
}
