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
    public class BenhNhanDAL
    {
        static string sqlConnect = @"Data Source=DIANGUC\SQLEXPRESS;Initial Catalog=QLBenhNhan;Integrated Security=True";
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

        public List<BenhNhan> DanhSach()
        {
            List<BenhNhan> dsBN = new List<BenhNhan>();

            getConnection();
            string sqlCMD = "SELECT * FROM BenhNhan";
            SqlCommand cmd = new SqlCommand(sqlCMD, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                BenhNhan bn = new BenhNhan(dr["MaBN"].ToString(),
                    dr["HoTen"].ToString(),
                    DateTime.Parse(dr["NgaySinh"].ToString()),
                    dr["GioiTinh"].ToString().ToLower() == "true" ? "Nam" : "Nữ",
                    dr["MaBHXH"].ToString(),
                    dr["MaKhoa"].ToString());
                dsBN.Add(bn);
            }

            dr.Close();
            closeConnection();

            return dsBN;
        }

        public bool Them(BenhNhan bn)
        {
            getConnection();
            string sqlCMD = "INSERT INTO BenhNhan VALUES(@mabn, @hoten, @ngay, @gt, @bhxh, @khoa)";
            SqlCommand cmd = new SqlCommand(sqlCMD, conn);
            cmd.Parameters.AddWithValue("mabn", bn.MaBenhNhan);
            cmd.Parameters.AddWithValue("hoten", bn.TenBenhNhan);
            cmd.Parameters.AddWithValue("ngay", bn.NgaySinh);
            cmd.Parameters.AddWithValue("gt", bn.GioiTinh=="Nam");
            cmd.Parameters.AddWithValue("bhxh", bn.MaBHXH);
            cmd.Parameters.AddWithValue("khoa", bn.MaKhoa);
            int check = cmd.ExecuteNonQuery();

            closeConnection();

            return check > 0;
        }
        public bool Sua(BenhNhan bn)
        {
            getConnection();
            string sqlCMD = "UPDATE BenhNhan SET HoTen=@hoten, NgaySinh=@ngay, GioiTinh=@gt, MaBHXH=@bhxh, MaKhoa=@khoa WHERE MaBN=@mabn";
            SqlCommand cmd = new SqlCommand(sqlCMD, conn);
            cmd.Parameters.AddWithValue("mabn", bn.MaBenhNhan);
            cmd.Parameters.AddWithValue("hoten", bn.TenBenhNhan);
            cmd.Parameters.AddWithValue("ngay", bn.NgaySinh);
            cmd.Parameters.AddWithValue("gt", bn.GioiTinh == "Nam");
            cmd.Parameters.AddWithValue("bhxh", bn.MaBHXH);
            cmd.Parameters.AddWithValue("khoa", bn.MaKhoa);
            int check = cmd.ExecuteNonQuery();

            closeConnection();

            return check > 0;
        }

        public bool Xoa(string maBN)
        {
            getConnection();
            string sqlCMD = "DELETE FROM BenhNhan WHERE MaBN=@mabn";
            SqlCommand cmd = new SqlCommand(sqlCMD, conn);
            cmd.Parameters.AddWithValue("mabn", maBN);
            int check = cmd.ExecuteNonQuery();

            closeConnection();

            return check > 0;
        }
        public List<BenhNhan> Tim(string maBN)
        {
            List<BenhNhan> dsBN = new List<BenhNhan>();

            getConnection();
            string sqlCMD = "SELECT * FROM BenhNhan WHERE MaBN =@mabn";
            SqlCommand cmd = new SqlCommand(sqlCMD, conn);
            cmd.Parameters.AddWithValue("mabn", maBN);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                BenhNhan bn = new BenhNhan(dr["MaBN"].ToString(),
                    dr["HoTen"].ToString(),
                    DateTime.Parse(dr["NgaySinh"].ToString()),
                    dr["GioiTinh"].ToString().ToLower() == "true" ? "Nam" : "Nữ",
                    dr["MaBHXH"].ToString(),
                    dr["MaKhoa"].ToString());
                dsBN.Add(bn);
            }

            dr.Close();
            closeConnection();

            return dsBN;
        }
    }
}
