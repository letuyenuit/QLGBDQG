using Dapper;
using QLGiaiBongDa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.DAL
{
    public class BangXepHangDAL : DbContext
    {
        public List<BangXepHangDTO> Get()
        {
            string sql = @"
                    WITH MatchResults AS (
                        SELECT 
                            dk.MaDoiBong1 AS MaDoiBong,
                            SUM(CASE WHEN bt.ThoiDiemGhiBan IS NOT NULL THEN 1 ELSE 0 END) AS BanThang,
                            SUM(CASE WHEN bt2.ThoiDiemGhiBan IS NOT NULL THEN 1 ELSE 0 END) AS BanThua
                        FROM 
                            DangKiThiDau dk
                        LEFT JOIN 
                            BanThang bt ON dk.MaThiDau = bt.MaThiDau AND dk.MaDoiBong1 = bt.MaCT
                        LEFT JOIN 
                            BanThang bt2 ON dk.MaThiDau = bt2.MaThiDau AND dk.MaDoiBong2 = bt2.MaCT
                        GROUP BY 
                            dk.MaDoiBong1

                        UNION ALL

                        SELECT 
                            dk.MaDoiBong2 AS MaDoiBong,
                            SUM(CASE WHEN bt.ThoiDiemGhiBan IS NOT NULL THEN 1 ELSE 0 END) AS BanThang,
                            SUM(CASE WHEN bt2.ThoiDiemGhiBan IS NOT NULL THEN 1 ELSE 0 END) AS BanThua
                        FROM 
                            DangKiThiDau dk
                        LEFT JOIN 
                            BanThang bt ON dk.MaThiDau = bt.MaThiDau AND dk.MaDoiBong2 = bt.MaCT
                        LEFT JOIN 
                            BanThang bt2 ON dk.MaThiDau = bt2.MaThiDau AND dk.MaDoiBong1 = bt2.MaCT
                        GROUP BY 
                            dk.MaDoiBong2
                    ),
                    AggregatedResults AS (
                        SELECT 
                            MaDoiBong,
                            SUM(BanThang) AS TongBanThang,
                            SUM(BanThua) AS TongBanThua,
                            SUM(BanThang - BanThua) AS HieuSo,
                            SUM(CASE WHEN BanThang > BanThua THEN 1 ELSE 0 END) AS SoTranThang,
                            SUM(CASE WHEN BanThang = BanThua THEN 1 ELSE 0 END) AS SoTranHoa,
                            SUM(CASE WHEN BanThang < BanThua THEN 1 ELSE 0 END) AS SoTranThua,
                            SUM(CASE WHEN BanThang > BanThua THEN 3 WHEN BanThang = BanThua THEN 1 ELSE 0 END) AS Diem
                        FROM 
                            MatchResults
                        GROUP BY 
                            MaDoiBong
                    )
                    SELECT 
                        ar.MaDoiBong,
                        db.TenDoiBong,
                        ar.SoTranThang,
                        ar.SoTranHoa,
                        ar.SoTranThua,
                        ar.TongBanThang,
                        ar.TongBanThua,
                        ar.HieuSo,
                        ar.Diem,
                        RANK() OVER (ORDER BY ar.Diem DESC, ar.HieuSo DESC, ar.TongBanThang DESC) AS Hang
                    FROM 
                        AggregatedResults ar
                    JOIN 
                        DoiBong db ON ar.MaDoiBong = db.MaDoiBong
                    ORDER BY 
                        Hang;
                ";
            
            return Db
                .Query<BangXepHangDTO>(sql)
                .ToList();
        }

        public List<BangXepHangDTO> GetBy(string ma)
        {
            string sql = @"
                    WITH MatchResults AS (
                        SELECT 
                            dk.MaDoiBong1 AS MaDoiBong,
                            SUM(CASE WHEN bt.ThoiDiemGhiBan IS NOT NULL THEN 1 ELSE 0 END) AS BanThang,
                            SUM(CASE WHEN bt2.ThoiDiemGhiBan IS NOT NULL THEN 1 ELSE 0 END) AS BanThua
                        FROM 
                            DangKiThiDau dk
                        LEFT JOIN 
                            BanThang bt ON dk.MaThiDau = bt.MaThiDau AND dk.MaDoiBong1 = bt.MaCT
                        LEFT JOIN 
                            BanThang bt2 ON dk.MaThiDau = bt2.MaThiDau AND dk.MaDoiBong2 = bt2.MaCT
                        WHERE 
                            dk.MaMuaGiai = @MaMuaGiai
                        GROUP BY 
                            dk.MaDoiBong1

                        UNION ALL

                        SELECT 
                            dk.MaDoiBong2 AS MaDoiBong,
                            SUM(CASE WHEN bt.ThoiDiemGhiBan IS NOT NULL THEN 1 ELSE 0 END) AS BanThang,
                            SUM(CASE WHEN bt2.ThoiDiemGhiBan IS NOT NULL THEN 1 ELSE 0 END) AS BanThua
                        FROM 
                            DangKiThiDau dk
                        LEFT JOIN 
                            BanThang bt ON dk.MaThiDau = bt.MaThiDau AND dk.MaDoiBong2 = bt.MaCT
                        LEFT JOIN 
                            BanThang bt2 ON dk.MaThiDau = bt2.MaThiDau AND dk.MaDoiBong1 = bt2.MaCT
                        WHERE 
                            dk.MaMuaGiai = @MaMuaGiai
                        GROUP BY 
                            dk.MaDoiBong2
                    ),
                    AggregatedResults AS (
                        SELECT 
                            MaDoiBong,
                            SUM(BanThang) AS TongBanThang,
                            SUM(BanThua) AS TongBanThua,
                            SUM(BanThang - BanThua) AS HieuSo,
                            SUM(CASE WHEN BanThang > BanThua THEN 1 ELSE 0 END) AS SoTranThang,
                            SUM(CASE WHEN BanThang = BanThua THEN 1 ELSE 0 END) AS SoTranHoa,
                            SUM(CASE WHEN BanThang < BanThua THEN 1 ELSE 0 END) AS SoTranThua,
                            SUM(CASE WHEN BanThang > BanThua THEN 3 WHEN BanThang = BanThua THEN 1 ELSE 0 END) AS Diem
                        FROM 
                            MatchResults
                        GROUP BY 
                            MaDoiBong
                    )
                    SELECT 
                        ar.MaDoiBong,
                        db.TenDoiBong,
                        ar.SoTranThang,
                        ar.SoTranHoa,
                        ar.SoTranThua,
                        ar.TongBanThang,
                        ar.TongBanThua,
                        ar.HieuSo,
                        ar.Diem,
                        RANK() OVER (ORDER BY ar.Diem DESC, ar.HieuSo DESC, ar.TongBanThang DESC) AS Hang
                    FROM 
                        AggregatedResults ar
                    JOIN 
                        DoiBong db ON ar.MaDoiBong = db.MaDoiBong
                    ORDER BY 
                        Hang;

                ";

            return Db
                .Query<BangXepHangDTO>(sql, new { MaMuaGiai = ma})
                .ToList();
        }

    }
}
