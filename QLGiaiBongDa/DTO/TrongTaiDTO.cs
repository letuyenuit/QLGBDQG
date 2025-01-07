using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.DTO
{
    public class TrongTaiDTO
    {
        public TrongTaiDTO()
        {
            NgaySinh = new DateTime(1970, 1, 1);
        }
        public string MaTT { get; set; }  
        public string TenTT { get; set; }
        public DateTime NgaySinh { get; set; }
    }
}
