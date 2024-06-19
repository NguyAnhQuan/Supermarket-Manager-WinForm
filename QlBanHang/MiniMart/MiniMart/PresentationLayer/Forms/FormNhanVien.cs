using MiniMart.BusinessLogicLayer.Services;
using MiniMart.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMart.PresentationLayer.Forms
{
    public partial class FormNhanVien : System.Windows.Forms.Form
    {
        private NhanVienLG NhanVienService;
        public FormNhanVien()
        {
            InitializeComponent();

            NhanVienService = new NhanVienLG();

            MnvTextBox.Text = LoginForm.MNV;
            HoTenTextBox.Text = LoginForm.HOTEN;

            LoadDataToDataGridView();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeTextBox.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void LoadDataToDataGridView()
        {
            try
            {
                DataTable data = NhanVienService.GetNhanVien();
                if (data != null)
                {
                    NhanVienDirdView.DataSource = data;
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
            else
            {
                //MessageBox.Show("Không có dữ liệu để hiển thị");
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
                float Luong = float.Parse(LuongTextBox.Text);

                NhanVienService.AddNewEntry(Mnv, Sdt, SinhNhat, DiaChi, HoTen, GioiTinh, ChucVu, Luong);
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
                float Luong = float.Parse(LuongTextBox.Text);

                NhanVienService.UpdateEntry(Mnv, Sdt, SinhNhat, DiaChi, HoTen, GioiTinh, ChucVu, Luong);
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
            string Mnv = MaNVTextBox.Text; 
            NhanVienLG nhanVienLG = new NhanVienLG();
            nhanVienLG.DeleteEntry(Mnv);
            MessageBox.Show("Xóa thành công!");

            LoadDataToDataGridView();
        }


        private void TimKiemButton_Click(object sender, EventArgs e)
        {
            string Mnv = MaNVTextBox.Text; if (Mnv == null) { Mnv = ""; }
            string HoTen = HoTenNVTextBox.Text; if (HoTen == null) { HoTen = ""; }
            string DiaChi = DiaChiNVTextBox.Text; if (DiaChi == null) { DiaChi = ""; }
            string GioiTinh = GioiTinhTextBox.Text; if (GioiTinh == null) { GioiTinh = ""; }
            string Sdt = SDTNVTextBox.Text; if (Sdt == null) { Sdt = ""; }
            string ChucVu = ChucVutextBox.Text; if (ChucVu == null) { ChucVu = ""; }
            float Luong = float.Parse(LuongTextBox.Text);

            if (Mnv == null && HoTen == null && DiaChi == null && GioiTinh == null && Sdt == null && ChucVu==null && Luong==null)
            {
                NhanVienDirdView.DataSource = NhanVienService.GetNhanVien();
            }

            DataTable result = NhanVienDB.SearchData(Mnv, Sdt,  DiaChi, HoTen, GioiTinh, ChucVu, Luong);

            if (result != null)
            {
                NhanVienDirdView.DataSource = result;
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
