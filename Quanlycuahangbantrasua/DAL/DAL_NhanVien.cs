using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlycuahangbantrasua.DTO;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System.Windows.Forms;

namespace Quanlycuahangbantrasua.DAL
{
    public class DAL_NhanVien:DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //HIEN THI DANH SACH NHAN VIEN RA NGOAI MAN HINH
        public DataTable getNhanVien() 
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT *FROM NHANVIEN ORDER BY CASE WHEN ISNUMERIC(SUBSTRING(CAST(MANV AS VARCHAR), 1, LEN(CAST(MANV AS VARCHAR)))) = 1 THEN CAST(MANV AS INT) ELSE NULL END, HoTen", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        void thucthisql(string sql)
        {
            using (SqlConnection _con = new SqlConnection("Data Source=DESKTOP-8SU7OS9\\SQLEXPRESS;Initial Catalog=VMHQuanLyQuanTraSua;Integrated Security=True"))
            {
                _con.Open();
                cmd = new SqlCommand(sql, _con);
                cmd.ExecuteNonQuery();
                _con.Close();
            }
        }
        public bool themNV(NhanVien nv)
        {
            try
            {
                string ngay = string.Format("{0}-{1}-{2}", nv.NamSinh.Month, nv.NamSinh.Day, nv.NamSinh.Year);
                string sql = "INSERT INTO NhanVien VALUES(N'" + nv.HoTen + "',N'" + nv.SDT + "',N'" + nv.DiaChi + "','" + ngay + "',N'" + nv.GioiTinh + "','" + nv.MaChucVu + "','" + nv.TaiKhoan + "','" + nv.MatKhau + "')";
                thucthisql(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        public bool xoaNV(string hoTen)
        {
            try
            {
                string sql = "DELETE FROM NhanVien WHERE HoTen=N'" + hoTen + "'";
                thucthisql(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        public bool suaNV(NhanVien nv)
        {
            try
            {
                string ngay = string.Format("{0}/{1}/{2}", nv.NamSinh.Month, nv.NamSinh.Day, nv.NamSinh.Year);
                string sql = "UPDATE NhanVien SET HoTen= N'" + nv.HoTen + "', SDT='" + nv.SDT + "', DiaChi= N'" + nv.DiaChi + "', NamSinh='" + ngay + "', GioiTinh= N'" + nv.GioiTinh + "', MaChucVu='" + nv.MaChucVu + "', TaiKhoan='" + nv.TaiKhoan + "', MatKhau='" + nv.MatKhau + "' WHERE MANV='" + nv.MANV + "'";
                thucthisql(sql);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
    
}