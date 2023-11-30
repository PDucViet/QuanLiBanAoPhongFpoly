using A.DAL.IRepositories;
using A.DAL.Models;
using A.DAL.Repositories;
using B.BUS.IServices;
using B.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B.BUS.Services
{
    public class AophongchitietServices : IAophongchitietServices
    {
        private IAophongchitietRepositories iaophongchitietrepo ;
        private AoPhongServices _aophongServices ;
        private ChatLieuServices _chatlieuServices ;
        private HangServices _ihangServices;
        private MauSacServices _imauServices;
        private SizeServices _iSizeServices;
        private List<AoPhongCT> _aophongchitiet ;
        private List<Viewaophongchitiet> _lstView;
        public AophongchitietServices()
        {
            _aophongchitiet = new List<AoPhongCT>();
            iaophongchitietrepo = new AophongchitietRepositories();
            _aophongServices = new AoPhongServices();
            _chatlieuServices = new ChatLieuServices();
            _ihangServices = new HangServices();
            _imauServices = new MauSacServices();
            _iSizeServices = new SizeServices();
            _lstView = new List<Viewaophongchitiet>();
            GetAll();
        }
        public bool Add(AoPhongCT aoPhongCT)
        {
            return iaophongchitietrepo.Add(aoPhongCT);
        }

        public bool Detele(Guid id)
        {
            return iaophongchitietrepo.Detele(id);
        }

        public List<AoPhongCT> GetAll()
        {
            _aophongchitiet = iaophongchitietrepo.GetAll();
            return _aophongchitiet;
        }

        public AoPhongCT? Getbyid(Guid id)
        {
            return iaophongchitietrepo.Getbyid(id);
        }

        public List<Viewaophongchitiet> getViewAophongCT()
        {

            _lstView = (from a in GetAll()
                        join b in _imauServices.GetAll() on a.MauId equals b.MaMau
                        join c in _ihangServices.GetAll() on a.HangSXId equals c.MaHSX
                        join d in _iSizeServices.GetAll() on a.SizeId equals d.MaSize
                        join e in _aophongServices.GetAll() on a.AoPhongId equals e.MaAoPhong
                        join j in _chatlieuServices.GetAll() on a.ChatLieuId equals j.MaChatLieu
                        select new Viewaophongchitiet { aoPhongCTs = a, maus = b, hangSXes = c, sizes = d, aoPhongs = e, chatLieus = j }).ToList();
            return _lstView;
        }

        public bool Update(Guid id, AoPhongCT aoPhongCT)
        {
            return iaophongchitietrepo.Update(id, aoPhongCT);
        }
    }
}
