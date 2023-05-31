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
    public class DAL_Menu : DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //HIEN THI DANH SACH MENU RA NGOAI MAN HINH
        public DataTable getMeNu()
        {
            _con.Open();
            da = new SqlDataAdapter("SELECT * FROM MENU ORDER BY CASE WHEN ISNUMERIC(SUBSTRING(CAST(MANV AS VARCHAR), 1, LEN(CAST(MANV AS VARCHAR)))) = 1 THEN CAST(MANV AS INT) ELSE NULL END, TenMonAn", _con);
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
        public bool themMN(string maMonAn, string tenMonAn, string moTa, string donGia, string maNV)
        {
                string sql = "INSERT INTO Menu VALUES (N'" + maMonAn + "', N'" + tenMonAn + "', N'" + moTa + "', '" + donGia + "', '" + maNV + "')";
                thucthisql(sql);
                return true;
        }
        public bool xoaMN(string maMonAn)
        {
                string sql = "DELETE FROM MENU WHERE MaMonAn =N'" + maMonAn + "'";
                thucthisql(sql);
                return true;
        }
        public bool SuaMN(string maMonAn, string tenMonAn, string moTa, string donGia, string maNV)
        {

            _con.Open();
            string sql = "UPDATE MENU SET MaMonAn = N'" + maMonAn + "', TenMonAn = '" + tenMonAn + "',MoTa = '" + moTa + "', DonGia = '" + donGia + "', MaNV = '" + maNV + "' WHERE MaMonAn = '" + maMonAn + "'";
            SqlCommand cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();
            _con.Close();
            return true;
        }  
    }
}
