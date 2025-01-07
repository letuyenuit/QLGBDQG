using Dapper;
using QLGiaiBongDa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.DAL
{
    public class CauThuDAL : DbContext
    {
        public List<CauThuViewDTO> Get()
        {
            string sql = @"SELECT ct.MaCT, ct.TenCT, db.MaDoiBong, db.TenDoiBong,lct.MaLoaiCT, lct.TenLoai, ct.NgaySinh, ct.SoAo, ct.GhiChu 
                FROM [dbo].[CauThu] as ct
                LEFT JOIN [dbo].[DoiBong] AS db ON db.MaDoiBong = ct.MaDoiBong
                LEFT JOIN [dbo].[LoaiCauThu] AS lct ON lct.MaLoaiCT = ct.MaLoaiCT
";
            return Db.Query<CauThuViewDTO>(sql)
                .ToList();
        }
        public List<CauThuViewDTO> GetsBy(string ma)
        {
            string sql = @"
                        SELECT DISTINCT ct.MaCT, ct.TenCT
                        FROM dbo.CauThu AS ct
                        LEFT JOIN dbo.DoiBong AS db ON db.MaDoiBong = ct.MaDoiBong
                        LEFT JOIN dbo.DangKiThiDau AS dktd ON dktd.MaDoiBong1 = db.MaDoiBong
                        LEFT JOIN dbo.DangKiThiDau AS dktd2 ON dktd2.MaDoiBong2 = db.MaDoiBong
                        WHERE dktd.MaThiDau = @MaTD OR dktd2.MaThiDau = @MaTD
";
            return Db.Query<CauThuViewDTO>(sql, new {MaTD = ma})
                .ToList();
        }


        public CauThuDTO Get(string ma)
        {
            string sql = @"SELECT MaCT from CauThu WHERE MaCT = @MaCT";
            return Db.QueryFirstOrDefault<CauThuDTO>(sql, new { MaCT = ma });
        }

        
        public bool Create(CauThuDTO obj)
        {
            string sql = @"INSERT INTO [CauThu] ([MaCT], [TenCT], [MaDoiBong], [MaLoaiCT], [NgaySinh], [SoAo], [GhiChu]) 
	                VALUES (@MaCT, @TenCT, @MaDoiBong, @MaLoaiCT, @NgaySinh, @MaViTri, @SoAo, @GhiChu)";
            return Db.Execute(sql, obj) > 0;
        }

        public bool Edit(CauThuDTO obj)
        {
            string sql = @"UPDATE [CauThu]
	                SET    [MaCT] = @MaCT, [TenCT] = @TenCT, [NgaySinh] = @NgaySinh, [MaDoiBong] = @MaDoiBong, [MaLoaiCT] = @MaLoaiCT, [SoAo] = @SoAo, [GhiChu] = @GhiChu
	                WHERE  [MaCT] = @MaCT";
            return Db.Execute(sql, obj) > 0;
        }

        public bool Delete(string ma)
        {
            string sql = @"DELETE
	        FROM   [CauThu]
	        WHERE  [MaCT] = @MaCT";
            return Db.Execute(sql, new { MaCT = ma }) > 0;
        }

        public bool Exists(string ma)
        {
            return Get(ma) != null;
        }

        public List<LoaiCauThuDTO> GetLoaiCauThu()
        {
            string sql = @"SELECT MaLoaiCT, TenLoai
                           FROM [LoaiCauThu] ";
            return Db.Query<LoaiCauThuDTO>(sql)
                .ToList();
        }
    }
}
