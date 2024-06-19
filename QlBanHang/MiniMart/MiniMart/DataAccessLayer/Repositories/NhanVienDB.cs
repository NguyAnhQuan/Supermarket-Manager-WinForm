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
    internal class NhanVienDB
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

        public static DataTable NhanVien()
        {
            string query = @"SELECT * FROM NhanVien";
            return ExecuteQuery(query);
        }

        public static void AddNewEntry(string Mnv, string Sdt, string SinhNhat, string DiaChi, string HoTen, string GioiTinh, string ChucVu, float Luong)
        {
            string query = @"INSERT INTO NhanVien (Mnv, Sdt, SinhNhat, DiaChi, HoTen, GioiTinh, ChucVu, Luong)
                             VALUES (@Mnv, @DiaChi, @SinhNhat, @DiaChi, @HoTen,  @GioiTinh, @ChucVu, @Luong)";
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Mnv", Mnv);
                cmd.Parameters.AddWithValue("@DiaChi", Sdt);
                cmd.Parameters.AddWithValue("@SinhNhat", SinhNhat);
                cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                cmd.Parameters.AddWithValue("@HoTen", HoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                cmd.Parameters.AddWithValue("@ChucVu", ChucVu);
                cmd.Parameters.AddWithValue("@Luong", Luong);
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

        public static void UpdateEntry(string Mnv, string Sdt, string SinhNhat, string DiaChi, string HoTen, string GioiTinh, string ChucVu, float Luong)
        {
            string query = @"UPDATE NhanVien SET Sdt = @Sdt, SinhNhat = @SinhNhat, DiaChi = @DiaChi, HoTen = @HoTen, GioiTinh = @GioiTinh, ChucVu = @ChucVu, Luong = @Luong,  WHERE Mnv = @Mnv";
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Mnv", Mnv);
                cmd.Parameters.AddWithValue("@DiaChi", Sdt);
                cmd.Parameters.AddWithValue("@SinhNhat", SinhNhat);
                cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                cmd.Parameters.AddWithValue("@HoTen", HoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                cmd.Parameters.AddWithValue("@ChucVu", ChucVu);
                cmd.Parameters.AddWithValue("@Luong", Luong);
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

        public static void DeleteEntry(string Mnv)
        {
            try
            {
                //DeleteRelatedEntries(Mnv);

                string query = @"DELETE FROM NhanVien WHERE Mnv = @Mnv";
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Mnv", Mnv);
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


        //public static void DeleteRelatedEntries(string Mnv)
        //{
        //    string query = @"DELETE FROM HoaDon WHERE Mnv = @Mnv;
        //                    DELETE FROM UuDai WHERE Mnv = @Mnv";
        //    try
        //    {
        //        database.OpenConnection();
        //        SqlCommand cmd = new SqlCommand(query, database.GetConnection());
        //        cmd.Parameters.AddWithValue("@Mnv", Mnv);
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




        public static DataTable SearchData(string Mnv, string Sdt, string SinhNhat, string DiaChi, string HoTen, string GioiTinh, string ChucVu, float Luong)
        {
            string query = $@"SELECT * FROM NhanVien
                                where Mnv like @Mnv
                                and Sdt like @Sdt
                                and SinhNhat like @SinhNhat
                                and DiaChi like @DiaChi
                                and HoTen like @HoTen
                                and GioiTinh like @GioiTinh
                                and ChucVu like @ChucVu
                                and Luong like @Luong";
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Mnv","%" + Mnv + "%");
                cmd.Parameters.AddWithValue("@DiaChi","%" + Sdt + "%");
                cmd.Parameters.AddWithValue("@SinhNhat", "%" + SinhNhat + "%");
                cmd.Parameters.AddWithValue("@DiaChi", "%" + DiaChi + "%"); 
                cmd.Parameters.AddWithValue("@HoTen", "%" + HoTen + "%");
                cmd.Parameters.AddWithValue("@GioiTinh", "%" + GioiTinh + "%");
                cmd.Parameters.AddWithValue("@ChucVu", "%" + ChucVu + "%");
                cmd.Parameters.AddWithValue("@Luong", "%" + Luong + "%");
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
