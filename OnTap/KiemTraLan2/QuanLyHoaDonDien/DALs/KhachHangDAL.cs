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
    public class KhachHangDAL
    {
        static string sqlConnect = @"Data Source=DIANGUC\SQLEXPRESS;Initial Catalog=QLHoaDonDien;Integrated Security=True";
        static SqlConnection conn = null;

        public void getConnection()
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
        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public List<KhachHang> DanhSach()
        {
            List<KhachHang> dsKH = new List<KhachHang>();

            getConnection();
            string sqlSTRING = "SELECT * FROM KhachHang";
            SqlCommand cmd = new SqlCommand(sqlSTRING, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                KhachHang kh = new KhachHang(dr["MaKH"].ToString(),
                    dr["HoTen"].ToString());
                dsKH.Add(kh);
            }
            dr.Close();
            closeConnection();

            return dsKH;
        }
    }
}
