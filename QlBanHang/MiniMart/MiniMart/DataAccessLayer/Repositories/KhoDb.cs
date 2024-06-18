using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniMart.DataAccessLayer.Repositories
{
    internal class KhoDb
    {
        private static IDatabaseConnection database = new Database();

        private static DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                SqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                database.CloseConnection();
            }
            return dataTable;
        }

        public static DataTable DataNhap()
        {
            string query = @"SELECT * FROM KhoNX WHERE Mnx LIKE 'KN%'";
            return ExecuteQuery(query);
        }

        public static DataTable DataXuat()
        {
            string query = @"SELECT * FROM KhoNX WHERE Mnx LIKE 'KX%'";
            return ExecuteQuery(query);
        }

        public static Database SanPhamHetHan()
        {
            string query = @"SELECT * FROM SanPham WHERE HetHan < GETDATE()";
            return ExecuteQuery(query);
        }

        public static bool CheckDuplicate(string mnx)
        {
            string query = @"SELECT COUNT(*) FROM KhoNX WHERE Mnx = @Mnx";
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Mnx", mnx);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                database.CloseConnection();
            }
        }

        public static void AddNewEntry(string mnx, string msp, string mncc, int soLuong, decimal tongGia, DateTime thoiGian)
        {
            string query = @"INSERT INTO KhoNX (Mnx, Msp, Mncc, SoLuong, TongGia, ThoiGian)
                             VALUES (@Mnx, @Msp, @Mncc, @SoLuong, @TongGia, @ThoiGian)";
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Mnx", mnx);
                cmd.Parameters.AddWithValue("@Msp", msp);
                cmd.Parameters.AddWithValue("@Mncc", mncc);
                cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                cmd.Parameters.AddWithValue("@TongGia", tongGia);
                cmd.Parameters.AddWithValue("@ThoiGian", thoiGian);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                database.CloseConnection();
            }
        }

        public static void UpdateEntry(string mnx, string msp, string mncc, int soLuong, decimal tongGia, DateTime thoiGian)
        {
            string query = @"UPDATE KhoNX SET Msp = @Msp, Mncc = @Mncc, SoLuong = @SoLuong, 
                             TongGia = @TongGia, ThoiGian = @ThoiGian WHERE Mnx = @Mnx";
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Mnx", mnx);
                cmd.Parameters.AddWithValue("@Msp", msp);
                cmd.Parameters.AddWithValue("@Mncc", mncc);
                cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                cmd.Parameters.AddWithValue("@TongGia", tongGia);
                cmd.Parameters.AddWithValue("@ThoiGian", thoiGian);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                database.CloseConnection();
            }
        }

        public static void DeleteEntry(string mnx)
        {
            string query = @"DELETE FROM KhoNX WHERE Mnx = @Mnx";
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Mnx", mnx);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                database.CloseConnection();
            }
        }

        public static DataTable SearchData(string columnName, string keyword, DateTime fromDate, DateTime toDate)
        {
            string query = $@"SELECT * FROM KhoNX
                              WHERE {columnName} LIKE @Keyword
                              AND ThoiGian BETWEEN @FromDate AND @ToDate";
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                cmd.Parameters.AddWithValue("@FromDate", fromDate);
                cmd.Parameters.AddWithValue("@ToDate", toDate);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
            finally
            {
                database.CloseConnection();
            }
        }
    }
}
