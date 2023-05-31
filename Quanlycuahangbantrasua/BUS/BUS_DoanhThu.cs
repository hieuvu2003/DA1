using System.Text;
using System.Threading.Tasks;
using Quanlycuahangbantrasua.DAL;
using Quanlycuahangbantrasua.DTO;
using System.Data;
using System.Data.SqlClient;
using System;

namespace Quanlycuahangbantrasua.BUS
{
    public class BUS_DoanhThu
    {
        DAL_HoaDon dalhd = new DAL_HoaDon();
        DAL_DoanhThu doanhThu = new DAL_DoanhThu();
        public DataTable getHoaDon()
        {
            return dalhd.getHoaDon();
        }
        public DataTable LayDSHoaDonChoDoanhThuHomNay()
        {
            return doanhThu.LayDSHoaDonChoDoanhThuHomNay();
        }
        public DataTable LayDSHoaDonChoDoanhThuTuNgayDenNgay(DateTime ngayBD, DateTime ngayKT)
        {
            return doanhThu.LayDSHoaDonChoDoanhThuTuNgayDenNgay(ngayBD,ngayKT);
        }
    }
 
}
    
