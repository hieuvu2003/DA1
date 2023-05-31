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
    public class BUS_CTHD
    {
        DAL_CTHD dalcthd = new DAL_CTHD();
        public DataTable getCTHD()
        {
            return dalcthd.getCTHD();
        }
        public bool ThemCTHD(string maHoaDon, string maMonAn, string tenMonAn, int soLuong, string donGia)
        {
            return dalcthd.ThemCTHD(maHoaDon, maMonAn, tenMonAn, soLuong, donGia);
        }
        public DataTable TimKiem(string maHoaDon)
        {
            return dalcthd.TimKiem(maHoaDon);
        }
    }
}
