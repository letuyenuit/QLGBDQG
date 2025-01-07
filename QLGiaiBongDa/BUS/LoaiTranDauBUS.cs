using QLGiaiBongDa.DAL;
using QLGiaiBongDa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.BUS
{
    public class LoaiTranDauBUS
    {
        public LoaiTranDauDAL _dal = new LoaiTranDauDAL();

        public List<LoaiTranDauDTO> Get()
        {
            return _dal.Get();
        }

        public LoaiTranDauDTO Get(string ma)
        {
            return _dal.Get(ma);
        }

        public bool Create(LoaiTranDauDTO obj)
        {
            return _dal.Create(obj);
        }

        public bool Edit(LoaiTranDauDTO obj)
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
