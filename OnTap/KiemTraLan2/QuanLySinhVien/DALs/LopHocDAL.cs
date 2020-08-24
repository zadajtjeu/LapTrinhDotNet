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
    public class LopHocDAL
    {
        static string sqlConnect = @"Data Source=DIANGUC\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True";
        static SqlConnection conn = null;
        static void getConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(sqlConnect);
            }
            if (conn.State == ConnectionState.Closed)
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

        public List<LopHoc> DanhSach()
        {
            List<LopHoc> dsLop = new List<LopHoc>();

            getConnection();
            string sqlSELECT = "SELECT * FROM Lop";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                LopHoc lop = new LopHoc(data["MaLop"].ToString(),
                    data["TenLop"].ToString(),
                    int.Parse(data["SiSo"].ToString()),
                    data["MaKhoa"].ToString());
                dsLop.Add(lop);
            }

            data.Close();

            closeConnection();

            return dsLop;

        }

        public List<LopHoc> DanhSach(string maKhoa)
        {
            List<LopHoc> dsLop = new List<LopHoc>();

            getConnection();
            string sqlSELECT = "SELECT * FROM Lop WHERE MaKhoa=@makhoa";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            cmd.Parameters.AddWithValue("makhoa", maKhoa);
            SqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                LopHoc lop = new LopHoc(data["MaLop"].ToString(),
                    data["TenLop"].ToString(),
                    int.Parse(data["SiSo"].ToString()),
                    data["MaKhoa"].ToString());
                dsLop.Add(lop);
            }

            data.Close();

            closeConnection();

            return dsLop;

        }
    }
}
