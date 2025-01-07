using Dapper;
using QLGiaiBongDa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.DAL
{
    public class LoaiTranDauDAL : DbContext
    {
        public List<LoaiTranDauDTO> Get()
        {
            string sql = @"SELECT [MaLoai], [TenLoai] 
	            FROM   [LoaiTranDau]";
            return Db.Query<LoaiTranDauDTO>(sql)
                .ToList();
        }

        public LoaiTranDauDTO Get(string ma)
        {
            string sql = @"SELECT [MaLoai], [TenLoai] 
	            FROM   [LoaiTranDau] 
	            WHERE  ([MaLoai] = @MaLoai)";
            return Db.QueryFirstOrDefault<LoaiTranDauDTO>(sql, new { MaLoai = ma });
        }

        public bool Create(LoaiTranDauDTO obj)
        {
            string sql = @"INSERT INTO [LoaiTranDau] ([MaLoai], [TenLoai]) 
	            VALUES (@MaLoai, @TenLoai)";
            return Db.Execute(sql, obj) > 0;
        }

        public bool Edit(LoaiTranDauDTO obj)
        {
            string sql = @"UPDATE [LoaiTranDau]
	            SET    [TenLoai] = @TenLoai
	            WHERE  [MaLoai] = @MaLoai";
            return Db.Execute(sql, obj) > 0;
        }

        public bool Delete(string ma)
        {
            string sql = @"DELETE
	            FROM   [LoaiTranDau]
	            WHERE  [MaLoai] = @MaLoai";
            return Db.Execute(sql, new { MaLoai = ma}) > 0;
        }

        public bool Exists(string ma)
        {
            return Get(ma) != null;
        }
    }
}
