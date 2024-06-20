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
        public static string MNV;
        public static string HOTEN;

        private void DangNhapBtn_click(object sender, EventArgs e)
        {
            string maDangNhap = TaiKhoanTxt.Text;
            string matKhau = MatKhauTxt.Text;

            string chucVuin = MiniMart.DataAccessLayer.Repositories.Login.KiemTraDangNhapVaLayChucVu(maDangNhap, matKhau);
            
            if (chucVuin != null)
            {
                var (chucvu, mnv, hoten) = MiniMart.DataAccessLayer.Repositories.Login.GetMnvChucVu(chucVuin);
                
                MessageBox.Show($"\tĐăng nhập thành công!\t \n\tChức vụ: {chucvu} \n\tMã nhân viên: {mnv} \n\tHọ tên: {hoten}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MNV = mnv;
                HOTEN = hoten;

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
                        //formToOpen = new MiniMart.PresentationLayer.Forms.FromKeToan();
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
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
