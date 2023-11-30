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
    public class ChatLieuServices : IChatLieuServices
    {
        IChatLieuRepositories ichatlieurepo = new ChatLieuRepositories();
        public bool Add(ChatLieu chatLieu)
        {
            return ichatlieurepo.Add(chatLieu);
        }

        public bool checktrung(string ten)
        {
            return ichatlieurepo.checktrung(ten);
        }

        public bool Detele(Guid id)
        {
            return ichatlieurepo.Detele(id);
        }

        public List<ChatLieu> GetAll()
        {
            return ichatlieurepo.GetAll();
        }

        public ChatLieu? Getbyid(Guid id)
        {
            return ichatlieurepo.Getbyid(id);
        }

        public bool Update(Guid id, ChatLieu chatLieu)
        {
            return ichatlieurepo.Update(id, chatLieu);
        }
    }
}
