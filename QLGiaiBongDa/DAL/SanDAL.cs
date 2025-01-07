using Dapper;
using QLGiaiBongDa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.DAL
{
    public class SanDAL : DbContext
    {
        public List<SanDTO> Get()
        {
            string sql = @"SELECT [MaSanNha], [TenSanNha], [DiaChi], [SucChua] 
	            FROM   [SanNha]";
            return Db.Query<SanDTO>(sql)
                .ToList();
        }

        public SanDTO Get(string ma)
        {
            string sql = @"SELECT [MaSanNha], [TenSanNha], [DiaChi], [SucChua] 
	            FROM   [SanNha] 
	            WHERE  ([MaSanNha] = @MaSanNha)";
            return Db.QueryFirstOrDefault<SanDTO>(sql, new { MaSanNha = ma });
        }

        public bool Create(SanDTO obj)
        {
            string sql = @"INSERT INTO [SanNha] ([MaSanNha], [TenSanNha], [DiaChi], [SucChua]) 
    VALUES (@MaSanNha, @TenSanNha, @DiaChi, @SucChua)";
            return Db.Execute(sql, obj) > 0;
        }

        public bool Edit(SanDTO obj)
        {
            string sql = @"UPDATE [SanNha]
	            SET    [TenSanNha] = @TenSanNha, [DiaChi] = @DiaChi, [SucChua] = @SucChua
	            WHERE  [MaSanNha] = @MaSanNha";
            return Db.Execute(sql, obj) > 0;
        }

        public bool Delete(string ma)
        {
            string sql = @"DELETE
	            FROM   [SanNha]
	            WHERE  [MaSanNha] = @MaSanNha";
            return Db.Execute(sql, new { MaSanNha = ma }) > 0;
        }

        public bool Exists(string ma)
        {
            return Get(ma) != null;
        }
    }
}
