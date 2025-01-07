using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGiaiBongDa.DAL;
using QLGiaiBongDa.DTO;
using QLGiaiBongDa.VIEW;

namespace QLGiaiBongDa.BUS
{
    public class KetQuaTranDauBUS
    {
        public KetQuaTranDauDAL _dal = new KetQuaTranDauDAL();

        public List<KetQuaTranDauDTO> Get()
        {
            return _dal.Get();
        }
        public List<KetQuaTranDauDTO> Get(string matd, int luotthidau)
        {
            return _dal.Get(matd, luotthidau);
        }
    }
}
