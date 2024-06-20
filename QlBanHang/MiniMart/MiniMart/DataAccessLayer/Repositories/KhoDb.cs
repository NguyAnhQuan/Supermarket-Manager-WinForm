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

        public static void AddNewEntry(string mnx, string msp, string mncc, int soLuong, decimal tongGia, DateTime thoiGian)
        {
            string queryInsertKhoNX = @"INSERT INTO KhoNX (Mnx, Msp, Mncc, SoLuong, TongGia, ThoiGian)
                                 VALUES (@Mnx, @Msp, @Mncc, @SoLuong, @TongGia, @ThoiGian)";

            string queryUpdateSanPham = @"UPDATE SanPham SET SoLuong = SoLuong + @SoLuong WHERE Msp = @Msp";

            try
            {
                database.OpenConnection();

                // Thêm mới vào bảng KhoNX
                SqlCommand cmdInsert = new SqlCommand(queryInsertKhoNX, database.GetConnection());
                cmdInsert.Parameters.AddWithValue("@Mnx", mnx);
                cmdInsert.Parameters.AddWithValue("@Msp", msp);
                cmdInsert.Parameters.AddWithValue("@Mncc", mncc);
                cmdInsert.Parameters.AddWithValue("@SoLuong", soLuong);
                cmdInsert.Parameters.AddWithValue("@TongGia", tongGia);
                cmdInsert.Parameters.AddWithValue("@ThoiGian", thoiGian);
                cmdInsert.ExecuteNonQuery();

                // Cập nhật số lượng trong bảng SanPham
                SqlCommand cmdUpdate = new SqlCommand(queryUpdateSanPham, database.GetConnection());
                cmdUpdate.Parameters.AddWithValue("@Msp", msp);
                cmdUpdate.Parameters.AddWithValue("@SoLuong", soLuong);
                cmdUpdate.ExecuteNonQuery();
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
            try
            {
                DeleteRelatedEntries(mnx);

                string query = @"DELETE FROM KhoNX WHERE Mnx = @Mnx";
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


        public static void DeleteRelatedEntries(string mnx)
        {
            string query = @"DELETE FROM NganSach WHERE Mnx = @Mnx";
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
