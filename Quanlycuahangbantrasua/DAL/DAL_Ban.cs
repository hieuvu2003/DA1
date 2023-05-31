using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlycuahangbantrasua.DTO;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ReportingServices.Diagnostics.Internal;


namespace Quanlycuahangbantrasua.DAL
{
    public class DAL_Ban : DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public DAL_Ban()
        {
            // Khởi tạo kết nối đến cơ sở dữ liệu
            _con = new SqlConnection("Data Source=DESKTOP-8SU7OS9\\SQLEXPRESS;Initial Catalog=VMHQuanLyQuanTraSua;Integrated Security=True");
        }

        // Phương thức lấy danh sách bàn
        public DataTable getBan()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from Ban", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }

        // Lấy danh sách bàn đang sử dụng
        public DataTable LayDSBanDangSD()
        {
            _con.Open();
            string sql = "select MaBan from ban where TrangThai = N'ĐangSD'";
            da = new SqlDataAdapter(sql, _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }

        // Lấy danh sách bàn chưa sử dụng
        public DataTable LayDSChuaSD()
        {
            _con.Open();
            string sql = "select MaBan from BAN where TrangThai = N'ChưaSD'";
            da = new SqlDataAdapter(sql, _con);
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
        public bool ThemBan(Ban maban)
        { 
                _con.Open();
                string sql = string.Format("INSERT INTO BAN VALUES(N'{0}',N'ChưaSD')", maban.MaBan);
                SqlCommand cmd = new SqlCommand(sql, _con);
                cmd.ExecuteNonQuery();
                _con.Close();
                return true;
        }
        public void LeftToRight(string maban)
        {
            _con.Open();
            string sql = string.Format("Update BAN SET TrangThai=N'ĐangSD' WHERE MABAN=N'{0}'", maban);
            cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();
            _con.Close();
        }

        public void RightToLeft(string maban)
        {
            _con.Open();
            string sql = string.Format("Update BAN SET TrangThai=N'ChưaSD' WHERE MABAN=N'{0}'", maban);
            cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();
            _con.Close();
        }
        public void XoaBan(string maban)
        {
            _con.Open();
            string sql = "UPDATE BAN SET TrangThai = N'Đã Hủy' WHERE MABAN = @maban";
            SqlCommand cmd = new SqlCommand(sql, _con);
            cmd.Parameters.AddWithValue("@maban", maban);
            cmd.ExecuteNonQuery();
            _con.Close();
        }
    }
}
