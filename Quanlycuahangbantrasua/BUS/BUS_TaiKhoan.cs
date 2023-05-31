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
    public class BUS_TaiKhoan
    {
        private readonly string _connectionString;
        public BUS_TaiKhoan(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool checklogin(string userName, string password, out string error)
        {
            error = string.Empty;
            bool result = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM NHANVIEN WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TaiKhoan", userName);
                    command.Parameters.AddWithValue("@MatKhau", password);

                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        result = true;
                    }
                    else
                    {
                        error = "Tài khoản hoặc mật khẩu không chính xác.";
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return result;
        }
    }
}

