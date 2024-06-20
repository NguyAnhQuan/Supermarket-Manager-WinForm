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
    public partial class FormThuNgan : System.Windows.Forms.Form
    {
        private SanPhamLG sanPhamService;
        private KhachHangLG khachhangService;
        private ThuNganLG thuNganService;
        public FormThuNgan()
        {
            InitializeComponent();

            sanPhamService = new SanPhamLG(new SanPhamDB());
            khachhangService = new KhachHangLG();
            thuNganService = new ThuNganLG(new ThuNganDB());

            MnvTextBox.Text = LoginForm.MNV;
            HoTenTextBox.Text = LoginForm.HOTEN;

            SoLuongTextBox.TextChanged += SoLuongTextBox_TextChanged;
            TimKiemButton.Click += TimKiemButton_Click;

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
                    ThuNganGridView.DataSource = data;
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
        
       



        private void ThanhToanButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isHetHang = false;
                int soLuongCanMua = int.Parse(SoLuongTextBox.Text); 

                foreach (DataGridViewRow row in ThuNganGridView.Rows)
                {
                    if (row.Cells["Msp"].Value != null && row.Cells["Msp"].Value.ToString() == MspTextBox.Text)
                    {
                        isHetHang = (bool)row.Cells["HetHang"].Value;
                        int soLuongHienCo = Convert.ToInt32(row.Cells["SoLuong"].Value);

                        if (soLuongHienCo < soLuongCanMua)
                        {
                            MessageBox.Show($"Số lượng sản phẩm '{MspTextBox.Text}' không đủ để thực hiện thanh toán. Chỉ còn {soLuongHienCo} sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        break;
                    }
                }

                if (isHetHang)
                {
                    MessageBox.Show("Sản phẩm này đã hết hàng. Không thể thực hiện thanh toán.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string Msp = MspTextBox.Text;
                string Mhd = thuNganService.SearchHD(); 
                DateTime NgayXuat = DateTime.Now;
                int SoLuong = int.Parse(SoLuongTextBox.Text); 
                float DonGia = float.Parse(GiaTextBox.Text);
                //float ThanhTien = DonGia * SoLuong;
                float ThanhTien = float.Parse(GiaTextBox.Text);
                string Mkh = HkhTextBox.Text;
                string Mnv = MnvTextBox.Text;

                DialogResult result = MessageBox.Show("Bạn muốn thanh toán hình thức nào?", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    thuNganService.AddHD(NgayXuat, Msp, SoLuong, DonGia, ThanhTien, Mkh, Mnv); 
                    MessageBox.Show("Thanh toán thành công!");

                    LoadDataToDataGridView();
                }
                else
                {
                    MessageBox.Show("Đang phát triển thanh toán tiền điện tử vẫn chưa dùng được!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void ThuNganGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = ThuNganGridView.Rows[e.RowIndex];
                MspTextBox.Text = selectedRow.Cells["Msp"].Value.ToString();
                TenspTextBox.Text = selectedRow.Cells["TenSp"].Value.ToString();
                LoaiTextBox.Text = selectedRow.Cells["PhanLoai"].Value.ToString();

                float giasp = float.Parse(selectedRow.Cells["Gia"].Value.ToString());

                SoLuongTextBox.Tag = giasp;

                if (int.TryParse(SoLuongTextBox.Text, out int soluong))
                {
                    GiaTextBox.Text = (giasp * soluong).ToString();
                }
            }
        }




        private void TimKiemButton_Click(object sender, EventArgs e)
        {
            string Mkh = HkhTextBox.Text.Trim();
            string Msp = MspTextBox.Text.Trim();
            DataTable khachHangResult = null;
            DataTable sanPhamResult = null;

            if (!string.IsNullOrEmpty(Mkh))
            {
                khachHangResult = thuNganService.SearchKhachHang(Mkh);

                if (khachHangResult != null && khachHangResult.Rows.Count > 0)
                {
                    DataRow row = khachHangResult.Rows[0];
                    HkhTextBox.Text = row["Mkh"].ToString();
                    HoTenKHTextBox.Text = row["HoTen"].ToString();
                    DiaChiKHTextBox.Text = row["DiaChi"].ToString();
                    SDTKHTextBox.Text = row["SDT"].ToString();

                    bool isVIP = (bool)row["HangKhach"];
                    HangKhachTextBox.Text = isVIP ? "VIP" : "Thường";
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (!string.IsNullOrEmpty(Msp))
            {
                sanPhamResult = thuNganService.SearchSanPham(Msp, "", "");

                if (sanPhamResult != null && sanPhamResult.Rows.Count > 0)
                {
                    ThuNganGridView.DataSource = sanPhamResult;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (string.IsNullOrEmpty(Mkh) && string.IsNullOrEmpty(Msp))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SoLuongTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SoLuongTextBox.Tag != null && float.TryParse(SoLuongTextBox.Tag.ToString(), out float giasp) && int.TryParse(SoLuongTextBox.Text, out int soluong))
            {
                GiaTextBox.Text = (giasp * soluong).ToString();
            }
            else
            {
                GiaTextBox.Text = "0"; 
            }
        }

        private void ClsBtn_Click(object sender, EventArgs e)
        {
            HkhTextBox.Text = "";
            HoTenKHTextBox.Text = "";
            DiaChiKHTextBox.Text = "";
            SDTKHTextBox.Text = "";
            HangKhachTextBox.Text = "";
            MspTextBox.Text = "";
            TenspTextBox.Text = "";
            //GiaTextBox.Text = "";
            SoLuongTextBox.Text = "";
            LoaiTextBox.Text = "";
        }
    }
}
