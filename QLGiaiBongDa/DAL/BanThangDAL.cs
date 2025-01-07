using Dapper;
using QLGiaiBongDa.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.DAL
{
    public class BanThangDAL : DbContext
    {
        public List<BanThangDTO> Get()
        {
            string sql = @"
                    SELECT bt.MaBanThang, bt.TenBanThang, ct.MaCT, ct.TenCT,dktd.MaThiDau, dktd.TenThiDau, bt.MaLoaiBT, bt.ThoiDiemGhiBan FROM [dbo].[BanThang] AS bt
                    INNER JOIN [dbo].[CauThu] AS ct ON ct.MaCT = bt.MaCT
                    INNER JOIN [dbo].[DangKiThiDau] AS dktd ON dktd.MaThiDau = bt.MaThiDau
            ";
            return Db
                .Query<BanThangDTO>(sql)
                .ToList();
        }

        public List<LoaiBanThangDTO> GetLoaiBT()
        {
            string sql = @"
                SELECT [MaLoaiBT], [TenLoai]
                FROM [LoaiBanThang]
            ";
            return Db
                .Query<LoaiBanThangDTO>(sql)
                .ToList();
        }
        public LoaiBanThangDTO GetLoaiBTBy(string ma)
        {
            string sql = @"
                SELECT [MaLoaiBT], [TenLoai], [MoTa]
                FROM [LoaiBanThang]
                WHERE [MaLoaiBT] = @MaLoaiBT
            ";
            return Db
                .QueryFirstOrDefault<LoaiBanThangDTO>(sql, new { MaLoaiBT = ma});
        }

        public BanThangDTO Get(string ma)
        {
            string sql = @"
                SELECT bt.MaBanThang, bt.TenBanThang, bt.MaCT, bt.MaThiDau, bt.MaLoaiBT, bt.ThoiDiemGhiBan 
                FROM [dbo].[BanThang] AS bt    
                WHERE bt.MaBanThang = @MaBT
            ";

            return Db
                .QueryFirstOrDefault<BanThangDTO>(sql, new { MaBT = ma });
        }

        public bool Create(BanThangDTO obj)
        {
            string sql = @"INSERT INTO [BanThang] ([MaBanThang], [TenBanThang], [MaCT], [MaThiDau], [MaLoaiBT], [ThoiDiemGhiBan]) 
	            VALUES (@MaBanThang, @TenBanThang, @MaCT, @MaThiDau, @MaLoaiBT, @ThoiDiemGhiBan)";

            return Db.Execute(sql, obj) > 0;
        }

        public bool CreateLoaiBT(LoaiBanThangDTO obj)
        {
            string sql = @"INSERT INTO [LoaiBanThang] ([MaLoaiBT], [TenLoai], [MoTa]) 
	            VALUES (@MaLoaiBT, @TenLoai, @MoTa)";

            return Db.Execute(sql, obj) > 0;
        }

        public bool Edit(BanThangDTO obj)
        {
            string sql = @"UPDATE [BanThang]
	            SET    [MaBanThang] = @MaBanThang, TenBanThang = @TenBanThang, [MaCT] = @MaCT, [MaThiDau] = @MaThiDau, [MaLoaiBT] = @MaLoaiBT, [ThoiDiemGhiBan] = @ThoiDiemGhiBan
	            WHERE  [MaBanThang] = @MaBanThang";
            return Db.Execute(sql, obj) > 0;
        }

        public bool EditLoaiBT(LoaiBanThangDTO obj)
        {
            string sql = @"UPDATE [LoaiBanThang] 
                           SET [MaLoaiBT] = @MaLoaiBT, [TenLoai] = @TenLoai, [MoTa] = @MoTa
                           WHERE [MaLoaiBT] = @MaLoaiBT
            ";

            return Db.Execute(sql, obj) > 0;
        }

        public bool Delete(string ma)
        {
            string sql = @"DELETE
	            FROM   [BanThang]
	            WHERE  [MaBanThang] = @MaBT";
            return Db.Execute(sql, new { MaBT = ma }) > 0;
        }

        public bool DeleteLoaiBT(string ma)
        {
            string sql = @"DELETE
	            FROM   [LoaiBanThang]
	            WHERE  [MaLoaiBT] = @MaLoaiBT";
            return Db.Execute(sql, new { MaLoaiBT = ma }) > 0;
        }

        public bool Exists(string ma)
        {
            return Get(ma) != null;
        }
    }
}
