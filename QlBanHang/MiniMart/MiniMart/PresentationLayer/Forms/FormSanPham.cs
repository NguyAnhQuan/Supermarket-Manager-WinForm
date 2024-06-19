using MiniMart.BusinessLogicLayer.Services;
using MiniMart.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMart.PresentationLayer.Forms
{
    public partial class FormSanPham : System.Windows.Forms.Form
    {
        private SanPhamLG SanPhamService;

        public FormSanPham()
        {
            InitializeComponent();
            SanPhamService = new SanPhamLG();

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
                DataTable data = SanPhamService.GetSanPham();
                if (data != null)
                {
                    SanPhamDirdView.DataSource = data;
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

        

        private void ThemButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Mkh = MkhTextBox.Text;
                string HoTen = HoTenKHTextBox.Text;
                string DiaChi = DiaChiKHTextBox.Text;
                int Sdt = int.Parse(SDTKHTextBox.Text);
                string HangKhach = HangKhachTextBox.Text;

                SanPhamService.AddNewEntry(Mkh, HoTen, DiaChi, Sdt, HangKhach);
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
                string Mkh = MkhTextBox.Text;
                string HoTen = HoTenKHTextBox.Text;
                string DiaChi = DiaChiKHTextBox.Text;
                int Sdt = int.Parse(SDTKHTextBox.Text);
                string HangKhach = HangKhachTextBox.Text;

                SanPhamService.UpdateEntry(Mkh, HoTen, DiaChi, Sdt, HangKhach);
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
                string Mkh = MkhTextBox.Text;

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    SanPhamService.DeleteEntry(Mkh);
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

        private void TimKiemButton_Click(object sender, EventArgs e)
        {
            string Mkh = MkhTextBox.Text; if (Mkh == null) { Mkh = ""; }
            string HoTen = HoTenKHTextBox.Text; if (HoTen == null) { HoTen = ""; }
            string DiaChi = DiaChiKHTextBox.Text; if (DiaChi == null) { DiaChi = ""; }
            string Sdt = SDTKHTextBox.Text;
            string HangKhach = HangKhachTextBox.Text; if (HangKhach == null) { HangKhach = ""; }

            if (Mkh == null && HoTen == null && DiaChi == null && Sdt == null && HangKhach == null)
            {
                SanPhamDirdView.DataSource = SanPhamService.GetSanPham();
            }

            DataTable result = SanPhamDB.SearchData(Mkh, HoTen, DiaChi, Sdt, HangKhach);

            if (result != null)
            {
                SanPhamDirdView.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SanPhamDirdView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = SanPhamDirdView.Rows[e.RowIndex];
                MkhTextBox.Text = selectedRow.Cells["Mkh"].Value.ToString();
                HoTenKHTextBox.Text = selectedRow.Cells["HoTen"].Value.ToString();
                DiaChiKHTextBox.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                SDTKHTextBox.Text = selectedRow.Cells["Sdt"].Value.ToString();
                HangKhachTextBox.Text = selectedRow.Cells["HangKhach"].Value.ToString();
            }
            else
            {
                //MessageBox.Show("Không có dữ liệu đêe hiển thị");
            }
        }
    }
}
