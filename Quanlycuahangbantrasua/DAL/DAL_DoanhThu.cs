using Quanlycuahangbantrasua.DTO;
using System;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Quanlycuahangbantrasua.DAL
{
    public class DAL_DoanhThu : DBConnect
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
        public DataTable LayDSHoaDonChoDoanhThuHomNay()
        {
            _con.Open();
            DateTime now = DateTime.Now;    
            string ngay = string.Format("{0}/{1}/{2}", now.Month, now.Day, now.Year);
            da = new SqlDataAdapter("select * from HOADON where NgayXuatHoaDon = '"+ ngay + "'",_con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        public DataTable LayDSHoaDonChoDoanhThuTuNgayDenNgay(DateTime ngayBD, DateTime ngayKT)
        {
            _con.Open();
            string ngaybd = string.Format("{0}/{1}/{2}", ngayBD.Month, ngayBD.Day, ngayBD.Year);
            string ngaykt = string.Format("{0}/{1}/{2}", ngayKT.Month, ngayKT.Day, ngayKT.Year);

            string sql = "select * from HOADON where NgayXuatHoaDon between '"+ ngaybd + "' and '"+ ngaykt + "'";
            da = new SqlDataAdapter(sql, _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
    }
}
