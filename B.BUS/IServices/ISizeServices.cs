﻿using A.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.BUS.IServices
{
    public interface ISizeServices
    {
        bool Add(Size size);
        bool Detele(Guid id);
        bool Update(Guid id, Size size);
        List<Size> GetAll();

        Size? Getbyid(Guid id);
    }
}