using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMart.DataAccessLayer.Repositories
{
    internal class ThuNganDB : IThuNganRepository
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

        public DataTable SearchData(string Msp, string TenSp, string PhanLoai)
        {
            string query = @"SELECT * FROM SanPham
                             WHERE Msp LIKE @Msp
                             AND TenSp LIKE @TenSp
                             AND PhanLoai LIKE @PhanLoai";
            SqlParameter[] parameters = {
                new SqlParameter("@Msp", "%" + Msp + "%"),
                new SqlParameter("@TenSp", "%" + TenSp + "%"),
                new SqlParameter("@PhanLoai", "%" + PhanLoai + "%")
            };
            return ExecuteQuery(query, parameters);
        }

        public string TruyvanHD()
        {
            string query = @"SELECT MAX(CAST(SUBSTRING(Mhd, 3, LEN(Mhd) - 2) AS INT)) AS MaxMhd
                     FROM HoaDon
                     WHERE Mhd LIKE 'HD%'";
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    int maxMhd = Convert.ToInt32(result);
                    return "HD" + (maxMhd + 1);
                }
                else
                {
                    return "HD1";
                }
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

        public void ThemHD(string Mhd, DateTime NgayXuat, string Msp, int SoLuong, float DonGia, float ThanhTien, string Mkh, string Mnv)
        {
            string query = @"INSERT INTO HoaDon (Mhd, NgayXuat, Msp, SoLuong, DonGia, ThanhTien, Mkh, Mnv)
                     VALUES (@Mhd, @NgayXuat, @Msp, @SoLuong, @DonGia,  @ThanhTien, @Mkh, @Mnv);
                     UPDATE SanPham SET SoLuong = SoLuong - @SoLuong WHERE Msp = @Msp;";
            try
            {
                database.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                cmd.Parameters.AddWithValue("@Mhd", Mhd);
                cmd.Parameters.AddWithValue("@NgayXuat", NgayXuat);
                cmd.Parameters.AddWithValue("@Msp", Msp);
                cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
                cmd.Parameters.AddWithValue("@DonGia", DonGia);
                cmd.Parameters.AddWithValue("@ThanhTien", ThanhTien);
                cmd.Parameters.AddWithValue("@Mkh", Mkh);
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

        public DataTable SearchDataKH(string Mkh)
        {
            string query = @"SELECT * FROM KhachHang WHERE Mkh LIKE @Mkh";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Mkh", "%" + Mkh + "%")
            };
            return ExecuteQuery(query, parameters);
        }
    }
}
