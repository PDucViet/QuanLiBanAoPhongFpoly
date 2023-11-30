using A.DAL.DBContext;
using A.DAL.IRepositories;
using A.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.DAL.Repositories
{
    public class ChatLieuRepositories : IChatLieuRepositories
    {
        MyDBContext _dbContext = new MyDBContext();
        public bool Add(ChatLieu chatLieu)
        {
            try
            {
                _dbContext.chatLieus.Add(chatLieu);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {

                return false;
            }
        }

        public bool checktrung(string ten)
        {
            var obj = _dbContext.chatLieus.FirstOrDefault(c => c.TenChatLieu == ten);

            if (obj == null)
            {
                return false;
            }

            return true;
        }

        public bool Detele(Guid id)
        {
            try
            {
                var doituong = _dbContext.chatLieus.FirstOrDefault(c => c.MaChatLieu == id);
                if (doituong == null) return false;
                _dbContext.chatLieus.Remove(doituong);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<ChatLieu> GetAll()
        {
            return _dbContext.chatLieus.ToList();
        }

        public ChatLieu? Getbyid(Guid id)
        {
            var obj = _dbContext.chatLieus.FirstOrDefault(c => c.MaChatLieu == id);

            return obj;
        }

        public bool Update(Guid id, ChatLieu chatLieu)
        {
            _dbContext.Update(id);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
