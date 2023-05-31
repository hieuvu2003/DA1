using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlycuahangbantrasua.DAL;
using Quanlycuahangbantrasua.DTO;
using System.Data;
using System.Data.SqlClient;

namespace Quanlycuahangbantrasua.BUS
{
    public class BUS_HoaDon
    {
        DAL_HoaDon dalhd = new DAL_HoaDon();
        public DataTable getHoaDon()
        {
            return dalhd.getHoaDon();
        }
        public bool ThemHoaDon(string maHoaDon, string maKhachHang, int maNV, string maBan, string ngayXuatHoaDon, double tongTien)
        {
            return dalhd.ThemHoaDon(maHoaDon, maKhachHang, maNV, maBan, ngayXuatHoaDon, tongTien);
        }
        public bool SuaHoaDon(string maHoaDon, string maKhachHang, int maNV, string maBan, string ngayXuatHoaDon, int tongTien)
        {
            return dalhd.SuaHoaDon(maHoaDon, maKhachHang, maNV, maBan, ngayXuatHoaDon, tongTien);
        }
        public bool xoaHoaDon(string maHoaDon)
        {
            return dalhd.xoaHoaDon(maHoaDon);
        }
        //public bool timHoaDon(string maHoaDon)
        //{
        //    return dalhd.timHoaDon(maHoaDon);
        //}
        public DataTable TimKiem(string maHoaDon)
        {
            return dalhd.TimKiem(maHoaDon);
        }
    }
}
