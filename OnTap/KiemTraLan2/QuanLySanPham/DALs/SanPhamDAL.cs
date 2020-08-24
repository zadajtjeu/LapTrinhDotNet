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
    public class SanPhamDAL
    {
        static string sqlConnectStr = @"Data Source=DIANGUC\SQLEXPRESS;Initial Catalog=QLSP;Integrated Security=True";
        static SqlConnection conn = null;

        public void openConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(sqlConnectStr);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closeConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public List<SanPhamDTO> DanhSach()
        {
            List<SanPhamDTO> listSP = new List<SanPhamDTO>();

            openConnection();
            string sqlSelect = "SELECT * FROM SanPham";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dataRead = cmd.ExecuteReader();
            while(dataRead.Read())
            {
                SanPhamDTO sp = new SanPhamDTO(dataRead["MaSP"].ToString(),
                    dataRead["TenSP"].ToString(), Convert.ToDouble(dataRead["DonGia"]),
                    Convert.ToInt32(dataRead["SoLuong"]), dataRead["MaDM"].ToString());
                listSP.Add(sp);
            }
            dataRead.Close();
            closeConnection();

            return listSP;
        }

        public bool insertSanPham(SanPhamDTO sp)
        {
            openConnection();
            string sqlSelect = "INSERT INTO SanPham VALUES(@masp, @tensp, @dg, @sl, @madm)";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            cmd.Parameters.AddWithValue("masp", sp.MaSanPham);
            cmd.Parameters.AddWithValue("tensp", sp.TenSanPham);
            cmd.Parameters.AddWithValue("dg", sp.DonGia);
            cmd.Parameters.AddWithValue("sl", sp.SoLuong);
            cmd.Parameters.AddWithValue("madm", sp.MaDanhMuc);

            int excute = cmd.ExecuteNonQuery();
            closeConnection();

            return excute > 0;
        }

        public bool DeleteSanPham(string maSP)
        {
            openConnection();
            string sqlSelect = "DELETE FROM SanPham WHERE MaSP = @masp";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            cmd.Parameters.AddWithValue("masp", maSP);

            int excute = cmd.ExecuteNonQuery();
            closeConnection();

            return excute > 0;
        }

        public bool ModifySanPham(SanPhamDTO sp)
        {
            openConnection();
            string sqlSelect = "UPDATE SanPham SET TenSP=@tensp, DonGia=@dg, SoLuong=@sl, MaDM=@madm WHERE MaSP=@masp";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            cmd.Parameters.AddWithValue("masp", sp.MaSanPham);
            cmd.Parameters.AddWithValue("tensp", sp.TenSanPham);
            cmd.Parameters.AddWithValue("dg", sp.DonGia);
            cmd.Parameters.AddWithValue("sl", sp.SoLuong);
            cmd.Parameters.AddWithValue("madm", sp.MaDanhMuc);

            int excute = cmd.ExecuteNonQuery();
            closeConnection();

            return excute > 0;
        }


        public List<SanPhamDTO> FindSanPham(string maSP)
        {
            List<SanPhamDTO> listSP = new List<SanPhamDTO>();

            openConnection();
            string sqlSelect = "SELECT * FROM SanPham WHERE MaSP = @masp";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            cmd.Parameters.AddWithValue("masp", maSP);
            SqlDataReader dataRead = cmd.ExecuteReader();
            while(dataRead.Read())
            {
                SanPhamDTO sp = new SanPhamDTO(dataRead["MaSP"].ToString(),
                    dataRead["TenSP"].ToString(), Convert.ToDouble(dataRead["DonGia"]),
                    Convert.ToInt32(dataRead["SoLuong"]), dataRead["MaDM"].ToString());
                listSP.Add(sp);
            }
            dataRead.Close();
            closeConnection();

            return listSP;
        }
    }
}
