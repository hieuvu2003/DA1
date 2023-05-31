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
    public class BUS_Menu
    {
        DAL_Menu dalmn = new DAL_Menu();

        public DataTable getMeNu()
        {
            return dalmn.getMeNu();
        }
        public bool themMN(string maMonAn, string tenMonAn, string moTa, string donGia, string maNV)
        {
            return dalmn.themMN(maMonAn, tenMonAn, moTa, donGia, maNV);
        }
        public bool xoaMN(string maMonAn)
        {
            return dalmn.xoaMN(maMonAn);
        }
        public bool SuaMN(string maMonAn, string tenMonAn, string moTa, string donGia, string maNV)
        {
            return dalmn.SuaMN(maMonAn, tenMonAn, moTa, donGia, maNV);
        }
    }
    
}
