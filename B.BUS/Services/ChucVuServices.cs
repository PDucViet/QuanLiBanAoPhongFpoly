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
    public class ChucVuServices : IChucVuServices
    {
        IChucVuRepositories ichucvurepository = new ChucVuRepositories();
        public bool Add(ChucVu chucVu)
        {
            ichucvurepository.Add(chucVu);
            return true;
        }

        public bool Delete(ChucVu chucVu)
        {
            ichucvurepository.Delete(chucVu);
            return true;
        }

        public List<ChucVu> GetAll()
        {
            return ichucvurepository.GetAll();
        }

        public bool Update(ChucVu chucVu)
        {
            ichucvurepository.Update(chucVu);
            return true;
        }
    }
}
