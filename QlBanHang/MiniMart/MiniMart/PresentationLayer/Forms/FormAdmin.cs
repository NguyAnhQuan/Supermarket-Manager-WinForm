using MiniMart.BusinessLogicLayer.Services;
using MiniMart.DataAccessLayer.Repositories;
using System;
using System.Data;
using System.Windows.Forms;

namespace MiniMart.PresentationLayer.Forms
{
    public partial class FormAdmin : System.Windows.Forms.Form
    {
        private AdminLG AdminService;
        private NhanVienLG NhanVienService;

        public FormAdmin()
        {
            InitializeComponent();

            AdminService = new AdminLG();
            NhanVienService = new NhanVienLG();

            MnvTextBox.Text = LoginForm.MNV;
            HoTenTextBox.Text = LoginForm.HOTEN;

            LoadDataToDataGridView();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            TimeTextBox.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void LoadDataToDataGridView()
        {
            try
            {
                DataTable data = AdminService.GetDangNhap();
                if (data != null)
                {
                    DangNhapDirdView.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Không thể tải dữ liệu khách hàng.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void DangNhapDirdView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = DangNhapDirdView.Rows[e.RowIndex];
                MdnTextBox.Text = selectedRow.Cells["Mdn"].Value.ToString();
                ManvTextBox.Text = selectedRow.Cells["Mnv"].Value.ToString();
                GioVaoTextBox.Text = selectedRow.Cells["GioVao"].Value.ToString();
                GioRaTextBox.Text = selectedRow.Cells["GioRa"].Value.ToString();
                MatKhauTextBox.Text = selectedRow.Cells["MatKhau"].Value.ToString();
            }
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Mdn = MdnTextBox.Text;
                string Mnv = ManvTextBox.Text;
                DateTime GioVao = DateTime.Parse(GioVaoTextBox.Text);
                DateTime GioRa = DateTime.Parse(GioRaTextBox.Text);
                string MatKhau = MatKhauTextBox.Text;

                AdminService.AddNewEntry(Mdn, Mnv, GioVao, GioRa, MatKhau);
                MessageBox.Show("Thêm dữ liệu thành công!");

                LoadDataToDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void SuaButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Mdn = MdnTextBox.Text;
                string Mnv = ManvTextBox.Text;
                DateTime GioVao = DateTime.Parse(GioVaoTextBox.Text);
                DateTime GioRa = DateTime.Parse(GioRaTextBox.Text);
                string MatKhau = MatKhauTextBox.Text;

                AdminService.UpdateEntry(Mdn, Mnv, GioVao, GioRa, MatKhau);
                MessageBox.Show("Sửa dữ liệu thành công!");

                LoadDataToDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Mdn = MdnTextBox.Text;
                AdminService.DeleteEntry(Mdn);
                MessageBox.Show("Xóa thành công!");

                LoadDataToDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void TimKiemButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Mdn = MdnTextBox.Text;
                string Mnv = ManvTextBox.Text;

                DateTime? Giovao = null;
                DateTime gioVaoTemp;
                if (DateTime.TryParse(GioVaoTextBox.Text, out gioVaoTemp))
                {
                    Giovao = gioVaoTemp;
                }

                DateTime? GioRa = null;
                DateTime gioRaTemp;
                if (DateTime.TryParse(GioRaTextBox.Text, out gioRaTemp))
                {
                    GioRa = gioRaTemp;
                }

                string MatKhau = MatKhauTextBox.Text;

                DataTable result = AdminService.SearchData(Mdn, Mnv, Giovao, GioRa, MatKhau);

                if (result != null && result.Rows.Count > 0)
                {
                    DangNhapDirdView.DataSource = result;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            MdnTextBox.Text = "";
            ManvTextBox.Text = "";
            GioVaoTextBox.Text = "";
            GioRaTextBox.Text = "";
            MatKhauTextBox.Text = "";
        }

        private void ButtonOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void buttonPowert_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
