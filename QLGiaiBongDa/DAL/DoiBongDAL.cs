using Dapper;
using QLGiaiBongDa.DTO;
using QLGiaiBongDa.VIEW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.DAL
{
    public class DoiBongDAL : DbContext
    {
        public List<DoiBongView> Get()
        {
            //string sql = @"SELECT [DoiBong].[MaDoiBong], [DoiBong].[TenDoiBong] , [DoiBong].[ThoiGianThanhLap], [SanNha].[TenSanNha] , [MaQuyDinh]
            // FROM   [DoiBong] INNER JOIN [SanNha] ON [SanNha].[MaSanNha] = [DoiBong].[MaSanNha]";
            string sql = @"
                SELECT 
                    DoiBong.MaDoiBong, 
                    DoiBong.TenDoiBong, 
                    DoiBong.ThoiGianThanhLap, 
                    SanNha.MaSanNha, 
                    SanNha.TenSanNha, 
                    COUNT(CauThu.MaCT) AS SoLuongCauThu,
	                COUNT(CASE WHEN CauThu.MaLoaiCT != 'MLCT001' THEN 1 END) AS SoLuongCauThuNuocNgoai
                FROM 
                    DoiBong 
                LEFT JOIN SanNha ON SanNha.MaSanNha = DoiBong.MaSanNha
                LEFT JOIN CauThu ON CauThu.MaDoiBong = DoiBong.MaDoiBong
                GROUP BY 
                    DoiBong.MaDoiBong, 
                    DoiBong.TenDoiBong, 
                    DoiBong.ThoiGianThanhLap, 
                    SanNha.MaSanNha, 
                    SanNha.TenSanNha
            ";

            var list =  Db.Query<DoiBongView>(sql)
                .ToList();
            return list;
        }

        //public DoiBongView Get(string ma)
        //{
        //    string sql = @"SELECT [DoiBong].[MaDoiBong], [DoiBong].[TenDoiBong] , [DoiBong].[ThoiGianThanhLap], [SanNha].[TenSanNha] , [MaQuyDinh]
	       //     FROM   [DoiBong] INNER JOIN [SanNha] ON [SanNha].[MaSanNha] = [DoiBong].[MaSanNha]
        //        WHERE [DoiBong].[MaDoiBong] = @MaDB
        //    ";
        //    return Db.QueryFirstOrDefault<DoiBongView>(sql, new { MaDB = ma });
        //}

        public DoiBongDTO Get(string ma)
        {
            string sql = @"SELECT [MaDoiBong], [TenDoiBong], [ThoiGianThanhLap] , [MaSanNha]
                           FROM [DoiBong]
                           WHERE [MaDoiBong] = @MaDB
            ";
            return Db.QueryFirstOrDefault<DoiBongDTO>(sql, new { MaDB = ma });
        }

        public bool Create(DoiBongView obj)
        {
            string sql = @"INSERT INTO [DoiBong] ([MaDoiBong], [TenDoiBong], [ThoiGianThanhLap], [MaSanNha]) 
    VALUES (@MaDoiBong, @TenDoiBong, @ThoiGianThanhLap, @MaSanNha)";
            return Db.Execute(sql, obj) > 0;
        }

        public bool Edit(DoiBongDTO obj)
        {
            string sql = @"UPDATE [DoiBong]
	            SET    [MaDoiBong] = @MaDoiBong, [TenDoiBong] = @TenDoiBong , [ThoiGianThanhLap] = @ThoiGianThanhLap, [MaSanNha] = @MaSanNha
	            WHERE  [MaDoiBong] = @MaDoiBong";

            return Db.Execute(sql, obj) > 0;
        }

        public bool Delete(string ma)
        {
            string sql = @"DELETE
	            FROM   [DoiBong]
	            WHERE  [MaDoiBong] = @MaDoiBong";
            return Db.Execute(sql, new { MaDB = ma }) > 0;
        }

        public bool Exists(string ma)
        {
            return Get(ma) != null;
        }

        public bool DeleteD(string ma)
        {
            string sql = @"
        DELETE FROM [DoiBong]
        WHERE [DoiBong].[MaDB] = @MaDB
        AND NOT EXISTS (
            SELECT 1
            FROM [CauThu]
            WHERE [CauThu].[MaDB] = [DoiBong].[MaDB]
        );
    ";
            return Db.Execute(sql, new { MaDB = ma }) > 0;
        }

    }
}
