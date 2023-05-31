using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlycuahangbantrasua.DTO
{
    public class Ban
    {
        public string MaBan { get; set; }
        public string TrangThai { get; set; }

        public Ban()
        {

        }

        public Ban(string maBan, string trangThai)
        {
            this.MaBan = maBan;
            this.TrangThai = trangThai;
        }
    }
}
