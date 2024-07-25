using System;
using System.Data;
using System.Windows.Forms;
using MiniMart.BusinessLogicLayer.Services;

namespace MiniMart.PresentationLayer.Form
{
    public partial class FormKho : System.Windows.Forms.Form
    {
        private KhoLG khoService;

        public FormKho()
        {
            InitializeComponent();

            khoService = new KhoLG();

            MnvTextBox.Text = LoginForm.MNV;
            HoTenTextBox.Text = LoginForm.HOTEN;

            LoadDataToDataGridView();

            KhoDataGridView.CellClick += KhoDataGridView_CellClick;
            ThemButton.Click += ThemButton_Click;
            SuaButton.Click += SuaButton_Click;
            XoaButton.Click += XoaButton_Click;
            TimKiemKhoBitton.Click += TimKiemKhoButton_Click;
        }

        private void LoadDataToDataGridView()
        {
            KhoDataGridView.DataSource = khoService.GetNhapData();
        }

        private void KhoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = KhoDataGridView.Rows[e.RowIndex];
                MnxTextBox.Text = selectedRow.Cells["Mnx"].Value.ToString();
                MaSPTextBox.Text = selectedRow.Cells["Msp"].Value.ToString();
                MnccTextBox.Text = selectedRow.Cells["Mncc"].Value.ToString();
                SoLuongTextBox.Text = selectedRow.Cells["SoLuong"].Value.ToString();
                TongGiaTextBox.Text = selectedRow.Cells["TongGia"].Value.ToString();
                ThoiGianTextBox.Text = Convert.ToDateTime(selectedRow.Cells["ThoiGian"].Value).ToString("dd/MM/yyyy HH:mm:ss");
            }
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            try
            {
                string mnx = MnxTextBox.Text;
                string msp = MaSPTextBox.Text;
                string mncc = MnccTextBox.Text;
                //int soLuong = int.Parse(SoLuongTextBox.Text);
                if (!int.TryParse(SoLuongTextBox.Text, out int soLuong))
                {
                    MessageBox.Show("Chứa ký tự lạ vui lòng nhập lại");
                    return;
                }
                if (!decimal.TryParse(TongGiaTextBox.Text, out decimal tongGia))
                {
                    MessageBox.Show("Tổng giá chứa ký tự lạ vui lòng nhập lại");
                    return;
                }
                DateTime thoiGian = DateTime.Now; 

                khoService.AddNewEntry(mnx, msp, mncc, soLuong, tongGia, thoiGian);
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
                string mnx = MnxTextBox.Text;
                string msp = MaSPTextBox.Text;
                string mncc = MnccTextBox.Text;
                if (!int.TryParse(SoLuongTextBox.Text, out int soLuong))
                {
                    MessageBox.Show("Chứa ký tự lạ vui lòng nhập lại");
                    return;
                }
                if (!decimal.TryParse(TongGiaTextBox.Text, out decimal tongGia))
                {
                    MessageBox.Show("Tổng giá chứa ký tự lạ vui lòng nhập lại");
                    return;
                }
                //DateTime thoiGian = DateTime.ParseExact(ThoiGianTextBox.Text, "dd/MM/yyyy HH:mm:ss", null);
                if (!DateTime.TryParse(ThoiGianTextBox.Text, out DateTime thoiGian))
                {
                    MessageBox.Show("Thời gian chứa ký tự lạ vui lòng nhập lại");
                    return;
                }
                khoService.UpdateEntry(mnx, msp, mncc, soLuong, tongGia, thoiGian);
                MessageBox.Show("Cập nhật dữ liệu thành công!");

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
                string mnx = MnxTextBox.Text;

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    khoService.DeleteEntry(mnx);
                    MessageBox.Show("Xóa dữ liệu thành công!");

                    LoadDataToDataGridView();
                }
                else
                {
                    MessageBox.Show("Đã hoàn trả dữ liệu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void TimKiemKhoButton_Click(object sender, EventArgs e)
        {
            string keyword = TimKiemTextBox.Text.Trim();
            DateTime fromDate = dateTimePicker1.Value;
            DateTime toDate = dateTimePicker2.Value;

            if (TimKiemComboBox.SelectedItem == null || string.IsNullOrEmpty(TimKiemComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            string columnName = TimKiemComboBox.SelectedItem.ToString();

            DataTable result = khoService.SearchData(columnName, keyword, fromDate, toDate);

            if (result != null)
            {
                KhoDataGridView.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeTextBox.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            MnxTextBox.Text = "";
            MaSPTextBox.Text = "";
            MnccTextBox.Text = "";
            SoLuongTextBox.Text = "";
            TongGiaTextBox.Text = "";
            ThoiGianTextBox.Text = "";
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
