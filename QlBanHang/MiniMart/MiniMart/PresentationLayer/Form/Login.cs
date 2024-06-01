using MiniMart.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniMart.DataAccessLayer;

namespace MiniMart
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            database.OpenConnection();

            database.CloseConnection();
        }

        private void DangNhapBtn_click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các control trên form
            string maDangNhap = TaiKhoanTxt.Text;
            string matKhau = MatKhauTxt.Text;

            // Gọi phương thức để kiểm tra đăng nhập từ repository
            bool isValidLogin = MiniMart.DataAccessLayer.Repositories.Login.KiemTraDangNhap(maDangNhap, matKhau);

            // Kiểm tra kết quả đăng nhập
            if (isValidLogin)
            {
                // Đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!");
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }
    }
}
