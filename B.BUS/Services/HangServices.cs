using A.DAL.IRepositories;
using A.DAL.Models;
using A.DAL.Repositories;
using B.BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.BUS.Services
{
    public class HangServices : IHangServices
    {
        IHangrepositories ihangrepo = new Hangrepositories();
        public bool Add(HangSX hangSX)
        {
            return ihangrepo.Add(hangSX);
        }

        public bool Detele(Guid id)
        {
            return ihangrepo.Detele(id);
        }

        public List<HangSX> GetAll()
        {
            return ihangrepo.GetAll();
        }

        public HangSX? Getbyid(Guid id)
        {
            return ihangrepo.Getbyid(id);
        }

        public bool Update(Guid id, HangSX hangSX)
        {
            return ihangrepo.Update(id, hangSX);
        }
    }
}
