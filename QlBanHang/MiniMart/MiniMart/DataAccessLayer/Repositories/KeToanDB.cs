using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniMart.DataAccessLayer.Repositories
{
    internal class KeToanDB
    {
        private Database database;

        public KeToanDB()
        {
            database = new Database(); // Đảm bảo rằng lớp Database của bạn được khởi tạo đúng cách
        }

        public DataTable GetThanhTienFromHoaDon()
        {
            DataTable dt = new DataTable();

            try
            {
                database.OpenConnection();

                string query = "SELECT ThanhTien FROM HoaDon";
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data from database: " + ex.Message);
            }
            finally
            {
                database.CloseConnection();
            }

            return dt;
        }

        public DataTable GetTongGiaFromKhoNX()
        {
            DataTable dt = new DataTable();

            try
            {
                database.OpenConnection();

                string query = "SELECT TongGia FROM KhoNX";
                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data from database: " + ex.Message);
            }
            finally
            {
                database.CloseConnection();
            }

            return dt;
        }

        public DataTable CalculateTienLaiLo()
        {
            DataTable dt = new DataTable();

            try
            {
                database.OpenConnection();

                string query = @"SELECT 
                            H.Mhd AS MaHoaDon,
                            H.SoLuong AS SoLuongHoaDon,
                            K.SoLuong AS SoLuongKho,
                            H.ThanhTien AS ThanhTienHoaDon,
                            K.TongGia AS TongGiaKho,
                            (H.SoLuong * H.DonGia) - K.TongGia AS TienLaiLo
                         FROM 
                            HoaDon AS H
                            JOIN KhoNX AS K ON H.Msp = K.Msp";

                SqlCommand cmd = new SqlCommand(query, database.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data from database: " + ex.Message);
            }
            finally
            {
                database.CloseConnection();
            }

            return dt;
        }



    }
}
