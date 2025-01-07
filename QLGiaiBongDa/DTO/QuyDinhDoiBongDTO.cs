using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.DTO
{
    public class QuyDinhDoiBongDTO
    {
        public string MaQuyDinh { get; set; } 
        public int SoLuongCauThuToiThieu { get; set; }  
        public int SoLuongCauThuToiDa { get; set; } 
        public int SoLuongCauThuToiDaNuocNgoai { get; set; }  
        public int SoTuoiToiThieu { get; set; }  
        public int SoTuoiToiDa { get; set; }  

        public int ThoiDiemGhiBanToiDa { get; set; }
    }
}
