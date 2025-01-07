using Dapper;
using QLGiaiBongDa.DAL;
using QLGiaiBongDa.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaiBongDa.BUS
{
    public class ThongKeBUS : DbContext
    {
        public DataTable ThongKeBanThang()
        {
            string sql = "SELECT * FROM vThongKeBanThang";
            // Create a new DataTable
            DataTable dataTable = new DataTable();

            // Open a connection to the database using the connection string
            using (SqlConnection connection = new SqlConnection(Helpers.GetConnectionString()))
            {
                // Execute the SQL query using Dapper and obtain an IDataReader object
                connection.Open();

                using (IDataReader reader = connection.ExecuteReader(sql))
                {
                    // Load the data from the IDataReader object into the DataTable
                    dataTable.Load(reader);
                }
            }

            return dataTable;
        }

        public DataTable ThongKeCauThuGhiBan()
        {
            string sql = @"
                SELECT c.MaCT AS MaCauThu, c.TenCT AS TenCauThu, COUNT(bt.MaBT) AS SoLuongBanThang
                FROM [QLGiaiBongDa].[dbo].[CauThu] c
                LEFT JOIN [QLGiaiBongDa].[dbo].[BanThang] bt
                    ON c.MaCT = bt.MaCT
                GROUP BY c.MaCT, c.TenCT
                ORDER BY SoLuongBanThang DESC;
            ";
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(Helpers.GetConnectionString()))
            {
                connection.Open();

                using (IDataReader reader = connection.ExecuteReader(sql))
                {
                    dataTable.Load(reader);
                }
            }

            return dataTable;
        }


        public DataTable ThongKeThePhat()
        {
            string sql = "SELECT * FROM vThongKeThePhat";

            // Create a new DataTable
            DataTable dataTable = new DataTable();

            // Open a connection to the database using the connection string
            using (SqlConnection connection = new SqlConnection(Helpers.GetConnectionString()))
            {
                // Execute the SQL query using Dapper and obtain an IDataReader object
                connection.Open();

                using (IDataReader reader = connection.ExecuteReader(sql))
                {
                    // Load the data from the IDataReader object into the DataTable
                    dataTable.Load(reader);
                }
            }

            return dataTable;
        }
    }
}
