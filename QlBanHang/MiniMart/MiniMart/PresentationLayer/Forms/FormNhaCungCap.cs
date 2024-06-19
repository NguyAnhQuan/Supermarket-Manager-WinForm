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
    public partial class FormNhaCungCap : System.Windows.Forms.Form
    {
        private NhaCungCapLG NhaCungCapService;

        public FormNhaCungCap()
        {
            InitializeComponent();
            NhaCungCapService = new NhaCungCapLG();

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
                DataTable data = NhaCungCapService.GetNhaCungCap();
                if (data != null)
                {
                    NccDataGridView.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Không thể tải dữ liệu nhà cung cấp.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        

  

        private void TimKiemButton_Click(object sender, EventArgs e)
        {
            string Mncc = MnccTextBox.Text; if (Mncc == null) { Mncc = ""; }
            string Ten = TenTextBox.Text; if (Ten == null) { Ten = ""; }
            string DiaChi = DiaChiTextBox.Text; if (DiaChi == null) { DiaChi = ""; }
            string Sdt = SdtTextBox.Text;
            string HopTac = HopTacTextBox.Text; if (HopTac == null) { HopTac = ""; }

            if (Mncc == null && Ten == null && DiaChi == null && Sdt == null && HopTac == null)
            {
                NccDataGridView.DataSource = NhaCungCapService.GetNhaCungCap();
            }

            DataTable result = NhaCungCapDB.SearchData(Mncc, Ten, DiaChi, Sdt, HopTac);

            if (result != null)
            {
                NccDataGridView.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Mncc = MnccTextBox.Text;

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    NhaCungCapService.DeleteEntry(Mncc);
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

        private void SuaButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Mncc = MnccTextBox.Text;
                string Ten = TenTextBox.Text;
                string DiaChi = DiaChiTextBox.Text;
                int Sdt = int.Parse(SdtTextBox.Text);
                string HopTac = HopTacTextBox.Text;

                NhaCungCapService.UpdateEntry(Mncc, Ten, DiaChi, Sdt, HopTac);
                MessageBox.Show("Đã sửa dữ liệu thành công!");

                LoadDataToDataGridView(); // Refresh data grid view
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            try
            {
                string Mncc = MnccTextBox.Text;
                string Ten = TenTextBox.Text;
                string DiaChi = DiaChiTextBox.Text;
                int Sdt = int.Parse(SdtTextBox.Text);
                string HopTac = HopTacTextBox.Text;

                NhaCungCapService.AddNewEntry(Mncc, Ten, DiaChi, Sdt, HopTac);
                MessageBox.Show("Thêm dữ liệu thành công!");

                LoadDataToDataGridView(); // Refresh data grid view
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void NccDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = NccDataGridView.Rows[e.RowIndex];
                MnccTextBox.Text = selectedRow.Cells["Mncc"].Value.ToString();
                TenTextBox.Text = selectedRow.Cells["Ten"].Value.ToString();
                DiaChiTextBox.Text = selectedRow.Cells["DiaChi"].Value.ToString();
                SdtTextBox.Text = selectedRow.Cells["Sdt"].Value.ToString();
                HopTacTextBox.Text = selectedRow.Cells["HopTac"].Value.ToString();
            }
            else
            {
                //MessageBox.Show("Không có dữ liệu đêe hiển thị");
            }
        }
    }
}
