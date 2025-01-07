using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.DTO
{
    public class CauThuViewDTO
    {
        public CauThuViewDTO()
        {
            NgaySinh = new DateTime(1970, 1, 1);
        }
        public string MaCT { get; set; }
        public string TenCT { get; set; }
        public string MaDoiBong { get; set; }
        public string TenDoiBong { get; set; }
        public string MaLoaiCT { get; set; }
        public string TenLoai { get; set; }
        public DateTime NgaySinh { get; set; }

        public int SoAo { get; set; }
        public string GhiChu { get; set; }
    }
}
