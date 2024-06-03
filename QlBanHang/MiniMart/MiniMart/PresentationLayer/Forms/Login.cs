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
    public partial class LoginForm : System.Windows.Forms.Form
    {
        public LoginForm()
        {
            InitializeComponent();

            
        }
        private IDatabaseConnection database = new Database();
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
            string chucVuin = MiniMart.DataAccessLayer.Repositories.Login.KiemTraDangNhapVaLayChucVu(maDangNhap, matKhau);

            // Kiểm tra kết quả đăng nhập và mở form tương ứng
            if (chucVuin != null)
            {
                // Gọi phương thức GetMnvChucVu để lấy mã nhân viên và chức vụ
                var (chucVu, mnv) = MiniMart.DataAccessLayer.Repositories.Login.GetMnvChucVu(chucVuin);

                // Đăng nhập thành công, mở form tương ứng với chức vụ
                MessageBox.Show($"\tĐăng nhập thành công!\t \n\tChức vụ: {chucVu} \n\tMã nhân viên: {mnv}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Form formToOpen = null;
                switch (chucVuin)
                {
                    case "Kho":
                        formToOpen = new MiniMart.PresentationLayer.Form.FormKho();
                        break;
                    case "Admin":
                        formToOpen = new MiniMart.PresentationLayer.Forms.FormAdmin();
                        break;
                    case "NhanVien":
                        formToOpen = new MiniMart.PresentationLayer.Forms.FormNhanVien();
                        break;
                    case "ThuNgan":
                        formToOpen = new MiniMart.PresentationLayer.Forms.FormThuNgan();
                        break;
                    case "KeToan":
                        formToOpen = new MiniMart.PresentationLayer.Forms.FromKeToan();
                        break;

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
