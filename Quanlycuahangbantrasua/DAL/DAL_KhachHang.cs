using Quanlycuahangbantrasua.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quanlycuahangbantrasua.DAL
{
    public class DAL_KhachHang : DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //HIEN THI DANH SACH KHACHHANG RA NGOAI MAN HINH
        public DataTable getKhachHang()
        {
            _con.Open();
            da = new SqlDataAdapter("select * from KHACHHANG order by case when ISNUMERIC(SUBSTRING(MaKhachHang, 3, LEN(MaKhachHang))) = 1 THEN CAST(SUBSTRING(MaKhachHang, 3, LEN(MaKhachHang)) AS INT) ELSE NULL END", _con);
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
        public bool themKH(KhachHang kh)
        {
            try
            {
                string sql = "INSERT INTO KhachHang VALUES (N'" + kh.MaKhachHang + "', N'" + kh.HoTen + "', N'" + kh.GioiTinh + "', '" + kh.SDT + "')";
                thucthisql(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }

        public bool xoaKH(string maKhachHang)
        {
            try
            {
                string sql = "DELETE FROM KhachHang WHERE MaKhachHang=N'" + maKhachHang + "'";
                thucthisql(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        public bool suaKH(KhachHang kh)
        {
            try
            {
                string sql = "UPDATE KhachHang SET HoTen = N'" + kh.HoTen + "', GioiTinh = N'" + kh.GioiTinh + "', SDT = '" + kh.SDT + "' WHERE MaKhachHang = '" + kh.MaKhachHang + "'";
                thucthisql(sql);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }
    }
}
