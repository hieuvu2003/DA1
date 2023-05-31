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
    public class BUS_KhachHang
    {
        DAL_KhachHang dalkh = new DAL_KhachHang();
        public DataTable getKhachHang()
        {
            return dalkh.getKhachHang();
        }
        public bool themKH(KhachHang kh)
        {
            return dalkh.themKH(kh);
        }
        public bool xoaKH(string maKhachHang)
        {
            return dalkh.xoaKH(maKhachHang);
        }
        public bool suaKH(KhachHang kh)
        {
            return dalkh.suaKH(kh);
        }
    }
}
