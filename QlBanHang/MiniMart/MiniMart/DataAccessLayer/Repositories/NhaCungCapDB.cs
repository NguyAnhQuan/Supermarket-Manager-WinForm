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
    internal class NhaCungCapDB
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

        public static DataTable NhaCungCap()
        {
            string query = @"SELECT * FROM NhaCungCap";
            return ExecuteQuery(query);
        }

        public static void AddNewEntry(string Mncc, string Ten, string DiaChi, int Sdt, string HopTac)
        {
            string query = @"INSERT INTO NhaCungCap (Mncc, Ten, DiaChi, Sdt, HopTac)
                             VALUES (@Mncc, @Ten, @DiaChi, @Sdt, @HopTac)";
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Mncc", Mncc);
                cmd.Parameters.AddWithValue("@Ten", Ten);
                cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                cmd.Parameters.AddWithValue("@Sdt", Sdt);
                cmd.Parameters.AddWithValue("@HopTac", HopTac);
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

        public static void UpdateEntry(string Mncc, string Ten, string DiaChi, int Sdt, string HopTac)
        {
            string query = @"UPDATE NhaCungCap SET Ten = @Ten, DiaChi = @DiaChi, Sdt = @Sdt, 
                             HopTac = @HopTac WHERE Mncc = @Mncc";
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Mncc", Mncc);
                cmd.Parameters.AddWithValue("@Ten", Ten);
                cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                cmd.Parameters.AddWithValue("@Sdt", Sdt);
                cmd.Parameters.AddWithValue("@HopTac", HopTac);
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

        public static void DeleteEntry(string Mncc)
        {
            try
            {
                DeleteRelatedEntries(Mncc);

                string query = @"DELETE FROM NhaCungCap WHERE Mncc = @Mncc";
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Mncc", Mncc);
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


        public static void DeleteRelatedEntries(string Mncc)
        {
            string query = @"DELETE FROM HoaDon WHERE Mncc = @Mncc;
                            DELETE FROM UuDai WHERE Mncc = @Mncc";
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Mncc", Mncc);
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




        public static DataTable SearchData(string Mncc, string Ten, string DiaChi, string Sdt, string HopTac)
        {
            string query = $@"SELECT * FROM NhaCungCap
                                where Mncc like @Mncc
                                and Ten like @Ten
                                and DiaChi like @DiaChi
                                and Sdt like @Sdt
                                and HopTac like @HopTac";
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Mncc", "%" + Mncc + "%");
                cmd.Parameters.AddWithValue("@Ten", "%" + Ten + "%");
                cmd.Parameters.AddWithValue("@DiaChi", "%" + DiaChi + "%");
                cmd.Parameters.AddWithValue("@Sdt", "%" + Sdt + "%");
                cmd.Parameters.AddWithValue("@HopTac", "%" + HopTac + "%");
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
