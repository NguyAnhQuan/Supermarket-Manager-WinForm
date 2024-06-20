using MiniMart.BusinessLogicLayer.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace MiniMart.PresentationLayer.Forms
{
    public partial class FormSanPham : System.Windows.Forms.Form
    {
        private SanPhamLG sanPhamService;

        public FormSanPham()
        {
            InitializeComponent();
            sanPhamService = new SanPhamLG();

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
                DataTable data = sanPhamService.GetSanPham();
                if (data != null)
                {
                    SanPhamDirdView.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Không thể tải dữ liệu sản phẩm.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Msp = MspTextBox.Text;
                string Mncc = MnccTextBox.Text;
                string TenSp = TenspTextBox.Text;
                int SoLuong = int.Parse(SoLuongTextBox.Text);
                float Gia = float.Parse(GiaTextBox.Text);
                DateTime NgayNhap = NgayNhapDateTimePicker.Value;
                DateTime HetHan = HanDateTimePicker.Value;
                string HetHang = HetHangCheckBox.Checked ? "Yes" : "No";
                string PhanLoai = LoaiTextBox.Text;

                sanPhamService.AddNewEntry(Msp, Mncc, TenSp, SoLuong, Gia, NgayNhap, HetHan, HetHang, PhanLoai);
                MessageBox.Show("Thêm dữ liệu thành công!");

                LoadDataToDataGridView(); // Refresh data grid view
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
                string Msp = MspTextBox.Text;
                string Mncc = MnccTextBox.Text;
                string TenSp = TenspTextBox.Text;
                int SoLuong = int.Parse(SoLuongTextBox.Text);
                float Gia = float.Parse(GiaTextBox.Text);
                DateTime NgayNhap = NgayNhapDateTimePicker.Value;
                DateTime HetHan = HanDateTimePicker.Value;
                string HetHang = HetHangCheckBox.Checked ? "Yes" : "No";
                string PhanLoai = LoaiTextBox.Text;

                sanPhamService.UpdateEntry(Msp, Mncc, TenSp, SoLuong, Gia, NgayNhap, HetHan, HetHang, PhanLoai);
                MessageBox.Show("Đã sửa dữ liệu thành công!");

                LoadDataToDataGridView(); // Refresh data grid view
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
                string Msp = MspTextBox.Text;

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    sanPhamService.DeleteEntry(Msp);
                    MessageBox.Show("Xóa dữ liệu thành công!");

                    LoadDataToDataGridView(); // Refresh data grid view
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

        private void TimKiemButton_Click(object sender, EventArgs e)
        {
            string Msp = MspTextBox.Text;
            string Mncc = MnccTextBox.Text;
            string TenSp = TenspTextBox.Text;
            int SoLuong = int.TryParse(SoLuongTextBox.Text, out int sl) ? sl : 0;
            float Gia = float.TryParse(GiaTextBox.Text, out float gia) ? gia : 0;
            DateTime NgayNhap = NgayNhapDateTimePicker.Value;
            DateTime HetHan = HanDateTimePicker.Value;
            string HetHang = HetHangCheckBox.Checked ? "Yes" : "No";
            string PhanLoai = LoaiTextBox.Text;

            DataTable result = sanPhamService.SearchData(Msp, Mncc, TenSp, SoLuong, Gia, NgayNhap, HetHan, HetHang, PhanLoai);

            if (result != null)
            {
                SanPhamDirdView.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NhapDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = SanPhamDirdView.Rows[e.RowIndex];
                MspTextBox.Text = selectedRow.Cells["Msp"].Value.ToString();
                MnccTextBox.Text = selectedRow.Cells["Mncc"].Value.ToString();
                TenspTextBox.Text = selectedRow.Cells["TenSp"].Value.ToString();
                SoLuongTextBox.Text = selectedRow.Cells["SoLuong"].Value.ToString();
                GiaTextBox.Text = selectedRow.Cells["Gia"].Value.ToString();
                NgayNhapDateTimePicker.Value = Convert.ToDateTime(selectedRow.Cells["NgayNhap"].Value);
                HanDateTimePicker.Value = Convert.ToDateTime(selectedRow.Cells["HetHan"].Value);
                HetHangCheckBox.Checked = selectedRow.Cells["HetHang"].Value.ToString() == "Yes";
                LoaiTextBox.Text = selectedRow.Cells["PhanLoai"].Value.ToString();
            }
        }
    }
}
