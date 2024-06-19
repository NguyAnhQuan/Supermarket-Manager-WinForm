using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMart.DataAccessLayer.Repositories
{
    internal class KhachHangDB
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

        public static DataTable KhachHang()
        {
            string query = @"SELECT * FROM KhachHang";
            return ExecuteQuery(query);
        }

        public static void AddNewEntry(string Mkh, string HoTen, string DiaChi, int Sdt, string HangKhach)
        {
            string query = @"INSERT INTO KhachHang (Mkh, HoTen, DiaChi, Sdt, HangKhach)
                             VALUES (@Mkh, @HoTen, @DiaChi, @Sdt, @HangKhach)";
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Mkh", Mkh);
                cmd.Parameters.AddWithValue("@HoTen", HoTen);
                cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                cmd.Parameters.AddWithValue("@Sdt", Sdt);
                cmd.Parameters.AddWithValue("@HangKhach", HangKhach);
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

        public static void UpdateEntry(string Mkh, string HoTen, string DiaChi, int Sdt, string HangKhach)
        {
            string query = @"UPDATE KhachHang SET HoTen = @HoTen, DiaChi = @DiaChi, Sdt = @Sdt, 
                             HangKhach = @HangKhach WHERE Mkh = @Mkh";
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Mkh", Mkh);
                cmd.Parameters.AddWithValue("@HoTen", HoTen);
                cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                cmd.Parameters.AddWithValue("@Sdt", Sdt);
                cmd.Parameters.AddWithValue("@HangKhach", HangKhach);
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

        public static void DeleteEntry(string Mkh)
        {
            try
            {
                DeleteRelatedEntries(Mkh);

                string query = @"DELETE FROM KhachHang WHERE Mkh = @Mkh";
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Mkh", Mkh);
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


        public static void DeleteRelatedEntries(string Mkh)
        {
            string query = @"DELETE FROM HoaDon WHERE Mkh = @Mkh;
                            DELETE FROM UuDai WHERE Mkh = @Mkh";
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Mkh", Mkh);
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




        public static DataTable SearchData(string Mkh, string HoTen, string DiaChi, string Sdt, string HangKhach)
        {
            string query = $@"SELECT * FROM KhachHang
                                where Mkh like @Mkh
                                and HoTen like @HoTen
                                and DiaChi like @DiaChi
                                and Sdt like @Sdt
                                and HangKhach like @HangKhach";
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Mkh","%" + Mkh + "%");
                cmd.Parameters.AddWithValue("@HoTen", "%" + HoTen + "%");
                cmd.Parameters.AddWithValue("@DiaChi", "%" + DiaChi + "%");
                cmd.Parameters.AddWithValue("@Sdt", "%" + Sdt + "%");
                cmd.Parameters.AddWithValue("@HangKhach", "%" + HangKhach + "%");
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
