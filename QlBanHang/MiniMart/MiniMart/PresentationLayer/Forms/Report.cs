using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace MiniMart.PresentationLayer.Forms
{
    public partial class Report : System.Windows.Forms.Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            var dataSet = new QuanLySieuThiDataSet1();

            var sanPhamTableAdapter = new QuanLySieuThiDataSet1TableAdapters.sp_JoinNhaCungCapSanPhamTableAdapter();
            sanPhamTableAdapter.Fill(dataSet.sp_JoinNhaCungCapSanPham);

            ReportDataSource reportDataSource = new ReportDataSource("SanPham", (DataTable)dataSet.sp_JoinNhaCungCapSanPham);


            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            //this.reportViewer1.LocalReport.ReportPath = "MiniMart.PresentationLayer.Forms.report.SanPham.rdlc";
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
