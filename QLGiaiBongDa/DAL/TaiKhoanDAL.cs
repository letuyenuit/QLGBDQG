using Dapper;
using QLGiaiBongDa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.DAL
{
    public class TaiKhoanDAL : DbContext
    {
        public List<TaiKhoanDTO> Get()
        {
            string sql = "SELECT * FROM Account";
            return Db.Query<TaiKhoanDTO>(sql).ToList();
        }

        public TaiKhoanDTO Get(string ma)
        {
            string sql = "SELECT * FROM Account WHERE TenTK = @TenTK";
            return Db.QueryFirstOrDefault<TaiKhoanDTO>(sql, new { TenTK = ma });
        }

        public bool Create(TaiKhoanDTO obj)
        {
            string sql = @"INSERT INTO [Account] ([MaTK],[TenTK],[MatKhau]) 
	            VALUES (@MaTK, @TenTK, @MatKhau)";
            return Db.Execute(sql, obj) > 0;
        }

        public bool Edit(TaiKhoanDTO obj)
        {
            string sql = @"UPDATE [Account]
	            SET    [MatKhau] = @MatKhau
	            WHERE  [MaTK] = @MaTK";
            return Db.Execute(sql, obj) > 0;
        }

        public bool Delete(string ma)
        {
            string sql = @"DELETE
	            FROM   [Account]
	            WHERE  [MaTK] = @MaTK";
            return Db.Execute(sql, new { MaTK = ma }) > 0;
        }
    }
}
