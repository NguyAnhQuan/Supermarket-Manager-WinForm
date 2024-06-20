using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniMart.DataAccessLayer.Repositories
{
    internal class SanPhamDB
    {
        private static IDatabaseConnection database = new Database();

        private static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();
            try
            {
                database.OpenConnection();
                using (SqlCommand cmd = new SqlCommand(query, database.GetConnection()))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    SqlDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader);
                    reader.Close();
                }
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

        public static void AddNewEntry(string Msp, string Mncc, string TenSp, int SoLuong, float Gia, DateTime NgayNhap, DateTime HetHan, bool HetHang, string PhanLoai)
        {
            string query = @"INSERT INTO SanPham (Msp, Mncc, TenSp, SoLuong, Gia, NgayNhap, HetHan, HetHang, PhanLoai)
                             VALUES (@Msp, @Mncc, @TenSp, @SoLuong, @Gia, @NgayNhap, @HetHan, @HetHang, @PhanLoai)";
            SqlParameter[] parameters = {
                new SqlParameter("@Msp", Msp),
                new SqlParameter("@Mncc", Mncc),
                new SqlParameter("@TenSp", TenSp),
                new SqlParameter("@SoLuong", SoLuong),
                new SqlParameter("@Gia", Gia),
                new SqlParameter("@NgayNhap", NgayNhap),
                new SqlParameter("@HetHan", HetHan),
                new SqlParameter("@HetHang", HetHang),
                new SqlParameter("@PhanLoai", PhanLoai)
            };
            ExecuteQuery(query, parameters);
        }

        public static void UpdateEntry(string Msp, string Mncc, string TenSp, int SoLuong, float Gia, DateTime NgayNhap, DateTime HetHan, bool HetHang, string PhanLoai)
        {
            string query = @"UPDATE SanPham SET Mncc = @Mncc, TenSp = @TenSp, SoLuong = @SoLuong, NgayNhap = @NgayNhap,
                                HetHan = @HetHan, HetHang = @HetHang, PhanLoai = @PhanLoai
                             WHERE Msp = @Msp";
            SqlParameter[] parameters = {
                new SqlParameter("@Msp", Msp),
                new SqlParameter("@Mncc", Mncc),
                new SqlParameter("@TenSp", TenSp),
                new SqlParameter("@SoLuong", SoLuong),
                new SqlParameter("@Gia", Gia),
                new SqlParameter("@NgayNhap", NgayNhap),
                new SqlParameter("@HetHan", HetHan),
                new SqlParameter("@HetHang", HetHang),
                new SqlParameter("@PhanLoai", PhanLoai)
            };
            ExecuteQuery(query, parameters);
        }

        public static void DeleteEntry(string Msp)
        {
            string query = @"DELETE FROM SanPham WHERE Msp = @Msp";
            SqlParameter[] parameters = {
                new SqlParameter("@Msp", Msp)
            };
            ExecuteQuery(query, parameters);
        }

        public static DataTable SearchData(string Msp, string Mncc, string TenSp, int SoLuong, float Gia, DateTime NgayNhap, DateTime HetHan, bool HetHang, string PhanLoai)
        {
            string query = @"SELECT * FROM SanPham
                             WHERE Msp LIKE @Msp
                             AND Mncc LIKE @Mncc
                             AND TenSp LIKE @TenSp
                             AND SoLuong = @SoLuong
                             AND Gia = @Gia
                             AND NgayNhap = @NgayNhap
                             AND HetHan = @HetHan
                             AND HetHang LIKE @HetHang
                             AND PhanLoai LIKE @PhanLoai";
            SqlParameter[] parameters = {
                new SqlParameter("@Msp", "%" + Msp + "%"),
                new SqlParameter("@Mncc", "%" + Mncc + "%"),
                new SqlParameter("@TenSp", "%" + TenSp + "%"),
                new SqlParameter("@SoLuong", SoLuong),
                new SqlParameter("@Gia", Gia),
                new SqlParameter("@NgayNhap", NgayNhap),
                new SqlParameter("@HetHan", HetHan),
                new SqlParameter("@HetHang", "%" + HetHang + "%"),
                new SqlParameter("@PhanLoai", "%" + PhanLoai + "%")
            };
            return ExecuteQuery(query, parameters);
        }
    }
}
