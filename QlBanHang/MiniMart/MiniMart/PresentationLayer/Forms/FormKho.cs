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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniMart.PresentationLayer.Form
{
    public partial class FormKho : System.Windows.Forms.Form
    {
        public FormKho()
        {
            InitializeComponent();

            MnvTextBox.Text = LoginForm.MNV;
            HoTenTextBox.Text = LoginForm.HOTEN;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeTextBox.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void FormKho_Load(object sender, EventArgs e)
        {
            LoadDataIntoTabPage("NhapTabPage", KhoDb.DataNhap()); 
            LoadDataIntoTabPage("XuatTabPage", KhoDb.DataXuat());
        }

        private void LoadDataIntoTabPage(string tabPageName, DataTable data)
        {
            // Tìm TabPage có tên là tabPageName
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
                // Tạo một DataGridView mới
                DataGridView dataGridView = new DataGridView();
                dataGridView.Dock = DockStyle.Fill;
                dataGridView.DataSource = data;

                // Xóa bất kỳ điều khiển nào đã được thêm vào TabPage trước đó
                tabPage.Controls.Clear();

                // Thêm DataGridView vào TabPage
                tabPage.Controls.Add(dataGridView);
            }
            else
            {
                MessageBox.Show("Không tìm thấy TabPage có tên là " + tabPageName);
            }
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {

        }
    }
}
