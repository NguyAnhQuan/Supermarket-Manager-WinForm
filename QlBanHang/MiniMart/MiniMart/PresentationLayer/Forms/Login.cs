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

            // Gọi phương thức để kiểm tra đăng nhập và lấy chức vụ từ repository
            string chucVu = MiniMart.DataAccessLayer.Repositories.Login.KiemTraDangNhapVaLayChucVu(maDangNhap, matKhau);

            // Kiểm tra kết quả đăng nhập và mở form tương ứng
            if (chucVu != null)
            {
                // Đăng nhập thành công, mở form tương ứng với chức vụ
                MessageBox.Show("Đăng nhập thành công! Chức vụ: " + chucVu);

                Form formToOpen = null;
                switch (chucVu)
                {
                    case "Kho":
                        formToOpen = new MiniMart.PresentationLayer.Form.FormKho();
                        break;
                    // Thêm các trường hợp khác cho các chức vụ khác nhau
                    // case "Admin":
                    //     formToOpen = new AdminForm();
                    //     break;
                    // v.v.
                    default:
                        MessageBox.Show("Chức vụ không xác định.");
                        return;
                }

                if (formToOpen != null)
                {
                    formToOpen.Show();
                    this.Hide();
                }
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
