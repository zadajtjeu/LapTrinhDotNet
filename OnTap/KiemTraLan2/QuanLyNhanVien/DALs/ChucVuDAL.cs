using DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALs
{
    public class ChucVuDAL
    {
        static string sqlString = @"Data Source=DIANGUC\SQLEXPRESS;Initial Catalog=QLNV;Integrated Security=True";
        static SqlConnection conn = null;
        public static void getConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(sqlString);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public static void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public List<ChucVu> DanhSach()
        {
            List<ChucVu> dsChucVu = new List<ChucVu>();

            getConnection();
            string sqlSELECT = "SELECT * FROM tblChucVu";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                ChucVu cv = new ChucVu(data["MaCV"].ToString(),
                    data["TenCV"].ToString());
                dsChucVu.Add(cv);
            }

            data.Close();
            closeConnection();

            return dsChucVu;
        }
    }
}
