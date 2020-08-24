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
    public class NhacDAL
    {
        static string sqlConnect = @"Data Source=DIANGUC\SQLEXPRESS;Initial Catalog=MusicDB;Integrated Security=True";
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
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public List<Nhac> DanhSach()
        {
            List<Nhac> dsNhac = new List<Nhac>();

            getConnection();
            string sqlString = "SELECT * FROM Music";
            SqlCommand cmd = new SqlCommand(sqlString, conn);
            SqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                Nhac song = new Nhac(data["MusicID"].ToString(),
                    data["MusicTitle"].ToString(),
                    data["Album"].ToString(),
                    DateTime.Parse(data["DatePublic"].ToString()),
                    data["ArtistID"].ToString());
                dsNhac.Add(song);
            }

            data.Close();
            closeConnection();

            return dsNhac;
        }

        public bool ThemNhac(Nhac song)
        {
            getConnection();
            string sqlString = "INSERT INTO Music VALUES(@maBH, @tenBH, @album, @date, @maCS)";
            SqlCommand cmd = new SqlCommand(sqlString, conn);
            cmd.Parameters.AddWithValue("maBH", song.MaBaiHat);
            cmd.Parameters.AddWithValue("tenBH", song.TenBaiHat);
            cmd.Parameters.AddWithValue("album", song.Album);
            cmd.Parameters.AddWithValue("date", song.NgayRaMat);
            cmd.Parameters.AddWithValue("maCS", song.MaCaSi);
            int check = cmd.ExecuteNonQuery();

            closeConnection();

            return check > 0;
        }

        public bool SuaNhac(Nhac song)
        {
            getConnection();
            string sqlString = "UPDATE Music SET MusicTitle=@tenBH, Album=@album, DatePublic=@date, ArtistID=@maCS WHERE MusicID=@maBH";
            SqlCommand cmd = new SqlCommand(sqlString, conn);
            cmd.Parameters.AddWithValue("maBH", song.MaBaiHat);
            cmd.Parameters.AddWithValue("tenBH", song.TenBaiHat);
            cmd.Parameters.AddWithValue("album", song.Album);
            cmd.Parameters.AddWithValue("date", song.NgayRaMat);
            cmd.Parameters.AddWithValue("maCS", song.MaCaSi);
            int check = cmd.ExecuteNonQuery();

            closeConnection();

            return check > 0;
        }
        public bool XoaNhac(string maBH)
        {
            getConnection();
            string sqlString = "DELETE FROM Music WHERE MusicID=@maBH";
            SqlCommand cmd = new SqlCommand(sqlString, conn);
            cmd.Parameters.AddWithValue("maBH", maBH);
            int check = cmd.ExecuteNonQuery();

            closeConnection();

            return check > 0;
        }

        public List<Nhac> TimNhac(string maBH)
        {
            List<Nhac> dsNhac = new List<Nhac>();

            getConnection();
            string sqlString = "SELECT * FROM Music WHERE MusicID=@mabh";
            SqlCommand cmd = new SqlCommand(sqlString, conn);
            cmd.Parameters.AddWithValue("mabh", maBH);
            SqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                Nhac song = new Nhac(data["MusicID"].ToString(),
                    data["MusicTitle"].ToString(),
                    data["Album"].ToString(),
                    DateTime.Parse(data["DatePublic"].ToString()),
                    data["ArtistID"].ToString());
                dsNhac.Add(song);
            }

            data.Close();
            closeConnection();

            return dsNhac;
        }
    }
}
