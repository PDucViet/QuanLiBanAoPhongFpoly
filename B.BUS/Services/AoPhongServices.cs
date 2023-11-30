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
    public class AoPhongServices : IAoPhongServices
    {
        private IAoPhongRepositories iaophongrepo ;
        public AoPhongServices() 
        {
            iaophongrepo = new AoPhongRepositories();
        }
        public bool Add(AoPhong aoPhong)
        {
            return iaophongrepo.Add(aoPhong);
        }

        public bool checktrung(string ten)
        {
            return iaophongrepo.checktrung(ten);
        }

        public bool Detele(Guid id)
        {
            return iaophongrepo.Detele(id);
        }

        public List<AoPhong> GetAll()
        {
            return iaophongrepo.GetAll();
        }

        public AoPhong? Getbyid(Guid id)
        {
            return iaophongrepo.Getbyid(id);
        }

        public bool Update(Guid id, AoPhong aoPhong)
        {
            return iaophongrepo.Update(id, aoPhong);
        }
    }
}
