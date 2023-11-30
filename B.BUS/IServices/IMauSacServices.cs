using A.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.BUS.IServices
{
    public interface IMauSacServices
    {
        bool Add(Mau mau);
        bool Detele(Guid id);
        bool Update(Guid id, Mau mau);
        List<Mau> GetAll();

        Mau? Getbyid(Guid id);

        bool checktrung(string ten);
    }
}
