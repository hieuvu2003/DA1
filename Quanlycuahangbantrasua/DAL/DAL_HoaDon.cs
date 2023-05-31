using Quanlycuahangbantrasua.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace Quanlycuahangbantrasua.DAL
{
    public class DAL_HoaDon : DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //HIEN THI DANH SACH HOADON RA NGOAI MAN HINH
        public DataTable getHoaDon()
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM HOADON ORDER BY CASE WHEN ISNUMERIC(SUBSTRING(MaHoaDon, 3, LEN(MaHoaDon))) = 1  THEN CAST(SUBSTRING(MaHoaDon, 3, LEN(MaHoaDon)) AS INT)  ELSE NULL END ", _con);
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
        public bool ThemHoaDon(string maHoaDon, string maKhachHang, int maNV, string maBan, string ngayXuatHoaDon, double tongTien)
        {
            try
            {
                _con.Open();
                string sql = "INSERT INTO HOADON VALUES (N'" + maHoaDon + "', N'" + maKhachHang + "', '" + maNV + "', '" + maBan + "','" + ngayXuatHoaDon + "','" + tongTien + "')";
                SqlCommand cmd = new SqlCommand(sql, _con);
                cmd.ExecuteNonQuery();
                _con.Close();
                return true;
            }
            catch (Exception ex)
            {
                _con.Close();
                return false;
            }
        }
        public bool SuaHoaDon(string maHoaDon, string maKhachHang, int maNV, string maBan, string ngayXuatHoaDon, double tongTien)
        {
            try
            {
                _con.Open();
                string sql = "UPDATE HOADON SET MaHoaDon = N'" + maHoaDon + "', MaNV = '" + maNV + "',MaBan = '" + maBan + "', NgayXuatHoaDon = '" + ngayXuatHoaDon + "', TongTien = '" + tongTien + "' WHERE MaHoaDon = '" + maHoaDon + "'";
                SqlCommand cmd = new SqlCommand(sql, _con);
                cmd.ExecuteNonQuery();
                _con.Close();
                return true;
            }
            catch (Exception ex)
            {
                _con.Close();
                return false;
            }
        }
        public bool xoaHoaDon(string maHoaDon)
        {
            try
            {
                string sql = "DELETE FROM HOADON WHERE MaHoaDon =N'" + maHoaDon + "'";
                thucthisql(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        //public bool timHoaDon(string maHoaDon)
        //{
        //    try
        //    {
        //        string sql = string.Format("Select * from HoaDon where MaHoaDon = '"+ maHoaDon+"'");
        //        thucthisql(sql);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi: " + ex.Message);
        //        return false;
        //    }
        //}

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
