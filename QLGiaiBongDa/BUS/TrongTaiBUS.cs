using QLGiaiBongDa.DAL;
using QLGiaiBongDa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.BUS
{
    public class TrongTaiBUS
    {
        public TrongTaiDAL _dal = new TrongTaiDAL();

        public List<TrongTaiDTO> Get()
        {
            return _dal.Get();
        }

        public TrongTaiDTO Get(string ma)
        {
            return _dal.Get(ma);
        }

        public bool Create(TrongTaiDTO obj)
        {
            return _dal.Create(obj);
        }

        public bool Edit(TrongTaiDTO obj)
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
