using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlycuahangbantrasua.DTO;
using System.Data;
using System.Data.SqlClient;


namespace Quanlycuahangbantrasua.DAL
{
    public class DAL_TaiKhoan
    {
        public bool CheckLogin(string userName, string password, out string error)
        {
            error = string.Empty;
            bool result = false;

            try
            {
                string connectionString = "Data Source=myServerAddress;Initial Catalog=myDataBase;User ID=myUsername;Password=myPassword;";
                using (SqlConnection connection = new SqlConnection(connectionString))
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
                        error = "Tài khoản hoặc mậtkhẩu không chính xác.";
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

