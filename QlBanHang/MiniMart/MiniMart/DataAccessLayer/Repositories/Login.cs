using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMart.DataAccessLayer.Repositories
{
    internal class Login
    {
        private static SqlConnection con = database.GetConnection();

        // Phương thức để kiểm tra đăng nhập
        public static bool KiemTraDangNhap(string maDangNhap, string matKhau)
        {
            bool isValid = false;
            try
            {
                // Mở kết nối
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Tạo câu lệnh SQL để kiểm tra đăng nhập
                string query = "SELECT COUNT(*) FROM DangNhap WHERE Mdn = @maDangNhap AND MatKhau = @matKhau";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@maDangNhap", maDangNhap);
                cmd.Parameters.AddWithValue("@matKhau", matKhau);

                // Thực thi câu lệnh SQL
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    isValid = true;
                }
            }
            catch (Exception ex)
            {
                // Xử lý exception
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối sau khi thực hiện xong
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return isValid;
        }
    }
}
