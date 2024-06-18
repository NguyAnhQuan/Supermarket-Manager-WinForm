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
        }

        

        private void FormKho_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            LoadDataIntoTabPage("NhapTabPage", khoService.GetNhapData());
            LoadDataIntoTabPage("XuatTabPage", khoService.GetXuatData());
            LoadDataIntoTabPage("SapHetHanTabPage", khoService.GetSanPhamHetHan());
        }

        private void LoadDataIntoTabPage(string tabPageName, DataTable data)
        {
            TabPage tabPage = null;
            foreach (TabPage tp in TabControl.TabPages)
            {
                if (tp.Name == tabPageName)
                {
                    tabPage = tp;
                    break;
                }
            }

            if (tabPage != null)
            {
                DataGridView dataGridView = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    DataSource = data,
                    Name = tabPageName + "DataGridView"
                };

                dataGridView.CellClick += DataGridView_CellClick;

                tabPage.Controls.Clear();
                tabPage.Controls.Add(dataGridView);
            }
            else
            {
                MessageBox.Show("Không tìm thấy TabPage có tên là " + tabPageName);
            }
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dataGridView = sender as DataGridView;
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                MNXtextBox.Text = row.Cells["Mnx"].Value.ToString();
                ThoiGianTextBox.Text = row.Cells["Msp"].Value.ToString();
                MnxTextBox.Text = row.Cells["Mncc"].Value.ToString();
                SoLuongTextBox.Text = row.Cells["SoLuong"].Value.ToString();
                TongGiaTextBox.Text = row.Cells["TongGia"].Value.ToString();
                ThoiGianTextBox.Text = row.Cells["ThoiGian"].Value.ToString();
            }
        }

        private void ThemButton_Click(object sender, EventArgs e)
        {
            string mnx = MNXtextBox.Text;
            string msp = ThoiGianTextBox.Text;
            string mncc = MnxTextBox.Text;
            int soLuong = int.Parse(SoLuongTextBox.Text);
            decimal tongGia = decimal.Parse(TongGiaTextBox.Text);

            DateTime thoiGian;
            if (string.IsNullOrEmpty(ThoiGianTextBox.Text))
            {
                thoiGian = DateTime.Now;
            }
            else
            {
                thoiGian = DateTime.Parse(ThoiGianTextBox.Text);
            }

            if (khoService.CheckDuplicate(mnx))
            {
                MessageBox.Show("Mã nhập/xuất đã tồn tại, vui lòng kiểm tra lại.");
            }
            else
            {
                khoService.AddNewEntry(mnx, msp, mncc, soLuong, tongGia, thoiGian);
                MessageBox.Show("Đã thêm mới thành công.");
                ClearTextBoxes();
                RefreshData();
            }
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            string mnx = MNXtextBox.Text;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                khoService.DeleteEntry(mnx);
                MessageBox.Show("Đã xóa thành công.");
                ClearTextBoxes();
                RefreshData();
            }
        }

        private void ClearTextBoxes()
        {
            MNXtextBox.Text = "";
            ThoiGianTextBox.Text = "";
            MnxTextBox.Text = "";
            SoLuongTextBox.Text = "";
            TongGiaTextBox.Text = "";
            ThoiGianTextBox.Text = "";
        }

        private void SuaButton_Click_1(object sender, EventArgs e)
        {
            string mnx = MNXtextBox.Text;
            string msp = ThoiGianTextBox.Text;
            string mncc = MnxTextBox.Text;
            int soLuong;
            decimal tongGia;
            DateTime thoiGian;

            if (string.IsNullOrEmpty(ThoiGianTextBox.Text))
            {
                thoiGian = DateTime.Now;
            }
            else
            {
                thoiGian = DateTime.Parse(ThoiGianTextBox.Text);
            }

            if (string.IsNullOrEmpty(mnx) ||
                string.IsNullOrEmpty(msp) ||
                string.IsNullOrEmpty(mncc) ||
                !int.TryParse(SoLuongTextBox.Text, out soLuong) ||
                !decimal.TryParse(TongGiaTextBox.Text, out tongGia))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng thông tin.");
                return;
            }

            khoService.UpdateEntry(mnx, msp, mncc, soLuong, tongGia, thoiGian);
            MessageBox.Show("Đã cập nhật thành công.");
            ClearTextBoxes();
            RefreshData();
        }

        private void TimKiemButton_Click(object sender, EventArgs e)
        {

            string columnName = TimKiemComboBox.SelectedItem?.ToString();

            string keyword = TimKiemTextBox.Text;

            DateTime fromDate = dateTimePicker1.Value;
            DateTime toDate = dateTimePicker2.Value;


            if (string.IsNullOrEmpty(columnName) || string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng chọn cột và nhập từ khóa tìm kiếm.");
                return;
            }


            DataTable searchData = khoService.SearchData(columnName, keyword, fromDate, toDate);


            if (searchData != null && searchData.Rows.Count > 0)
            {
                LoadDataIntoTabPage("NhapTabPage", searchData);
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu phù hợp.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeTextBox.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
