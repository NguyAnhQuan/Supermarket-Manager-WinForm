using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniMart.DataAccessLayer
{
    internal class Database : IDatabaseConnection
    {
        private static SqlConnection con = new SqlConnection("Data Source=NGUYEN-ANH-QUAN\\ANHQUANHAV;Initial Catalog=QuanLySieuThi;Integrated Security=True");
        //private static SqlConnection con = new SqlConnection("Data Source=VUN\\NGUYEN_VAN_VU;Initial Catalog=QuanLySieuThi;Integrated Security=True");

        public void OpenConnection()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Open connection failed: " + ex.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Close connection failed: " + ex.Message);
            }
        }

        public SqlConnection GetConnection()
        {
            return con;
        }
    }
}
