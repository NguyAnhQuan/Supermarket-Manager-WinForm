using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniMart.DataAccessLayer.Repositories
{
    internal class NhanVienDB : INhanVienRepository
    {
        private static readonly IDatabaseConnection database = new Database();

        public DataTable GetNhanVien()
        {
            string query = @"SELECT * FROM NhanVien";
            return ExecuteQuery(query);
        }

        public void AddNewEntry(string Mnv, string Sdt, DateTime SinhNhat, string DiaChi, string HoTen, string GioiTinh, string ChucVu, float Luong)
        {
            string query = @"INSERT INTO NhanVien (Mnv, Sdt, SinhNhat, DiaChi, HoTen, GioiTinh, ChucVu, Luong)
                             VALUES (@Mnv, @Sdt, @SinhNhat, @DiaChi, @HoTen,  @GioiTinh, @ChucVu, @Luong)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Mnv", Mnv),
                new SqlParameter("@Sdt", Sdt),
                new SqlParameter("@SinhNhat", SinhNhat),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@HoTen", HoTen),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@ChucVu", ChucVu),
                new SqlParameter("@Luong", Luong)
            };
            ExecuteNonQuery(query, parameters);
        }

        public void UpdateEntry(string Mnv, string Sdt, DateTime SinhNhat, string DiaChi, string HoTen, string GioiTinh, string ChucVu, float Luong)
        {
            string query = @"UPDATE NhanVien SET Sdt = @Sdt, SinhNhat = @SinhNhat, DiaChi = @DiaChi, HoTen = @HoTen, GioiTinh = @GioiTinh, ChucVu = @ChucVu, Luong = @Luong  WHERE Mnv = @Mnv";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Mnv", Mnv),
                new SqlParameter("@Sdt", Sdt),
                new SqlParameter("@SinhNhat", SinhNhat),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@HoTen", HoTen),
                new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@ChucVu", ChucVu),
                new SqlParameter("@Luong", Luong)
            };
            ExecuteNonQuery(query, parameters);
        }

        public void DeleteEntry(string Mnv)
        {
            string query = @"DELETE FROM NhanVien WHERE Mnv = @Mnv";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Mnv", Mnv)
            };
            ExecuteNonQuery(query, parameters);
        }

        public DataTable SearchData(string Mnv, string Sdt, string DiaChi, string HoTen, string GioiTinh, string ChucVu, float Luong)
        {
            string query = @"SELECT * FROM NhanVien
                             WHERE Mnv LIKE @Mnv
                             AND Sdt LIKE @Sdt
                             AND DiaChi LIKE @DiaChi
                             AND HoTen LIKE @HoTen
                             AND GioiTinh LIKE @GioiTinh
                             AND ChucVu LIKE @ChucVu
                             AND Luong LIKE @Luong";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Mnv", "%" + Mnv + "%"),
                new SqlParameter("@Sdt", "%" + Sdt + "%"),
                new SqlParameter("@DiaChi", "%" + DiaChi + "%"),
                new SqlParameter("@HoTen", "%" + HoTen + "%"),
                new SqlParameter("@GioiTinh", "%" + GioiTinh + "%"),
                new SqlParameter("@ChucVu", "%" + ChucVu + "%"),
                new SqlParameter("@Luong", "%" + Luong + "%")
            };
            return ExecuteQuery(query, parameters);
        }

        private static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
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

        private static void ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
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
    }
}
