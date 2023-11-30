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
    public class MauSacServices : IMauSacServices
    {
        IMauSacrepositories imaurepo = new MauSacrepositories();
        public bool Add(Mau mau)
        {
            return imaurepo.Add(mau);
        }

        public bool checktrung(string ten)
        {
            return imaurepo.checktrung(ten);
        }

        public bool Detele(Guid id)
        {
            return imaurepo.Detele(id);
        }

        public List<Mau> GetAll()
        {
            return imaurepo.GetAll();
        }

        public Mau? Getbyid(Guid id)
        {
            return imaurepo.Getbyid(id);
        }

        public bool Update(Guid id, Mau mau)
        {
            return imaurepo.Update(id, mau);
        }
    }
}
