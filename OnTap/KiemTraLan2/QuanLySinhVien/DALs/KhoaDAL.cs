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
    public class KhoaDAL
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

        public List<Khoa> DanhSach()
        {
            List<Khoa> dsKhoa = new List<Khoa>();

            getConnection();
            string sqlSELECT = "SELECT * FROM Khoa";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                Khoa khoa = new Khoa(data["MaKhoa"].ToString(),
                    data["TenKhoa"].ToString());
                dsKhoa.Add(khoa);
            }

            data.Close();

            closeConnection();

            return dsKhoa;

        }

        public Khoa TimKhoaTheoLop(string maLop)
        {
            List<Khoa> dsKhoa = new List<Khoa>();

            getConnection();
            string sqlSELECT = "SELECT * FROM Khoa WHERE MaKhoa = (SELECT MaKhoa FROM Lop WHERE MaLop=@malop)";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            cmd.Parameters.AddWithValue("malop", maLop);
            SqlDataReader data = cmd.ExecuteReader();
            Khoa khoa = null;
            if (data.Read())
            {
                khoa = new Khoa(data["MaKhoa"].ToString(),
                    data["TenKhoa"].ToString());
            }

            data.Close();

            closeConnection();

            return khoa;

        }
    }
}
