using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniMart.DataAccessLayer.Repositories
{
    internal class KhoDb
    {
        private static IDatabaseConnection database = new Database();

        // Phương thức chung cho việc thực thi truy vấn
        private static DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                // Mở kết nối
                database.OpenConnection();

                // Tạo và thực thi câu lệnh SQL
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                SqlDataReader reader = cmd.ExecuteReader();

                // Load dữ liệu vào DataTable
                dataTable.Load(reader);

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
            return dataTable;
        }

        // Phương thức con để lấy dữ liệu nhập
        public static DataTable DataNhap()
        {
            // Câu lệnh SQL để lấy dữ liệu nhập
            string query = @"SELECT * FROM KhoNX
                            WHERE Mnx LIKE 'KN%'";
            // Gọi phương thức thực thi truy vấn chung và trả về kết quả
            return ExecuteQuery(query);
        }

        // Phương thức con để lấy dữ liệu xuất
        public static DataTable DataXuat()
        {
            // Câu lệnh SQL để lấy dữ liệu xuất
            string query = @"SELECT * FROM KhoNX
                            WHERE Mnx LIKE 'KX%'";
            // Gọi phương thức thực thi truy vấn chung và trả về kết quả
            return ExecuteQuery(query);
        }
    }
}
