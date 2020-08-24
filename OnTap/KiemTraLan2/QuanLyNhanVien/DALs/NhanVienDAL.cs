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
    public class NhanVienDAL
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

        public List<NhanVien> DanhSach()
        {
            List<NhanVien> dsNhanVien = new List<NhanVien>();

            getConnection();
            string sqlSELECT = "SELECT * FROM tblNhanVien";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader data = cmd.ExecuteReader();

            while(data.Read())
            {
                NhanVien nv = new NhanVien(data["MaNV"].ToString(),
                    data["TenNV"].ToString(),
                    DateTime.Parse(data["NgaySinh"].ToString()),
                    double.Parse(data["LuongCanBan"].ToString()),
                    int.Parse(data["NgayCong"].ToString()),
                    double.Parse(data["PhuCap"].ToString()),
                    data["MaCV"].ToString());
                dsNhanVien.Add(nv);
            }

            data.Close();
            closeConnection();

            return dsNhanVien;
        }

        public bool ThemNhanVien(NhanVien nv)
        {
            getConnection();
            string sqlSELECT = "INSERT INTO tblNhanVien VALUES(@manv, @macv, @tennv, @ngaysinh, @luongcb, @ngaycong, @phucap)";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            cmd.Parameters.AddWithValue("manv", nv.MaNhanVien);
            cmd.Parameters.AddWithValue("macv", nv.MaChucVu);
            cmd.Parameters.AddWithValue("tennv", nv.TenNhanVien);
            cmd.Parameters.AddWithValue("ngaysinh", nv.NgaySinh);
            cmd.Parameters.AddWithValue("luongcb", nv.LuongCanBan);
            cmd.Parameters.AddWithValue("ngaycong", nv.NgayCong);
            cmd.Parameters.AddWithValue("phucap", nv.PhuCap);
            int check = cmd.ExecuteNonQuery();

            closeConnection();

            return check > 0;
        }

        public bool SuaNhanVien(NhanVien nv)
        {
            getConnection();
            string sqlSELECT = "UPDATE tblNhanVien SET MaCV=@macv, TenNV=@tennv, NgaySinh=@ngaysinh, LuongCanBan=@luongcb, NgayCong=@ngaycong, PhuCap=@phucap WHERE MaNV=@manv";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            cmd.Parameters.AddWithValue("manv", nv.MaNhanVien);
            cmd.Parameters.AddWithValue("macv", nv.MaChucVu);
            cmd.Parameters.AddWithValue("tennv", nv.TenNhanVien);
            cmd.Parameters.AddWithValue("ngaysinh", nv.NgaySinh);
            cmd.Parameters.AddWithValue("luongcb", nv.LuongCanBan);
            cmd.Parameters.AddWithValue("ngaycong", nv.NgayCong);
            cmd.Parameters.AddWithValue("phucap", nv.PhuCap);
            int check = cmd.ExecuteNonQuery();

            closeConnection();

            return check > 0;
        }
        public bool XoaNhanVien(string maNV)
        {
            getConnection();
            string sqlSELECT = "DELETE FROM tblNhanVien WHERE MaNV=@manv";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            cmd.Parameters.AddWithValue("manv", maNV);
            int check = cmd.ExecuteNonQuery();

            closeConnection();

            return check > 0;
        }

        public List<NhanVien> TimNhanVien(string maNV)
        {
            List<NhanVien> dsNhanVien = new List<NhanVien>();

            getConnection();
            string sqlSELECT = "SELECT * FROM tblNhanVien WHERE MaNV=@manv";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            cmd.Parameters.AddWithValue("manv", maNV);
            SqlDataReader data = cmd.ExecuteReader();

            while(data.Read())
            {
                NhanVien nv = new NhanVien(data["MaNV"].ToString(),
                    data["TenNV"].ToString(),
                    DateTime.Parse(data["NgaySinh"].ToString()),
                    double.Parse(data["LuongCanBan"].ToString()),
                    int.Parse(data["NgayCong"].ToString()),
                    double.Parse(data["PhuCap"].ToString()),
                    data["MaCV"].ToString());
                dsNhanVien.Add(nv);
            }

            data.Close();
            closeConnection();

            return dsNhanVien;
        }
    }
}
