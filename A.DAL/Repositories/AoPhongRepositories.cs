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
    public class AoPhongRepositories : IAoPhongRepositories
    {
        MyDBContext _dbContext = new MyDBContext();

        public bool Add(AoPhong aoPhong)
        {
            try
            {
                _dbContext.aoPhongs.Add(aoPhong);
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
                var doituong = _dbContext.aoPhongs.FirstOrDefault(c => c.MaAoPhong == id);
                if (doituong == null) return false;
                _dbContext.aoPhongs.Remove(doituong);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<AoPhong> GetAll()
        {
            return _dbContext.aoPhongs.ToList();
        }

        public AoPhong? Getbyid(Guid id)
        {
            var obj = _dbContext.aoPhongs.FirstOrDefault(c => c.MaAoPhong == id);

            return obj;
        }

        public bool Update(Guid id, AoPhong aoPhong)
        {
            _dbContext.Update(id);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
