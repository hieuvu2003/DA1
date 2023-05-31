using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlycuahangbantrasua.DTO
{
    public class CTHD
    {
        public string MaHoaDon { get; set; }
        public string MaMonAn { get; set; }
        public string TenMonAn { get; set; }
        public string SoLuong { get; set; }
        public string DonGia { get; set; }
        public CTHD()
        {

        }
        public CTHD(string maHoaDon, string maMonAn, string tenMonAn, string soLuong, string donGia)
        {
            this.MaHoaDon = maHoaDon;
            this.MaMonAn = maMonAn;
            this.TenMonAn = tenMonAn;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
        }

    }
}
