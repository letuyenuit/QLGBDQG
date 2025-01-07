using QLGiaiBongDa.DAL;
using QLGiaiBongDa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.BUS
{
    public class CauThuBUS
    {
        public CauThuDAL _dal = new CauThuDAL();

        public List<CauThuViewDTO> Get()
        {
            return _dal.Get();
        }
        public List<CauThuViewDTO> GetsBy(string ma)
        {
            return _dal.GetsBy(ma);
        }
        public CauThuDTO Get(string ma)
        {
            return _dal.Get(ma);
        }

        public bool Create(CauThuDTO obj)
        {
            return _dal.Create(obj);
        }

        public bool Edit(CauThuDTO obj)
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

        public List<LoaiCauThuDTO> GetLoaiCauThu()
        {
            return _dal.GetLoaiCauThu();
        }
    }
}
