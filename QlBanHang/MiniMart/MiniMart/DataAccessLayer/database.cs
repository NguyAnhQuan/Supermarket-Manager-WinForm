using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiniMart.DataAccessLayer
{
    internal static class database
    {
        //private static SqlConnection con = new SqlConnection("Data Source=NGUYEN-ANH-QUAN\\ANHQUANHAV;Initial Catalog=QuanLySieuThi;Integrated Security=True;Trust Server Certificate=True");

        private static SqlConnection con = new SqlConnection("Data Source=NGUYEN-ANH-QUAN\\ANHQUANHAV;Initial Catalog=QuanLySieuThi;Integrated Security=True");

        public static void OpenConnection()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    //MessageBox.Show("The connection is: " + con.State.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Open connection failed: " + ex.Message);
            }
        }

        public static void CloseConnection()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    //MessageBox.Show("The connection is: " + con.State.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Close connection failed: " + ex.Message);
            }
        }

        public static SqlConnection GetConnection()
        {
            return con;
        }
    }
}
