using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using QLGiaiBongDa.DTO;

namespace QLGiaiBongDa.DAL
{
    public class QuyDinhDoiBongDAL : DbContext
    {
        public List<QuyDinhDoiBongDTO> Get()
        {
            string sql = @"SELECT TOP (1) [MaQuyDinh] , [SoLuongCauThuToiThieu] , [SoLuongCauThuToiDa], [SoLuongCauThuToiDaNuocNgoai] , [SoTuoiToiThieu] , [SoTuoiToiDa] , [ThoiDiemGhiBanToiDa]
	            FROM   [QuyDinhDoiBong]";
            return Db
                .Query<QuyDinhDoiBongDTO>(sql)
                .ToList();
        }

        public QuyDinhDoiBongDTO Get(string ma)
        {
            string sql = @"SELECT [MaQuyDinh] , [SoLuongCauThuToiThieu] , [SoLuongCauThuToiDa], [SoLuongCauThuToiDaNuocNgoai] , [SoTuoiToiThieu] , [SoTuoiToiDa] , [ThoiDiemGhiBanToiDa]
	            FROM   [QuyDinhDoiBong]
                WHERE [MaQuyDinh] = @MaQuyDinh
                ";
            return Db
                .QueryFirstOrDefault<QuyDinhDoiBongDTO>(sql, new { MaQuyDinh = ma });
        }

        public bool Create(QuyDinhDoiBongDTO obj)
        {
            string sql = @"INSERT INTO [QuyDinhDoiBong] ([MaQuyDinh] , [SoLuongCauThuToiThieu] , [SoLuongCauThuToiDa], [SoLuongCauThuToiDaNuocNgoai] , [SoTuoiToiThieu] , [SoTuoiToiDa] , [ThoiDiemGhiBanToiDa]) 
	            VALUES (@MaQuyDinh, @TenQuyDinh, @SoLuongCauThuToiThieu, @SoLuongCauThuToiDa, @SoLuongCauThuToiDaNuocNgoai, @SoTuoiToiThieu, @SoTuoiToiDa , @ThoiDiemGhiBanToiDa)";

            return Db.Execute(sql, obj) > 0;
        }

        public bool Edit(QuyDinhDoiBongDTO obj)
        {
            string sql = @"UPDATE [QuyDinhDoiBong]
	            SET [SoLuongCauThuToiThieu] = @SoLuongCauThuToiThieu, [SoLuongCauThuToiDa] = @SoLuongCauThuToiDa, [SoLuongCauThuToiDaNuocNgoai] = @SoLuongCauThuToiDaNuocNgoai, [SoTuoiToiThieu] = @SoTuoiToiThieu, [SoTuoiToiDa] = @SoTuoiToiDa, [ThoiDiemGhiBanToiDa] = @ThoiDiemGhiBanToiDa
	            WHERE  [MaQuyDinh] = @MaQuyDinh";

            return Db
                .Execute(sql, obj) > 0;
        }

        public bool Delete(string ma)
        {
            string sql = @"DELETE
	            FROM   [QuyDinhDoiBong]
	            WHERE  [MaQuyDinh] = @MaQuyDinh";
            return Db
                .Execute(sql, new { MaQuyDinh = ma }) > 0;
        }

        public bool Exists(string ma)
        {
            return Get(ma) != null;
        }
    }
}
