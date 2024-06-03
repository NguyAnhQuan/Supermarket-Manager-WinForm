using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniMart.DataAccessLayer.Repositories
{
    internal class Login
    {
        private static IDatabaseConnection database = new Database();

        // Phương thức để kiểm tra đăng nhập và lấy chức vụ
        public static string KiemTraDangNhapVaLayChucVu(string maDangNhap, string matKhau)
        {
            string chucVuin = null;
            try
            {
                // Mở kết nối
                database.OpenConnection();

                // Tạo câu lệnh SQL để kiểm tra đăng nhập và lấy chức vụ
                string query = @"
                    SELECT  LEFT(nv.ChucVu, CHARINDEX(' ', nv.ChucVu) - 1) AS ChucVu
                    FROM DangNhap dn
                    JOIN NhanVien nv ON dn.Mnv = nv.Mnv
                    WHERE dn.Mdn = @maDangNhap AND dn.MatKhau = @matKhau";
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@maDangNhap", maDangNhap);
                cmd.Parameters.AddWithValue("@matKhau", matKhau);

                // Thực thi câu lệnh SQL và lấy chức vụ
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    chucVuin = reader["ChucVu"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Xử lý exception
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối sau khi thực hiện xong
                database.CloseConnection();
            }
            return chucVuin;
        }

        public static (string, string, string) GetMnvChucVu(string chucVuout)
        {
            string mnv = null;
            string chucVu = null;
            string hoten = null;
            try
            {
                // Mở kết nối
                database.OpenConnection();

                // Tạo câu lệnh SQL để kiểm tra chức vụ
                string query = @"
                    SELECT Mnv, ChucVu, HoTen
                    FROM NhanVien
                    WHERE ChucVu LIKE @chucVu + '%'";
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@chucVu", chucVuout);

                // Thực thi câu lệnh SQL và lấy chức vụ, Mnv, hoten
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    chucVu = reader["ChucVu"].ToString();
                    mnv = reader["Mnv"].ToString();
                    hoten = reader["HoTen"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                // Xử lý exception
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối sau khi thực hiện xong
                database.CloseConnection();
            }
            return (chucVu, mnv, hoten);
        }
    }
}
