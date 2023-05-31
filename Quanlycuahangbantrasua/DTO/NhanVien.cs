using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlycuahangbantrasua.DTO
{
     public class NhanVien
    {
        public string MANV { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public DateTime NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string MaChucVu { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public NhanVien() 
        {

        }
        public NhanVien(string maNV, string hoTen, string sDT, string diaChi, DateTime namSinh, string gioiTinh, string maChucVu, string taiKhoan, string matKhau)
        {
            this.MANV = maNV;
            this.HoTen = hoTen;
            this.SDT = sDT;
            this.DiaChi = diaChi;
            this.NamSinh = namSinh;
            this.GioiTinh = gioiTinh;
            this.MaChucVu = maChucVu;
            this.TaiKhoan = taiKhoan;
            this.MatKhau = matKhau;
        }
    }
}
