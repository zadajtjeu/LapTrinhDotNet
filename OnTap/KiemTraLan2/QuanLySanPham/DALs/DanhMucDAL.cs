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

    public class DanhMucDAL
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

        public List<DanhMucDTO> DanhSach()
        {
            List<DanhMucDTO> listDanhMuc = new List<DanhMucDTO>();

            openConnection();
            string sqlSelect = "SELECT * FROM DanhMucSanPham";
            SqlCommand cmd = new SqlCommand(sqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DanhMucDTO danhmuc = new DanhMucDTO(dr["MaDM"].ToString(), dr["TenDM"].ToString());
                listDanhMuc.Add(danhmuc);
            }
            dr.Close();
            closeConnection();

            return listDanhMuc;
        }
    }
}
