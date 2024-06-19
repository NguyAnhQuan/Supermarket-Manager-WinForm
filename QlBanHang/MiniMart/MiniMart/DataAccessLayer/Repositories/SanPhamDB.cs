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
    internal class SanPhamDB
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

        public static DataTable SanPham()
        {
            string query = @"SELECT * FROM SanPham";
            return ExecuteQuery(query);
        }

        public static void AddNewEntry(string Msp, string Mncc, string TenSp, int SoLuong, int Gia, DateTime NgayNhap, DateTime HetHan, string HetHang, string PhanLoai)
        {
            string query = @"INSERT INTO SanPham (Msp, Mncc, TenSp, SoLuong, Gia, NgayNhap, HetHan, HetHang, PhanLoai)
                             VALUES (@Msp, @Mncc, @TenSp, @SoLuong, @Gia, @NgayNhap, @HetHan, @HetHang, @PhanLoai)";
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Msp", Msp);
                cmd.Parameters.AddWithValue("@Mncc", Mncc);
                cmd.Parameters.AddWithValue("@TenSp", TenSp);
                cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
                cmd.Parameters.AddWithValue("@Gia", Gia);
                cmd.Parameters.AddWithValue("@NgayNhap", NgayNhap);
                cmd.Parameters.AddWithValue("@HetHan", HetHan);
                cmd.Parameters.AddWithValue("@HetHang", HetHang);
                cmd.Parameters.AddWithValue("@PhanLoai", PhanLoai);
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

        public static void UpdateEntry(string Msp, string Mncc, string TenSp, int SoLuong, string Gia, DateTime NgayNhap, DateTime HetHan, string HetHang, string PhanLoai)
        {
            string query = @"UPDATE SanPham SET Mncc = @Mncc, TenSp = @TenSp, SoLuong = @SoLuong, NgayNhap = @NgayNhap,
                                HetHan = @HetHan, HetHang = @HetHang, PhanLoai = @PhanLoai
                             Gia = @Gia WHERE Msp = @Msp";
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Msp", Msp);
                cmd.Parameters.AddWithValue("@Mncc", Mncc);
                cmd.Parameters.AddWithValue("@TenSp", TenSp);
                cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
                cmd.Parameters.AddWithValue("@Gia", Gia);
                cmd.Parameters.AddWithValue("@NgayNhap", NgayNhap);
                cmd.Parameters.AddWithValue("@HetHan", HetHan);
                cmd.Parameters.AddWithValue("@HetHang", HetHang);
                cmd.Parameters.AddWithValue("@PhanLoai", PhanLoai);
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

        public static void DeleteEntry(string Msp)
        {
            try
            {
                //DeleteRelatedEntries(Msp);

                string query = @"DELETE FROM SanPham WHERE Msp = @Msp";
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Msp", Msp);
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


        //public static void DeleteRelatedEntries(string Msp)
        //{
        //    string query = @"DELETE FROM HoaDon WHERE Msp = @Msp;
        //                    DELETE FROM UuDai WHERE Msp = @Msp";
        //    try
        //    {
        //        database.OpenConnection();
        //        SqlCommand cmd = new SqlCommand(query, database.GetConnection());
        //        cmd.Parameters.AddWithValue("@Msp", Msp);
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




        public static DataTable SearchData(string Msp, string Mncc, string TenSp, string SoLuong, string Gia)
        {
            string query = $@"SELECT * FROM SanPham
                                where Msp like @Msp
                                and Mncc like @Mncc
                                and TenSp like @TenSp
                                and SoLuong like @SoLuong
                                and Gia like @Gia";
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Msp", "%" + Msp + "%");
                cmd.Parameters.AddWithValue("@Mncc", "%" + Mncc + "%");
                cmd.Parameters.AddWithValue("@TenSp", "%" + TenSp + "%");
                cmd.Parameters.AddWithValue("@SoLuong", "%" + SoLuong + "%");
                cmd.Parameters.AddWithValue("@Gia", "%" + Gia + "%");
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
