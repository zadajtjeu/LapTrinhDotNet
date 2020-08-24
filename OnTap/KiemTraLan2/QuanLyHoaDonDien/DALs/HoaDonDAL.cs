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
    public class HoaDonDAL
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

        public List<HoaDon> DanhSach()
        {
            List<HoaDon> dsHD = new List<HoaDon>();

            getConnection();
            string sqlSTRING = "SELECT * FROM HoaDonTienDien";
            SqlCommand cmd = new SqlCommand(sqlSTRING, conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                HoaDon hd = new HoaDon(dr["MaHD"].ToString(),
                    dr["MaKH"].ToString(),
                    int.Parse(dr["ChiSoCu"].ToString()),
                    DateTime.Parse(dr["NgayCu"].ToString()),
                    int.Parse(dr["ChiSoMoi"].ToString()),
                    DateTime.Parse(dr["NgayMoi"].ToString())
                    );
                dsHD.Add(hd);
            }
            dr.Close();
            closeConnection();

            return dsHD;
        }

        public bool ThemHoaDon(HoaDon hd)
        {
            getConnection();
            string sqlSTRING = "INSERT INTO HoaDonTienDien VALUES(@mahd, @makh, @cscu, @ngaycu, @csmoi, @ngaymoi)";
            SqlCommand cmd = new SqlCommand(sqlSTRING, conn);
            cmd.Parameters.AddWithValue("mahd", hd.MaHoaDon);
            cmd.Parameters.AddWithValue("makh", hd.MaKhachHang);
            cmd.Parameters.AddWithValue("cscu", hd.ChiSoCu);
            cmd.Parameters.AddWithValue("ngaycu", hd.NgayCu);
            cmd.Parameters.AddWithValue("csmoi", hd.ChiSoMoi);
            cmd.Parameters.AddWithValue("ngaymoi", hd.NgayDo);
            int check = cmd.ExecuteNonQuery();
            closeConnection();

            return check > 0;
        }
        public bool SuaHoaDon(HoaDon hd)
        {
            getConnection();
            string sqlSTRING = "UPDATE HoaDonTienDien SET MaKH=@makh, ChiSoCu=@cscu, NgayCu=@ngaycu, ChiSoMoi=@csmoi, NgayMoi=@ngaymoi WHERE MaHD=@mahd";
            SqlCommand cmd = new SqlCommand(sqlSTRING, conn);
            cmd.Parameters.AddWithValue("mahd", hd.MaHoaDon);
            cmd.Parameters.AddWithValue("makh", hd.MaKhachHang);
            cmd.Parameters.AddWithValue("cscu", hd.ChiSoCu);
            cmd.Parameters.AddWithValue("ngaycu", hd.NgayCu);
            cmd.Parameters.AddWithValue("csmoi", hd.ChiSoMoi);
            cmd.Parameters.AddWithValue("ngaymoi", hd.NgayDo);
            int check = cmd.ExecuteNonQuery();
            closeConnection();

            return check > 0;
        }
        public bool XoaHoaDon(string maHD)
        {
            getConnection();
            string sqlSTRING = "DELETE FROM HoaDonTienDien WHERE MaHD=@mahd";
            SqlCommand cmd = new SqlCommand(sqlSTRING, conn);
            cmd.Parameters.AddWithValue("mahd", maHD);
            int check = cmd.ExecuteNonQuery();
            closeConnection();

            return check > 0;
        }
        public List<HoaDon> Tim(string maHD)
        {
            List<HoaDon> dsHD = new List<HoaDon>();

            getConnection();
            string sqlSTRING = "SELECT * FROM HoaDonTienDien WHERE MaHD=@mahd";
            SqlCommand cmd = new SqlCommand(sqlSTRING, conn);
            cmd.Parameters.AddWithValue("mahd", maHD);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                HoaDon hd = new HoaDon(dr["MaHD"].ToString(),
                    dr["MaKH"].ToString(),
                    int.Parse(dr["ChiSoCu"].ToString()),
                    DateTime.Parse(dr["NgayCu"].ToString()),
                    int.Parse(dr["ChiSoMoi"].ToString()),
                    DateTime.Parse(dr["NgayMoi"].ToString())
                    );
                dsHD.Add(hd);
            }
            dr.Close();
            closeConnection();

            return dsHD;
        }
    }
}
