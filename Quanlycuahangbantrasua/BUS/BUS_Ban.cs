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
    public class BUS_Ban
    {
        DAL_Ban dalb = new DAL_Ban();
        public DataTable getBan()
        {
            return dalb.getBan();
        }
        public DataTable LayDSBanDangSD()
        {
            return dalb.LayDSBanDangSD();
        }
        public DataTable LayDSBanChuaSD()
        {
            return dalb.LayDSChuaSD();
        }
        public bool ThemBan(Ban maban)
        {
            return dalb.ThemBan(maban);
        }
        public void LeftToRight(string maban)
        {
            dalb.LeftToRight(maban); // gọi đến phương thức LeftToRight() của lớp DAL_Ban
        }

        public void RightToLeft(string maban)
        {
            dalb.RightToLeft(maban); // gọi đến phương thức RightToLeft() của lớp DAL_Ban
        }
        public bool XoaBan(string maBan)
        {
            try
            {
                dalb.XoaBan(maBan);
                return true; // trả về true nếu xóa bàn thành công
            }
            catch (Exception ex)
            {
                // xử lý ngoại lệ nếu có
                return false; // trả về false nếu xóa bàn thất bại
            }
        }

    }
}
