using Dapper;
using QLGiaiBongDa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.DAL
{
    public class TrongTaiDAL : DbContext
    {
        public List<TrongTaiDTO> Get()
        {
            string sql = @"SELECT [MaTT], [TenTT], [NgaySinh] 
	            FROM   [TrongTai]";
            return Db.Query<TrongTaiDTO>(sql)
                .ToList();
        }

        public TrongTaiDTO Get(string ma)
        {
            string sql = @"SELECT [MaTT], [TenTT], [NgaySinh] 
	            FROM   [TrongTai] 
	            WHERE  ([MaTT] = @MaTT)";
            return Db.QueryFirstOrDefault<TrongTaiDTO>(sql, new { MaTT = ma });
        }

        public bool Create(TrongTaiDTO obj)
        {
            string sql = @"INSERT INTO [TrongTai] ([MaTT], [TenTT], [NgaySinh]) 
	            VALUES (@MaTT, @TenTT, @NgaySinh)";
            return Db.Execute(sql, obj) > 0;
        }

        public bool Edit(TrongTaiDTO obj)
        {
            string sql = @"UPDATE [TrongTai]
	            SET    [TenTT] = @TenTT, [NgaySinh] = @NgaySinh
	            WHERE  [MaTT] = @MaTT";
            return Db.Execute(sql, obj) > 0;
        }

        public bool Delete(string ma)
        {
            string sql = @"DELETE
	            FROM   [TrongTai]
	            WHERE  [MaTT] = @MaTT";
            return Db.Execute(sql, new { MaTT = ma }) > 0;
        }

        public bool Exists(string ma)
        {
            return Get(ma) != null;
        }
    }
}
