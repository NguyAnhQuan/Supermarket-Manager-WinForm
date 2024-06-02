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
        // Khai báo chuỗi kết nối từ file database.cs
        private static SqlConnection con = database.GetConnection();

        // Phương thức để kiểm tra đăng nhập và lấy chức vụ
        public static string KiemTraDangNhapVaLayChucVu(string maDangNhap, string matKhau)
        {
            string chucVu = null;
            try
            {
                // Mở kết nối
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                // Tạo câu lệnh SQL để kiểm tra đăng nhập và lấy chức vụ
                string query = @"
                    SELECT nv.ChucVu 
                    FROM DangNhap dn
                    JOIN NhanVien nv ON dn.Mnv = nv.Mnv
                    WHERE dn.Mdn = @maDangNhap AND dn.MatKhau = @matKhau";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@maDangNhap", maDangNhap);
                cmd.Parameters.AddWithValue("@matKhau", matKhau);

                // Thực thi câu lệnh SQL và lấy chức vụ
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    chucVu = reader["ChucVu"].ToString();
                }
                reader.Close();
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
            return chucVu;
        }
    }
}
