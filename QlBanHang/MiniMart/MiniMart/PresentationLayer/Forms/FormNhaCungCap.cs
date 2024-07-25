using MiniMart.BusinessLogicLayer.Services;
using MiniMart.DataAccessLayer.Repositories;
using System;
using System.Data;
using System.Windows.Forms;

namespace MiniMart.PresentationLayer.Forms
{
    public partial class FormNhaCungCap : System.Windows.Forms.Form
    {
        private readonly NhaCungCapLG NhaCungCapService;

        public FormNhaCungCap()
        {
            InitializeComponent();

            NhaCungCapService = new NhaCungCapLG(new NhaCungCapDB());

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
            string Mncc = MnccTextBox.Text.Trim();
            string Ten = TenTextBox.Text.Trim();
            string DiaChi = DiaChiTextBox.Text.Trim();
            string Sdt = SdtTextBox.Text.Trim();
            string HopTac = HopTacTextBox.Text.Trim();

            DataTable result = NhaCungCapService.SearchData(Mncc, Ten, DiaChi, Sdt, HopTac);

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
                string Mncc = MnccTextBox.Text.Trim();

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    NhaCungCapService.DeleteEntry(Mncc);
                    MessageBox.Show("Xóa dữ liệu thành công!");

                    LoadDataToDataGridView();
                }
                else
                {
                    MessageBox.Show("Đã huỷ xóa dữ liệu!");
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
                string Mncc = MnccTextBox.Text.Trim();
                string Ten = TenTextBox.Text.Trim();
                string DiaChi = DiaChiTextBox.Text.Trim();
                if (!int.TryParse(SdtTextBox.Text, out int Sdt))
                {
                    MessageBox.Show("Chứa ký tự lạ vui lòng nhập lại");
                    return;
                }
                string HopTac = HopTacTextBox.Text.Trim();

                NhaCungCapService.UpdateEntry(Mncc, Ten, DiaChi, Sdt, HopTac);
                MessageBox.Show("Sửa dữ liệu thành công!");

                LoadDataToDataGridView();
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
                string Mncc = MnccTextBox.Text.Trim();
                string Ten = TenTextBox.Text.Trim();
                string DiaChi = DiaChiTextBox.Text.Trim();
                if (!int.TryParse(SdtTextBox.Text, out int Sdt))
                {
                    MessageBox.Show("Chứa ký tự lạ vui lòng nhập lại");
                    return;
                }
                string HopTac = HopTacTextBox.Text.Trim();

                NhaCungCapService.AddNewEntry(Mncc, Ten, DiaChi, Sdt, HopTac);
                MessageBox.Show("Thêm dữ liệu thành công!");

                LoadDataToDataGridView();
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
                //MessageBox.Show("Không có dữ liệu để hiển thị");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            MnccTextBox.Text = "";
            TenTextBox.Text = "";
            DiaChiTextBox.Text = "";
            SdtTextBox.Text = "";
            HopTacTextBox.Text = "";
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
