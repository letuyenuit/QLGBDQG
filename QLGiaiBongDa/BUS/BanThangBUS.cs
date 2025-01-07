using QLGiaiBongDa.DAL;
using QLGiaiBongDa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.BUS
{
    public class BanThangBUS
    {
        public BanThangDAL _dal = new BanThangDAL();

        public List<BanThangDTO> Get()
        {
            return _dal.Get();
        }

        public List<LoaiBanThangDTO> GetLoaiBT()
        {
            return _dal.GetLoaiBT();
        }

        public LoaiBanThangDTO GetLoaiBTBy(string ma)
        {
            return _dal.GetLoaiBTBy(ma);
        }

        public BanThangDTO Get(string ma)
        {
            return _dal.Get(ma);
        }

        public bool Create(BanThangDTO obj)
        {
            return _dal.Create(obj);
        }

        public bool CreateLoaiBT(LoaiBanThangDTO obj)
        {
            return _dal.CreateLoaiBT(obj);
        }

        public bool Edit(BanThangDTO obj)
        {
            return _dal.Edit(obj);
        }

        public bool EditLoaiBT(LoaiBanThangDTO obj)
        {
            return _dal.EditLoaiBT(obj);
        }

        public bool Delete(string ma)
        {
            return _dal.Delete(ma);
        }

        public bool DeleteLoaiBT (string ma)
        {
            return _dal.DeleteLoaiBT(ma);
        }

        public bool Exists(string ma)
        {
            return _dal.Exists(ma);
        }
    }
}
