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
    public class TacGiaDAL
    {
        static string sqlConnect = @"Data Source=DIANGUC\SQLEXPRESS;Initial Catalog=QLSACH;Integrated Security=True";
        static SqlConnection conn = null;

        static void getConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(sqlConnect);
            }
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        static void closeConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        public List<TacGia> DanhSach()
        {
            List<TacGia> dsTG = new List<TacGia>();

            getConnection();
            string sqlSELECT = "SELECT * FROM TG";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                TacGia tg = new TacGia(data["MaTG"].ToString(),
                    data["TenTG"].ToString());
                dsTG.Add(tg);
            }

            data.Close();
            closeConnection();

            return dsTG;
        }
    }
}
