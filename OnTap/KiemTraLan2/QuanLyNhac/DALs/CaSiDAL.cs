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
    public class CaSiDAL
    {
        static string sqlConnect = @"Data Source=DIANGUC\SQLEXPRESS;Initial Catalog=MusicDB;Integrated Security=True";
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
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public List<CaSi> DanhSach()
        {
            List<CaSi> dsCS = new List<CaSi>();

            getConnection();
            string sqlString = "SELECT * FROM Artist";
            SqlCommand cmd = new SqlCommand(sqlString, conn);
            SqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                CaSi cs = new CaSi(data["ArtistID"].ToString(),
                    data["ArtistName"].ToString());
                dsCS.Add(cs);
            }

            data.Close();
            closeConnection();

            return dsCS;
        }
    }
}
