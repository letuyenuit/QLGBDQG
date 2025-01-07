using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGiaiBongDa.DAL;
using QLGiaiBongDa.DTO;

namespace QLGiaiBongDa.BUS
{
    public class MuaGiaiBUS
    {
        public MuaGiaiDAL _dal = new MuaGiaiDAL();

        public List<MuaGiaiDTO> Get()
        {
            return _dal.Get();
        }

        public BangXepHangDTO Get(string ma)
        {
            return _dal.Get(ma);
        }

        public bool Create(BangXepHangDTO obj)
        {
            return _dal.Create(obj);
        }

        public bool Edit(BangXepHangDTO obj)
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
