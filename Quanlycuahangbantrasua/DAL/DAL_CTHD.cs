using Quanlycuahangbantrasua.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Quanlycuahangbantrasua.DAL
{
    public class DAL_CTHD : DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //HIEN THI DANH SACH CTHD RA NGOAI MAN HINH
        public DataTable getCTHD()
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM CTHD ORDER BY CASE WHEN ISNUMERIC(SUBSTRING(MaHoaDon, 3, LEN(MaHoaDon))) = 1 THEN CAST(SUBSTRING(MaHoaDon, 3, LEN(MaHoaDon)) AS INT) ELSE NULL END", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        void thucthisql(string sql)
        {
            _con.Open();
            cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();
            _con.Close();
        }
        public bool ThemCTHD(string maHoaDon, string maMonAn, string tenMonAn, int soLuong, string donGia)
        {
            //try
            //{
            //    _con.Open();
            //    string sql = "INSERT INTO CTHD VALUES (N'" + maHoaDon + "', N'" + maMonAn + "', N'" + tenMonAn + "', '" + soLuong + "','" + donGia + "')";
            //    SqlCommand cmd = new SqlCommand(sql, _con);
            //    cmd.ExecuteNonQuery();
            //    _con.Close();
            //    return true;
            //}
            //catch (Exception ex)
            //{
            //    _con.Close();
            //    return false;
            //}
            _con.Open();
            string sql = "INSERT INTO CTHD VALUES (N'" + maHoaDon + "', N'" + maMonAn + "', N'" + tenMonAn + "', '" + soLuong + "','" + donGia + "')";
            SqlCommand cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();
            _con.Close();
            return true;
        }
        public DataTable TimKiem(string maHoaDon)
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from HoaDon where MaHoaDon = '" + maHoaDon + "'", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
    }
}
