using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.DTO
{
    public class TranDauDTO
    {
        public TranDauDTO()
        {
            ThoiGianThiDau = DateTime.Now;
        }

        public string MaThiDau {  get; set; }
        public string TenThiDau { get; set; }
        public string MaDoiBong1 { get; set; }
        public string TenDoiBong1 { get; set; }
        public string MaDoiBong2 { get; set; }
        public string TenDoiBong2 { get; set; }
        public DateTime ThoiGianThiDau { get; set; }
        public string MaSanNha { get; set; }
        public string TenSanNha { get; set; }
        public int ThoiLuongThiDau { get; set; }
        public int LuotThiDau { get; set; }
        public string MaMuaGiai { get; set; }
        public string TenMuaGiai { get; set; }
        

    }
}
