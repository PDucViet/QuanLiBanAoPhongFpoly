using A.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.BUS.IServices
{
    public interface IChucVuServices
    {
        bool Add(ChucVu chucVu);
        bool Delete(ChucVu chucVu);
        bool Update(ChucVu chucVu);
        List<ChucVu> GetAll();    }
}
