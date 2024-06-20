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
    internal class AdminDB
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

        public static DataTable DangNhap()
        {
            string query = @"SELECT * FROM DangNhap";
            return ExecuteQuery(query);
        }

        public static void AddNewEntry(string Mdn, string Mnv,  DateTime Giovao, DateTime GioRa, string MatKhau)
        {
            string query = @"INSERT INTO DangNhap (Mdn, Mnv, GioVao, GioRa, MatKhau)
                             VALUES (@Mdn, @Mnv, @GioVao, @GioRa, @MatKhau)";
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Mdn", Mdn);
                cmd.Parameters.AddWithValue("@Mnv", Mnv);
                cmd.Parameters.AddWithValue("@Giovao", Giovao);
                cmd.Parameters.AddWithValue("@GioRa", GioRa);
                cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
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

        public static void UpdateEntry(string Mdn, string Mnv, DateTime Giovao, DateTime GioRa, string MatKhau)
        {
            string query = @"UPDATE DangNhap SET Mnv = @Mnv, Giovao = @Giovao, GioRa = @GioRa, MatKhau = @MatKhau  WHERE Mdn = @Mdn";
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Mdn", Mdn);
                cmd.Parameters.AddWithValue("@Mnv", Mnv);
                cmd.Parameters.AddWithValue("@Giovao", Giovao);
                cmd.Parameters.AddWithValue("@GioRa", GioRa);
                cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
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

        public static void DeleteEntry(string Mdn)
        {
            try
            {
                string query = @"DELETE FROM DangNhap WHERE Mdn = @Mdn";
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Mdn", Mdn);
                int rowsAffected = cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully! Rows affected: " + rowsAffected);
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




        //public static void DeleteRelatedEntries(string Mdn)
        //{
        //    string query = @"DELETE FROM HoaDon WHERE Mdn = @Mdn;
        //                    DELETE FROM UuDai WHERE Mdn = @Mdn";
        //    try
        //    {
        //        database.OpenConnection();
        //        SqlCommand cmd = new SqlCommand(query, database.GetConnection());
        //        cmd.Parameters.AddWithValue("@Mdn", Mdn);
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        //    finally
        //    {
        //        database.CloseConnection();
        //    }
        //}




        public static DataTable SearchData(string Mdn, string Mnv, DateTime? Giovao, DateTime? GioRa, string MatKhau)
        {
            StringBuilder query = new StringBuilder("SELECT * FROM DangNhap WHERE 1=1");

            if (!string.IsNullOrEmpty(Mdn))
                query.Append(" AND Mdn LIKE @Mdn");
            if (!string.IsNullOrEmpty(Mnv))
                query.Append(" AND Mnv LIKE @Mnv");
            if (Giovao.HasValue)
                query.Append(" AND CONVERT(date, Giovao) = CONVERT(date, @Giovao)");
            if (GioRa.HasValue)
                query.Append(" AND CONVERT(date, GioRa) = CONVERT(date, @GioRa)");
            if (!string.IsNullOrEmpty(MatKhau))
                query.Append(" AND MatKhau LIKE @MatKhau");

            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query.ToString(), database.GetConnection());

                if (!string.IsNullOrEmpty(Mdn))
                    cmd.Parameters.AddWithValue("@Mdn", "%" + Mdn + "%");
                if (!string.IsNullOrEmpty(Mnv))
                    cmd.Parameters.AddWithValue("@Mnv", "%" + Mnv + "%");
                if (Giovao.HasValue)
                    cmd.Parameters.AddWithValue("@Giovao", Giovao.Value);
                if (GioRa.HasValue)
                    cmd.Parameters.AddWithValue("@GioRa", GioRa.Value);
                if (!string.IsNullOrEmpty(MatKhau))
                    cmd.Parameters.AddWithValue("@MatKhau", "%" + MatKhau + "%");

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
