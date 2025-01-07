using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGiaiBongDa.DAL;
using QLGiaiBongDa.DTO;

namespace QLGiaiBongDa.BUS
{
    public class QuyDinhDoiBongBUS
    {
        public QuyDinhDoiBongDAL _dal = new QuyDinhDoiBongDAL();

        public List<QuyDinhDoiBongDTO> Get()
        {
            return _dal.Get();
        }

        public QuyDinhDoiBongDTO Get(string ma)
        {
            return _dal.Get(ma);
        }

        public bool Create(QuyDinhDoiBongDTO obj)
        {
            return _dal.Create(obj);
        }

        public bool Edit(QuyDinhDoiBongDTO obj)
        {
            return _dal.Edit(obj);
        }
    }
}
