using Dapper;
using QLGiaiBongDa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.DAL
{
    public class TranDauDAL : DbContext
    {
        public List<TranDauDTO> Get()
        {
            string sql = @"
                        SELECT 
    dktd.MaThiDau, 
    dktd.TenThiDau, 
    dktd.MaDoiBong1, 
    db1.TenDoiBong AS TenDoiBong1, 
    dktd.MaDoiBong2, 
    db2.TenDoiBong AS TenDoiBong2,
	dktd.ThoiGianThiDau,
	dktd.MaSanNha,
	sn.TenSanNha,
	dktd.ThoiLuongThiDau,
	dktd.LuotThiDau,
	mg.MaMuaGiai,
	mg.TenMuaGiai

FROM [dbo].[DangKiThiDau] AS dktd
LEFT JOIN [dbo].[DoiBong] AS db1 ON db1.MaDoiBong = dktd.MaDoiBong1
LEFT JOIN [dbo].[DoiBong] AS db2 ON db2.MaDoiBong = dktd.MaDoiBong2
LEFT JOIN [dbo].[SanNha] AS sn ON sn.MaSanNha = db1.MaSanNha
LEFT JOIN [dbo].[MuaGiai] AS mg ON mg.MaMuaGiai = dktd.MaMuaGiai
";
            return Db.Query<TranDauDTO>(sql)
                .ToList();
        }

        public List<DoiBongDTO> GetDSDoiBong(string maTD)
        {
            string sql = @"SELECT DoiBong.* FROM DoiBong
                INNER JOIN TranDau ON TranDau.MaDoi1 = DoiBong.MaDB OR TranDau.MaDoi2 = DoiBong.MaDB
                WHERE TranDau.MaTD = @MaTD";

            return Db.Query<DoiBongDTO>(sql, new { MaTD = maTD })
                .ToList();
        }

        public List<TrongTaiDTO> GetDSTrongTai(string maTD)
        {
            string sql = @"SELECT TrongTai.* FROM TrongTai
                INNER JOIN PhanCongTrongTai ON PhanCongTrongTai.MaTT = TrongTai.MaTT
                WHERE PhanCongTrongTai.MaTD = @MaTD";
            return Db.Query<TrongTaiDTO>(sql, new { MaTD = maTD })
                .ToList();
        }

        public TranDauDTO Get(string ma)
        {
            string sql = @"SELECT * FROM [DangKiThiDau]";
            return Db.QueryFirstOrDefault<TranDauDTO>(sql, new { MaTD = ma });
        }

        public bool Create(TranDauDTO obj)
        {
            string sql = @"INSERT INTO [DangKiThiDau] ([MaThiDau], [TenThiDau], [MaDoiBong1], [MaDoiBong2], [ThoiGianThiDau], [LuotThiDau], [MaSanNha], [MaMuaGiai], [MaQuyDinh],[ThoiLuongThiDau]) 
	             VALUES (@MaThiDau, @TenThiDau, @MaDoiBong1, @MaDoiBong2, @ThoiGianThiDau, @LuotThiDau, @MaSanNha, @MaMuaGiai, @MaQuyDinh, @ThoiLuongThiDau)";
            return Db.Execute(sql, obj) > 0;
        }

        public bool Edit(TranDauDTO obj)
        {
            string sql = @"UPDATE [DangKiThiDau]
	            SET   [MaThiDau] = @MaThiDau, [TenThiDau] = @TenThiDau, [MaDoiBong1] = @MaDoiBong1, [MaDoiBong2] = @MaDoiBong2, [ThoiGianThiDau] = @ThoiGianThiDau, [LuotThiDau] = @LuotThiDau, [MaSanNha] = @MaSanNha, [MaMuaGiai] = @MaMuaGiai, [ThoiLuongThiDau] = @ThoiLuongThiDau
	            WHERE  [MaThiDau] = @MaThiDau";
            return Db.Execute(sql, obj) > 0;
        }

        public bool Delete(string ma)
        {
            string sql = @"DELETE
	            FROM   [DangKiThiDau]
	            WHERE  [MaThiDau] = @MaThiDau";
            return Db.Execute(sql, new { MaThiDau = ma}) > 0;
        }

        public bool Exists(string ma)
        {
            return Get(ma) != null;
        }
    }
}
