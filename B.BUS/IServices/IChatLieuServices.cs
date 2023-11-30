﻿using A.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.BUS.IServices
{
    public interface IChatLieuServices
    {
        bool Add(ChatLieu chatLieu);
        bool Detele(Guid id);
        bool Update(Guid id, ChatLieu chatLieu);
        List<ChatLieu> GetAll();

        ChatLieu? Getbyid(Guid id);

        bool checktrung(string ten);
    }
}
