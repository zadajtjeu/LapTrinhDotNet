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
    public class SachDAL
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

        public List<Sach> DanhSach()
        {
            List<Sach> dsSach = new List<Sach>();

            getConnection();
            string sqlSELECT = "SELECT * FROM Sach";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader data = cmd.ExecuteReader();

            while(data.Read())
            {
                Sach sach = new Sach(data["Masach"].ToString(),
                    data["tensach"].ToString(),
                    int.Parse(data["slco"].ToString()),
                    data["MaTG"].ToString(),
                    DateTime.Parse(data["ngayxb"].ToString()));
                dsSach.Add(sach);
            }

            data.Close();
            closeConnection();

            return dsSach;
        }

        public bool ThemSach(Sach info)
        {
            getConnection();
            string sqlSELECT = "INSERT INTO Sach VALUES(@mas, @tens, @sl, @matg, @ngay)";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            cmd.Parameters.AddWithValue("mas", info.MaSach);
            cmd.Parameters.AddWithValue("tens", info.TenSach);
            cmd.Parameters.AddWithValue("sl", info.SoLuongCo);
            cmd.Parameters.AddWithValue("matg", info.MaTacGia);
            cmd.Parameters.AddWithValue("ngay", info.NgayXuatBan);
            int check = cmd.ExecuteNonQuery();

            closeConnection();

            return check > 0;
        }

        public bool SuaSach(Sach info)
        {
            getConnection();
            string sqlSELECT = "UPDATE Sach SET tensach=@tens, slco=@sl, MaTG=@matg, ngayxb=@ngay WHERE Masach=@mas";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            cmd.Parameters.AddWithValue("mas", info.MaSach);
            cmd.Parameters.AddWithValue("tens", info.TenSach);
            cmd.Parameters.AddWithValue("sl", info.SoLuongCo);
            cmd.Parameters.AddWithValue("matg", info.MaTacGia);
            cmd.Parameters.AddWithValue("ngay", info.NgayXuatBan);
            int check = cmd.ExecuteNonQuery();

            closeConnection();

            return check > 0;
        }

        public bool XoaSach(string maSach)
        {
            getConnection();
            string sqlSELECT = "DELETE FROM Sach WHERE Masach=@mas";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            cmd.Parameters.AddWithValue("mas", maSach);
            int check = cmd.ExecuteNonQuery();

            closeConnection();

            return check > 0;
        }

        public List<Sach> TimSach(string maSach)
        {
            List<Sach> dsSach = new List<Sach>();

            getConnection();
            string sqlSELECT = "SELECT * FROM Sach WHERE Masach=@mas";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            cmd.Parameters.AddWithValue("mas", maSach);
            SqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                Sach sach = new Sach(data["Masach"].ToString(),
                    data["tensach"].ToString(),
                    int.Parse(data["slco"].ToString()),
                    data["MaTG"].ToString(),
                    DateTime.Parse(data["ngayxb"].ToString()));
                dsSach.Add(sach);
            }

            data.Close();
            closeConnection();

            return dsSach;
        }
    }
}
