using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlycuahangbantrasua.DTO
{
    public class Menu
    {
        public string MaMonAn { get; set; }
        public string TenMonAn { get; set; }
        public string MoTa { get; set; }
        public string DonGia { get; set; }
        public string MANV { get; set; }
        public Menu()
        {

        }
        public Menu (string maMonAn, string tenMonAn, string moTa, string donGia, string maNV)
        {
            this.MaMonAn = maMonAn;
            this.TenMonAn = tenMonAn;
            this.MoTa = moTa;
            this.DonGia = donGia;
            this.MANV = maNV;
        }
    }
}
