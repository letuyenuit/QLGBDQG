using QLGiaiBongDa.DAL;
using QLGiaiBongDa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.BUS
{
    public class TranDauBUS
    {
        public TranDauDAL _dal = new TranDauDAL();

        public List<TranDauDTO> Get()
        {
            return _dal.Get();
        }

        public List<DoiBongDTO> GetDSDoiBong(string maTD)
        {
            return _dal.GetDSDoiBong(maTD);
        }

        public List<TrongTaiDTO> GetDSTrongTai(string maTD)
        {
            return _dal.GetDSTrongTai(maTD);
        }

        public TranDauDTO Get(string ma)
        {
            return _dal.Get(ma);
        }

        public bool Create(TranDauDTO obj)
        {
            return _dal.Create(obj);
        }

        public bool Edit(TranDauDTO obj)
        {
            return _dal.Edit(obj);
        }

        public bool Delete(string ma)
        {
            return _dal.Delete(ma);
        }

        public bool Exists(string ma)
        {
            return _dal.Exists(ma);
        }
    }
}
