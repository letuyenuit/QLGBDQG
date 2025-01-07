using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.VIEW
{
    public class DoiBongView
    {
        public DoiBongView()
        {
            ThoiGianThanhLap = DateTime.Now;
        }
        public string MaDoiBong { get; set; }
        public string TenDoiBong { get; set; }
        public DateTime ThoiGianThanhLap { get; set; }
        public string MaSanNha { get; set; }
        public string TenSanNha { get; set; }
        public int SoLuongCauThu { get; set; }
        public int SoLuongCauThuNuocNgoai { get; set; }
    }
}
