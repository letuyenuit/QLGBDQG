using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.DTO
{
    public class MuaGiaiDTO
    {
        public MuaGiaiDTO()
        {
            ThoiGianBatDauMuaGiai = DateTime.Now;
            ThoiGianKetThucMuaGiai = DateTime.Now;

        }
        public string MaMuaGiai { get; set; }
        public string TenMuaGiai { get; set; }
        public DateTime ThoiGianBatDauMuaGiai { get; set; }
        public DateTime ThoiGianKetThucMuaGiai { get; set; }

    }
}
