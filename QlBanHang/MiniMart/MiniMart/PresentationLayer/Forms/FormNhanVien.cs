using MiniMart.BusinessLogicLayer.Services;
using MiniMart.DataAccessLayer.Repositories;
using System;
using System.Data;
using System.Windows.Forms;

namespace MiniMart.PresentationLayer.Forms
{
    public partial class FormNhanVien : System.Windows.Forms.Form
    {
        private readonly INhanVienRepository nhanVienService;

        public FormNhanVien()
        {
            InitializeComponent();
            nhanVienService = new NhanVienLG(); 

            MnvTextBox.Text = LoginForm.MNV;
            HoTenTextBox.Text = LoginForm.HOTEN;

            LoadDataToDataGridView();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeTextBox.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void LoadDataToDataGridView()
        {
            try
            {
                DataTable data = nhanVienService.GetNhanVien();
                if (data != null)
                {
                    NhanVienDirdView.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Không thể tải dữ liệu nhân viên.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void NhanVienDirdView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = NhanVienDirdView.Rows[e.RowIndex];
                MaNVTextBox.Text = selectedRow.Cells["Mnv"].Value.ToString();
                HoTenNVTextBox.Text = selectedRow.Cells["HoTen"].Value.ToString();
                DiaChiNVTextBox.Text = selectedRow.Cells["DiaChi"].Value.ToString();

                DateTime sinhNhat;
                if (DateTime.TryParse(selectedRow.Cells["SinhNhat"].Value.ToString(), out sinhNhat))
                {
                    SinhNhatdateTimePicker.Value = sinhNhat;
                }
                else
                {
                    SinhNhatdateTimePicker.Value = DateTime.Now;
                }

                GioiTinhTextBox.Text = selectedRow.Cells["GioiTinh"].Value.ToString();
                SDTNVTextBox.Text = selectedRow.Cells["Sdt"].Value.ToString();
                ChucVutextBox.Text = selectedRow.Cells["ChucVu"].Value.ToString();
                LuongTextBox.Text = selectedRow.Cells["Luong"].Value.ToString();
            }
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Mnv = MaNVTextBox.Text;
                string HoTen = HoTenNVTextBox.Text;
                string DiaChi = DiaChiNVTextBox.Text;
                string GioiTinh = GioiTinhTextBox.Text;
                string Sdt = SDTNVTextBox.Text;
                DateTime SinhNhat = SinhNhatdateTimePicker.Value;
                string ChucVu = ChucVutextBox.Text;
                if (!float.TryParse(LuongTextBox.Text, out float Luong))
                {
                    MessageBox.Show("Lương chứa ký tự lạ vui lòng nhập lại");
                    return;
                }

                nhanVienService.AddNewEntry(Mnv, Sdt, SinhNhat, DiaChi, HoTen, GioiTinh, ChucVu, Luong);
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
                string Mnv = MaNVTextBox.Text;
                string Sdt = SDTNVTextBox.Text;
                DateTime SinhNhat = SinhNhatdateTimePicker.Value;
                string DiaChi = DiaChiNVTextBox.Text;
                string HoTen = HoTenNVTextBox.Text;
                string GioiTinh = GioiTinhTextBox.Text;
                string ChucVu = ChucVutextBox.Text;
                if (!float.TryParse(LuongTextBox.Text, out float Luong))
                {
                    MessageBox.Show("Lương chứa ký tự lạ vui lòng nhập lại");
                    return;
                }

                nhanVienService.UpdateEntry(Mnv, Sdt, SinhNhat, DiaChi, HoTen, GioiTinh, ChucVu, Luong);
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
                string Mnv = MaNVTextBox.Text;
                nhanVienService.DeleteEntry(Mnv);
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
            string Mnv = MaNVTextBox.Text;
            string HoTen = HoTenNVTextBox.Text;
            string DiaChi = DiaChiNVTextBox.Text;
            string GioiTinh = GioiTinhTextBox.Text;
            string Sdt = SDTNVTextBox.Text;
            string ChucVu = ChucVutextBox.Text;
            float Luong = float.TryParse(LuongTextBox.Text, out float luong) ? luong : 0;

            DataTable result = nhanVienService.SearchData(Mnv, Sdt, DiaChi, HoTen, GioiTinh, ChucVu, Luong);

            if (result != null)
            {
                NhanVienDirdView.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            MaNVTextBox.Text = "";
            HoTenNVTextBox.Text = "";
            DiaChiNVTextBox.Text = "";
            SinhNhatdateTimePicker.Value = DateTime.Now;
            GioiTinhTextBox.Text = "";
            SDTNVTextBox.Text = "";
            ChucVutextBox.Text = "";
            LuongTextBox.Text = "";
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
