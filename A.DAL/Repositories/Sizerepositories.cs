﻿using A.DAL.DBContext;
using A.DAL.IRepositories;
using A.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.DAL.Repositories
{
    public class Sizerepositories : ISizeRepositories
    {
        MyDBContext _dbContext = new MyDBContext();
        public bool Add(Size size)
        {
            try
            {
                _dbContext.sizes.Add(size);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool Detele(Guid id)
        {
            try
            {
                var doituong = _dbContext.sizes.FirstOrDefault(c => c.MaSize == id);
                if (doituong == null) return false;
                _dbContext.sizes.Remove(doituong);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Size> GetAll()
        {
            return _dbContext.sizes.ToList();
        }

        public Size? Getbyid(Guid id)
        {
            var obj = _dbContext.sizes.FirstOrDefault(c =>c.MaSize == id);

            return obj;
        }

        public bool Update(Guid id, Size size)
        {
            _dbContext.Update(id);
            _dbContext.SaveChanges();
            return true;
        }

    }
}