using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.DTO
{
    public class BanThangDTO
    {
        public BanThangDTO() { }
        public string MaBanThang {  get; set; }
        public string TenBanThang { get; set; }
        public string MaCT { get; set; }
        public string TenCT { get; set; }
        public string MaThiDau { get; set; }
        public string TenThiDau { get; set; }
        public string MaLoaiBT { get; set; }
        public int ThoiDiemGhiBan {  get; set; }
    }
}
