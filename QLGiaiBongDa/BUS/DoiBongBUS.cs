using QLGiaiBongDa.DAL;
using QLGiaiBongDa.DTO;
using QLGiaiBongDa.VIEW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.BUS
{
    public class DoiBongBUS
    {
        public DoiBongDAL _dal = new DoiBongDAL();

        public List<DoiBongView> Get()
        {
            return _dal.Get();
        }

        public DoiBongDTO Get(string ma)
        {
            return _dal.Get(ma);
        }

        public bool Create(DoiBongView obj)
        {
            return _dal.Create(obj);
        }

        public bool Edit(DoiBongDTO obj)
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

        public bool Delete(DoiBongView obj)
        {
            return _dal.DeleteD(obj.MaDoiBong);
        }
    }
}
