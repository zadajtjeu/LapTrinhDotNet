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
    public class KhoaKhamDAL
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

        public List<KhoaKham> DanhSach()
        {
            List<KhoaKham> dsKhoa = new List<KhoaKham>();

            getConnection();
            string sqlCMD = "SELECT * FROM KhoaKham";
            SqlCommand cmd = new SqlCommand(sqlCMD, conn);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                KhoaKham khoa = new KhoaKham(dr["MaKHoa"].ToString(),
                    dr["TenKhoa"].ToString());
                dsKhoa.Add(khoa);
            }

            dr.Close();
            closeConnection();

            return dsKhoa;
        }
    }
}
