using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using QLGiaiBongDa.DTO;

namespace QLGiaiBongDa.DAL
{
    public class TrangThaiDAl : DbContext
    {
        public List<TrangThaiDTO> Get()
        {
            string sql = @"SELECT [MaTrangThai], [TenTrangThai] 
	            FROM   [TrangThai]";

            return Db
                .Query<TrangThaiDTO>(sql)
                .ToList();
        }
    }
}
