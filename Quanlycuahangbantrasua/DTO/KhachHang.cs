using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlycuahangbantrasua.DTO
{
    public class KhachHang
    {
        public string MaKhachHang { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public KhachHang()
        {

        }
        public KhachHang( string maKhachHang, string hoTen, string gioiTinh, string sDT )
        {
            this.MaKhachHang = maKhachHang;
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.SDT = sDT;
        }
    }
}
