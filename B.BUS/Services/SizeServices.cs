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
    public class SizeServices : ISizeServices
    {
        ISizeRepositories isizerepo = new Sizerepositories();

        public bool Add(Size size)
        {
            return isizerepo.Add(size);
        }

        public bool checktrung(string ten)
        {
            return isizerepo.checktrung(ten);
        }

        public bool Detele(Guid id)
        {
            return isizerepo.Detele(id);
        }

        public List<Size> GetAll()
        {
            return isizerepo.GetAll();
        }

        public Size? Getbyid(Guid id)
        {
            return isizerepo.Getbyid(id);
        }

        public bool Update(Guid id, Size size)
        {
            return isizerepo.Update(id,size);
        }
    }
}
