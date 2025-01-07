using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGiaiBongDa.DAL;
using QLGiaiBongDa.DTO;

namespace QLGiaiBongDa.BUS
{
    public class TrangThaiBUS
    {
        public TrangThaiDAl _dal = new TrangThaiDAl();

        public List<TrangThaiDTO> Get()
        {
            return _dal.Get();
        }

    }
}
