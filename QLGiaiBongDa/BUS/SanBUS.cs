using QLGiaiBongDa.DAL;
using QLGiaiBongDa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.BUS
{
    public class SanBUS
    {
        public SanDAL _dal = new SanDAL();

        public List<SanDTO> Get()
        {
            return _dal.Get();
        }

        public SanDTO Get(string ma)
        {
            return _dal.Get(ma);
        }

        public bool Create(SanDTO obj)
        {
            return _dal.Create(obj);
        }

        public bool Edit(SanDTO obj)
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
