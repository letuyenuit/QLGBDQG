using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using QLGiaiBongDa.DTO;
using QLGiaiBongDa.VIEW;

namespace QLGiaiBongDa.DAL
{
    public class QuyDinhDAL : DbContext
    {
        public List<QuyDinhDoiBongDTO> Get()
        {
            //string sql = @"SELECT [DoiBong].[MaDoiBong], [DoiBong].[TenDoiBong] , [DoiBong].[ThoiGianThanhLap], [SanNha].[TenSanNha] , [MaQuyDinh]
            // FROM   [DoiBong] INNER JOIN [SanNha] ON [SanNha].[MaSanNha] = [DoiBong].[MaSanNha]";
            string sql = @"
                SELECT [QuyDinhDoiBong].[MaQuyDinh] , [QuyDinhDoiBong].[TenQuyDinh], [QuyDinhDoiBong].[SoLuongCauThuToiThieu], [QuyDinhDoiBong].[SoLuongCauThuToiDa], [QuyDinhDoiBong].[SoLuongCauThuToiDaNuocNgoai], [QuyDinhDoiBong].[SoTuoiToiThieu], [QuyDinhDoiBong].[SoTuoiToiDa]
                FROM [QuyDinhDoiBong] 
            ";

            return Db.Query<QuyDinhDoiBongDTO>(sql)
                .ToList();
        }

        //public DoiBongView Get(string ma)
        //{
        //    string sql = @"SELECT [DoiBong].[MaDoiBong], [DoiBong].[TenDoiBong] , [DoiBong].[ThoiGianThanhLap], [SanNha].[TenSanNha] , [MaQuyDinh]
        //     FROM   [DoiBong] INNER JOIN [SanNha] ON [SanNha].[MaSanNha] = [DoiBong].[MaSanNha]
        //        WHERE [DoiBong].[MaDoiBong] = @MaDB
        //    ";
        //    return Db.QueryFirstOrDefault<DoiBongView>(sql, new { MaDB = ma });
        //}

        public QuyDinhDoiBongDTO Get(string ma)
        {
            string sql = @"SELECT [DoiBong].[MaDoiBong], [DoiBong].[TenDoiBong] , [DoiBong].[ThoiGianThanhLap], [SanNha].[MaSanNha] ,[SanNha].[TenSanNha], [QuyDinhDoiBong].[MaQuyDinh]
	            FROM   [DoiBong] 
                INNER JOIN [SanNha] ON [SanNha].[MaSanNha] = [DoiBong].[MaSanNha]
                INNER JOIN [QuyDinhDoiBong] ON [QuyDinhDoiBong].[MaQuyDinh] = [DoiBong].[MaQuyDinh]
                WHERE [DoiBong].[MaDoiBong] = @MaDB
            ";
            return Db.QueryFirstOrDefault<QuyDinhDoiBongDTO>(sql, new { MaDB = ma });
        }

        public bool Create(QuyDinhDoiBongDTO obj)
        {
            string sql = @"INSERT INTO [DoiBong] ([MaDoiBong], [TenDoiBong], [ThoiGianThanhLap], [MaSanNha], [MaQuyDinh]) 
    VALUES (@MaDoiBong, @TenDoiBong, @ThoiGianThanhLap, @MaSanNha, @MaQuyDinh)";
            return Db.Execute(sql, obj) > 0;
        }

        public bool Edit(QuyDinhDoiBongDTO obj)
        {
            string sql = @"UPDATE [DoiBong]
	            SET    [TenDB] = @TenDB
	            WHERE  [MaDB] = @MaDB";

            return Db.Execute(sql, obj) > 0;
        }

        public bool Delete(string ma)
        {
            string sql = @"DELETE
	            FROM   [DoiBong]
	            WHERE  [MaDB] = @MaDB";
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
