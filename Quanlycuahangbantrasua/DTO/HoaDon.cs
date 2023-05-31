using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlycuahangbantrasua.DTO
{
    public class HoaDon
    {
            public string MaHoaDon { get; set; }
            public string MaKhachHang { get; set; }
            public string MANV { get; set; }
            public string MaBan { get; set; }
            public DateTime NgayXuatHoaDon { get; set; }
            public string TongTien { get; set; }   
        public HoaDon()
            {

            }
        public HoaDon(string maHoaDon, string maKhachHang, string maNV, string maBan, DateTime ngayXuatHoaDon, string tongTien)
        {
            this.MaHoaDon = maHoaDon;
            this.MaKhachHang = maKhachHang;
            this.MANV = maNV;
            this.MaBan = maBan;
            this.NgayXuatHoaDon = ngayXuatHoaDon;
            this.TongTien = tongTien;
        }
    }
}
