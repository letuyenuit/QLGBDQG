using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.DTO
{
    public class DoiBongDTO
    {
        public DoiBongDTO() {
            ThoiGianThanhLap = DateTime.Now;
        
        }
        public string MaDoiBong {  get; set; }
        public string TenDoiBong { get; set; }
        public DateTime ThoiGianThanhLap { get; set; }
        public string MaSanNha {  get; set; }
    }
}
