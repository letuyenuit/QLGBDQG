using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using QLGiaiBongDa.DTO;

namespace QLGiaiBongDa.DAL
{
    public class MuaGiaiDAL : DbContext
    {
        public List<MuaGiaiDTO> Get()
        {
            string sql = @"SELECT mg.MaMuaGiai, mg.TenMuaGiai, mg.ThoiGianBatDauMuaGiai, mg.ThoiGianKetThucMuaGiai
                        FROM [MuaGiai] AS mg
                ";
            return Db
                .Query<MuaGiaiDTO>(sql)
                .ToList();
        }

        public BangXepHangDTO Get(string ma)
        {
            string sql = @"SELECT [MaBXH], BangXepHang.MaDB, TenDB, [Thang], [Hoa], [Thua] , [Diem]
	            FROM   [BangXepHang] INNER JOIN DoiBong ON BangXepHang.MaDB = DoiBong.MaDB
	            WHERE  ([MaBXH] = @MaBXH)";

            return Db
                .QueryFirstOrDefault<BangXepHangDTO>(sql, new { MaBXH = ma });
        }

        public bool Create(BangXepHangDTO obj)
        {
            string sql = @"INSERT INTO [BangXepHang] ([MaBXH], [MaDB], [Thang], [Hoa], [Thua], [Diem]) 
	            VALUES (@MaBXH, @MaDB, @Thang, @Hoa, @Thua, @Diem)";

            return Db.Execute(sql, obj) > 0;
        }

        public bool Edit(BangXepHangDTO obj)
        {
            string sql = @"UPDATE [BangXepHang]
	            SET    [MaDB] = @MaDB, [Thang] = @Thang, [Hoa] = @Hoa, [Thua] = @Thua, [Diem] = @Diem
	            WHERE  [MaBXH] = @MaBXH";

            return Db
                .Execute(sql, obj) > 0;
        }

        public bool Delete(string ma)
        {
            string sql = @"DELETE
	            FROM   [BangXepHang]
	            WHERE  [MaBXH] = @MaBXH";
            return Db
                .Execute(sql, new { MaBXH = ma }) > 0;
        }

        public bool Exists(string ma)
        {
            return Get(ma) != null;
        }
    }
}
