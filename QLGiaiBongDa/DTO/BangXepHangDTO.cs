using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.DTO
{
    public class BangXepHangDTO
    {
        public string MaDoiBong {  get; set; }
        public string TenDoiBong { get; set; }
        public int SoTranThang { get; set; }
        public int SoTranHoa {  get; set; }
        public int SoTranThua { get; set; }
        public int TongBanThang { get; set; }
        public int TongBanThua { get; set; }
        public int HieuSo { get; set; }

        public int Diem { get; set; }
        public int Hang { get; set; }


    }
}
