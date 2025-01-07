using QLGiaiBongDa.DAL;
using QLGiaiBongDa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.BUS
{
    public class BangXepHangBUS
    {
        public BangXepHangDAL _dal = new BangXepHangDAL();

        public List<BangXepHangDTO> Get()
        {
            return _dal.Get();
        }

        public List<BangXepHangDTO> GetBy(string ma)
        {
            return _dal.GetBy(ma);
        }

    }
}
