using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using QLGiaiBongDa.DTO;

namespace QLGiaiBongDa.DAL
{
    public class KetQuaTranDauDAL : DbContext
    {
        public List<KetQuaTranDauDTO> Get()
        {
            string sql = @"
                    SELECT 
                        kqtd.MaKetQua, 
                        db.TenDoiBong AS TenDoiBong1, 
                        kqtd.SoBanDoi1, 
                        db2.TenDoiBong AS TenDoiBong2,
                        kqtd.SoBanDoi2, 
                        kqtd.MaThiDau, 
                        CASE 
                            WHEN dktd.LuotThiDau = 1 THEN 'Lượt đi' 
                            WHEN dktd.LuotThiDau = 0 THEN 'Lượt về' 
                            ELSE 'Không xác định' 
                        END AS LuotThiDau, 
                        mg.MaMuaGiai,
                        mg.TenMuaGiai
                    FROM dbo.KetQuaThiDau AS kqtd
                    INNER JOIN dbo.DangKiThiDau AS dktd ON dktd.MaThiDau = kqtd.MaThiDau
                    INNER JOIN dbo.DoiBong AS db ON db.MaDoiBong = dktd.MaDoiBong1
                    INNER JOIN dbo.DoiBong AS db2 ON db2.MaDoiBong = dktd.MaDoiBong2
                    INNER JOIN dbo.MuaGiai AS mg ON mg.MaMuaGiai = dktd.MaMuaGiai
                ";

            return Db
                .Query<KetQuaTranDauDTO>(sql)
                .ToList();
        }
        public List<KetQuaTranDauDTO> Get(string matd, int luotthidau)
        {
            string sql = @"
                    SELECT 
                        kqtd.MaKetQua, 
                        db.TenDoiBong AS TenDoiBong1, 
                        kqtd.SoBanDoi1, 
                        db2.TenDoiBong AS TenDoiBong2,
                        kqtd.SoBanDoi2, 
                        kqtd.MaThiDau, 
                        CASE 
                            WHEN dktd.LuotThiDau = 1 THEN 'Lượt đi' 
                            WHEN dktd.LuotThiDau = 0 THEN 'Lượt về' 
                            ELSE 'Không xác định' 
                        END AS LuotThiDau, 
                        mg.TenMuaGiai
                    FROM dbo.KetQuaThiDau AS kqtd
                    INNER JOIN dbo.DangKiThiDau AS dktd ON dktd.MaThiDau = kqtd.MaThiDau
                    INNER JOIN dbo.DoiBong AS db ON db.MaDoiBong = dktd.MaDoiBong1
                    INNER JOIN dbo.DoiBong AS db2 ON db2.MaDoiBong = dktd.MaDoiBong2
                    INNER JOIN dbo.MuaGiai AS mg ON mg.MaMuaGiai = dktd.MaMuaGiai
                    WHERE dktd.MaMuaGiai = @MaMuaGiai AND dktd.LuotThiDau = @LuotThiDau
                ";

            return Db
                .Query<KetQuaTranDauDTO>(sql, new { MaMuaGiai = matd, LuotThiDau = luotthidau })
                .ToList();
        }
    }
}
