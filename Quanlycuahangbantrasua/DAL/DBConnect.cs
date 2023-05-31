using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Quanlycuahangbantrasua.DTO;
using System.Data.SqlClient;

namespace Quanlycuahangbantrasua.DAL
{
    public class DBConnect
    {
        protected SqlConnection _con=new SqlConnection("Data Source=DESKTOP-8SU7OS9\\SQLEXPRESS;Initial Catalog=VMHQuanLyQuanTraSua;Integrated Security=True");
    }
}
