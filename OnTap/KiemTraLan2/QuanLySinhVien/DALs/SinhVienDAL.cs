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
    public class SinhVienDAL
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

        public List<SinhVien> DanhSach()
        {
            List<SinhVien> dsSinhVien = new List<SinhVien>();

            getConnection();
            string sqlSELECT = "SELECT * FROM SinhVien";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            SqlDataReader data = cmd.ExecuteReader();

            while(data.Read())
            {
                SinhVien sv = new SinhVien(data["MaSV"].ToString(),
                    data["HoTen"].ToString(),
                    DateTime.Parse(data["NgaySinh"].ToString()),
                    data["GioiTinh"].ToString().ToLower() == "false" ? "Nam" : "Nữ",
                    data["MaLop"].ToString());
                dsSinhVien.Add(sv);
            }

            data.Close();

            closeConnection();

            return dsSinhVien;

        }

        public List<SinhVien> TimTheoMa(string maSV)
        {
            List<SinhVien> dsSinhVien = new List<SinhVien>();

            getConnection();
            string sqlSELECT = "SELECT * FROM SinhVien WHERE MaSV = @masv";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            cmd.Parameters.AddWithValue("masv", maSV);
            SqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                SinhVien sv = new SinhVien(data["MaSV"].ToString(),
                    data["HoTen"].ToString(),
                    DateTime.Parse(data["NgaySinh"].ToString()),
                    data["GioiTinh"].ToString().ToLower() == "false" ? "Nam" : "Nữ",
                    data["MaLop"].ToString());
                dsSinhVien.Add(sv);
            }

            data.Close();

            closeConnection();

            return dsSinhVien;

        }

        public bool XoaSinhVien(string maSV)
        {
            getConnection();
            string sqlSELECT = "DELETE FROM SinhVien WHERE MaSV=@masv";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            cmd.Parameters.AddWithValue("masv", maSV);
            int check = cmd.ExecuteNonQuery();
            closeConnection();

            return check > 0;
        }

        public bool ThemSinhVien(SinhVien sv)
        {
            getConnection();
            string sqlSELECT = "INSERT INTO SinhVien VALUES(@masv, @hoten, @ngaysinh, @gt, @malop)";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            cmd.Parameters.AddWithValue("masv", sv.MaSinhVien);
            cmd.Parameters.AddWithValue("hoten", sv.HoTen);
            cmd.Parameters.AddWithValue("ngaysinh", sv.NgaySinh);
            cmd.Parameters.AddWithValue("gt", sv.GioiTinh=="Nam"?false:true);
            cmd.Parameters.AddWithValue("malop", sv.MaLop);
            int check = cmd.ExecuteNonQuery();
            closeConnection();

            return check > 0;
        }

        public bool SuaThongTin(SinhVien sv)
        {
            getConnection();
            string sqlSELECT = "UPDATE SinhVien SET HoTen=@hoten, NgaySinh=@ngaysinh, GioiTinh=@gt, MaLop=@malop WHERE MaSV=@masv";
            SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
            cmd.Parameters.AddWithValue("masv", sv.MaSinhVien);
            cmd.Parameters.AddWithValue("hoten", sv.HoTen);
            cmd.Parameters.AddWithValue("ngaysinh", sv.NgaySinh);
            cmd.Parameters.AddWithValue("gt", sv.GioiTinh == "Nam" ? false : true);
            cmd.Parameters.AddWithValue("malop", sv.MaLop);
            int check = cmd.ExecuteNonQuery();
            closeConnection();

            return check > 0;
        }
    }
}
