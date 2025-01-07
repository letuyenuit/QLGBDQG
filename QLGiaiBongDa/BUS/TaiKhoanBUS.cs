using QLGiaiBongDa.DAL;
using QLGiaiBongDa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.BUS
{
    public class TaiKhoanBUS
    {
        private TaiKhoanDAL _dal = new TaiKhoanDAL();

        public List<TaiKhoanDTO> Get()
        {
            return _dal.Get();
        }

        public TaiKhoanDTO Get(string ma)
        {
            return _dal.Get(ma);
        }

        public bool Create(TaiKhoanDTO obj)
        {
            return _dal.Create(obj);
        }

        public bool Edit(TaiKhoanDTO obj)
        {
            return _dal.Edit(obj);
        }

        public bool Delete(string ma)
        {
            return _dal.Delete(ma);
        }
    }
}
