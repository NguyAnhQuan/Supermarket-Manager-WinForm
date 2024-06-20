using MiniMart.BusinessLogicLayer.Services;
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MiniMart.PresentationLayer.Forms
{
    public partial class FromKeToan : System.Windows.Forms.Form
    {
        private KeToanLG keToanLG;

        public FromKeToan()
        {
            InitializeComponent();
            MnvTextBox.Text = LoginForm.MNV;
            HoTenTextBox.Text = LoginForm.HOTEN;

            keToanLG = new KeToanLG();

            ThuCheckBox.CheckedChanged += ThuCheckBox_CheckedChanged;
            ChiCheckBox.CheckedChanged += ChiCheckBox_CheckedChanged;
            TaiChinhcheckBox.CheckedChanged += TaiChinhcheckBox_CheckedChanged;

            timer1.Start();
        }

        private void ThuCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ThuCheckBox.Checked)
            {
                DataTable dt = keToanLG.GetThongKeThuData();
                UpdateChart("ThongKeThu", dt, "ThanhTien", SeriesChartType.Column);
            }
            else
            {
                ClearChartSeries("ThongKeThu");
            }
        }

        private void ChiCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ChiCheckBox.Checked)
            {
                DataTable dt = keToanLG.GetThongKeChiData();
                UpdateChart("ThongKeChi", dt, "TongGia", SeriesChartType.Column);
            }
            else
            {
                ClearChartSeries("ThongKeChi");
            }
        }

        private void TaiChinhcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TaiChinhcheckBox.Checked)
            {
                DataTable dt = keToanLG.GetThongKeTaiChinhData();

                if (dt != null && dt.Rows.Count > 0)
                {
                    UpdateChart("ThongKeTaiChinh", dt, "TienLaiLo", SeriesChartType.Line);
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiChinhcheckBox.Checked = false; 
                }
            }
            else
            {
                ClearChartSeries("ThongKeTaiChinh");
            }
        }

        private void UpdateChart(string seriesName, DataTable dt, string columnName, SeriesChartType chartType)
        {
            KeToanchart.Series[seriesName].Points.Clear();
            KeToanchart.Series[seriesName].ChartType = chartType;

            foreach (DataRow row in dt.Rows)
            {
                object value = row[columnName];
                if (value != DBNull.Value)
                {
                    double numericValue;
                    if (double.TryParse(value.ToString(), out numericValue))
                    {
                        KeToanchart.Series[seriesName].Points.AddY(numericValue);
                    }                    
                }
                else
                {
                    MessageBox.Show("Không nhận được dữ liệu");
                }
            }
        }

        private void ClearChartSeries(string seriesName)
        {
            KeToanchart.Series[seriesName].Points.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeTextBox.Text = DateTime.Now.ToString("HH:mm:ss");
        }

    }
}
