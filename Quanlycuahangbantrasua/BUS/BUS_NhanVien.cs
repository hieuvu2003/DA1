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
    public class BUS_NhanVien
    {
        DAL_NhanVien dalnv = new DAL_NhanVien();
        public DataTable getNhanVien() 
        { 
            return dalnv.getNhanVien();
        }
        public bool themNV(NhanVien nv)
        {
            return dalnv.themNV(nv);
        }
        public bool suaNV(NhanVien nv)
        {
            return dalnv.suaNV(nv);
        }
        public bool xoaNV(string hoTen)
        {
            return dalnv.xoaNV(hoTen);
        }
    }
}
