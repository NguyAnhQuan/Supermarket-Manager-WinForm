namespace MiniMart.PresentationLayer.Form
{
    partial class FormKho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKho));
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.HoTenTextBox = new System.Windows.Forms.TextBox();
            this.MnvTextBox = new System.Windows.Forms.TextBox();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ThemButton = new System.Windows.Forms.Button();
            this.XoaButton = new System.Windows.Forms.Button();
            this.SuaButton = new System.Windows.Forms.Button();
            this.TimKiemButton = new System.Windows.Forms.Button();
            this.TimKiemTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.TimKiemComboBox = new System.Windows.Forms.ComboBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.NhapTabPage = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.XuatTabPage = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SapHetHanTabPage = new System.Windows.Forms.TabPage();
            this.NhaCungCapTabPage = new System.Windows.Forms.TabPage();
            this.SanPhamTabPage = new System.Windows.Forms.TabPage();
            this.BieuDoTabPage = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TitlePanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.NhapTabPage.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.XuatTabPage.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.BieuDoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlePanel
            // 
            this.TitlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitlePanel.Controls.Add(this.flowLayoutPanel1);
            this.TitlePanel.Controls.Add(this.TitleLabel);
            this.TitlePanel.Controls.Add(this.TimeTextBox);
            this.TitlePanel.Location = new System.Drawing.Point(9, 9);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(1933, 82);
            this.TitlePanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.HoTenTextBox);
            this.flowLayoutPanel1.Controls.Add(this.MnvTextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1813, 7);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(109, 72);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(874, 23);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(321, 56);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Quản Lý Kho";
            // 
            // HoTenTextBox
            // 
            this.HoTenTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.HoTenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HoTenTextBox.Location = new System.Drawing.Point(2, 2);
            this.HoTenTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HoTenTextBox.Name = "HoTenTextBox";
            this.HoTenTextBox.ReadOnly = true;
            this.HoTenTextBox.Size = new System.Drawing.Size(102, 24);
            this.HoTenTextBox.TabIndex = 0;
            // 
            // MnvTextBox
            // 
            this.MnvTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.MnvTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MnvTextBox.Location = new System.Drawing.Point(2, 30);
            this.MnvTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MnvTextBox.Name = "MnvTextBox";
            this.MnvTextBox.ReadOnly = true;
            this.MnvTextBox.Size = new System.Drawing.Size(102, 24);
            this.MnvTextBox.TabIndex = 1;
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.TimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TimeTextBox.Location = new System.Drawing.Point(18, 28);
            this.TimeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.ReadOnly = true;
            this.TimeTextBox.Size = new System.Drawing.Size(127, 37);
            this.TimeTextBox.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.SuaButton);
            this.panel2.Controls.Add(this.XoaButton);
            this.panel2.Controls.Add(this.ThemButton);
            this.panel2.Location = new System.Drawing.Point(3, 871);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1889, 56);
            this.panel2.TabIndex = 1;
            // 
            // ThemButton
            // 
            this.ThemButton.Location = new System.Drawing.Point(445, 24);
            this.ThemButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ThemButton.Name = "ThemButton";
            this.ThemButton.Size = new System.Drawing.Size(100, 30);
            this.ThemButton.TabIndex = 0;
            this.ThemButton.Text = "Thêm";
            this.ThemButton.UseVisualStyleBackColor = true;
            // 
            // XoaButton
            // 
            this.XoaButton.Location = new System.Drawing.Point(1307, 24);
            this.XoaButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.XoaButton.Name = "XoaButton";
            this.XoaButton.Size = new System.Drawing.Size(100, 30);
            this.XoaButton.TabIndex = 1;
            this.XoaButton.Text = "Xóa";
            this.XoaButton.UseVisualStyleBackColor = true;
            // 
            // SuaButton
            // 
            this.SuaButton.Location = new System.Drawing.Point(931, 24);
            this.SuaButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SuaButton.Name = "SuaButton";
            this.SuaButton.Size = new System.Drawing.Size(100, 30);
            this.SuaButton.TabIndex = 2;
            this.SuaButton.Text = "Sửa";
            this.SuaButton.UseVisualStyleBackColor = true;
            // 
            // TimKiemButton
            // 
            this.TimKiemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimKiemButton.Location = new System.Drawing.Point(344, 6);
            this.TimKiemButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TimKiemButton.Name = "TimKiemButton";
            this.TimKiemButton.Size = new System.Drawing.Size(124, 30);
            this.TimKiemButton.TabIndex = 3;
            this.TimKiemButton.Text = "Tìm Kiếm";
            this.TimKiemButton.UseVisualStyleBackColor = true;
            // 
            // TimKiemTextBox
            // 
            this.TimKiemTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TimKiemTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimKiemTextBox.Location = new System.Drawing.Point(2, 13);
            this.TimKiemTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TimKiemTextBox.Name = "TimKiemTextBox";
            this.TimKiemTextBox.Size = new System.Drawing.Size(195, 24);
            this.TimKiemTextBox.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.TimKiemComboBox);
            this.panel1.Controls.Add(this.TimKiemButton);
            this.panel1.Controls.Add(this.TimKiemTextBox);
            this.panel1.Location = new System.Drawing.Point(1409, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 55);
            this.panel1.TabIndex = 4;
            // 
            // TimKiemComboBox
            // 
            this.TimKiemComboBox.FormattingEnabled = true;
            this.TimKiemComboBox.Items.AddRange(new object[] {
            "Mnx",
            "Msp",
            "Mncc",
            "SoLuong",
            "TongGia"});
            this.TimKiemComboBox.Location = new System.Drawing.Point(67, 6);
            this.TimKiemComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TimKiemComboBox.Name = "TimKiemComboBox";
            this.TimKiemComboBox.Size = new System.Drawing.Size(243, 33);
            this.TimKiemComboBox.TabIndex = 2;
            // 
            // TabControl
            // 
            this.TabControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TabControl.Controls.Add(this.NhapTabPage);
            this.TabControl.Controls.Add(this.XuatTabPage);
            this.TabControl.Controls.Add(this.SapHetHanTabPage);
            this.TabControl.Controls.Add(this.NhaCungCapTabPage);
            this.TabControl.Controls.Add(this.SanPhamTabPage);
            this.TabControl.Controls.Add(this.BieuDoTabPage);
            this.TabControl.Location = new System.Drawing.Point(8, 96);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1932, 1004);
            this.TabControl.TabIndex = 2;
            // 
            // NhapTabPage
            // 
            this.NhapTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NhapTabPage.Controls.Add(this.panel3);
            this.NhapTabPage.Location = new System.Drawing.Point(8, 39);
            this.NhapTabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NhapTabPage.Name = "NhapTabPage";
            this.NhapTabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NhapTabPage.Size = new System.Drawing.Size(1916, 957);
            this.NhapTabPage.TabIndex = 0;
            this.NhapTabPage.Text = "Trang Nhập";
            this.NhapTabPage.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(4, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1896, 939);
            this.panel3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 70);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1890, 797);
            this.dataGridView1.TabIndex = 0;
            // 
            // XuatTabPage
            // 
            this.XuatTabPage.Controls.Add(this.panel4);
            this.XuatTabPage.Location = new System.Drawing.Point(8, 39);
            this.XuatTabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.XuatTabPage.Name = "XuatTabPage";
            this.XuatTabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.XuatTabPage.Size = new System.Drawing.Size(1902, 652);
            this.XuatTabPage.TabIndex = 2;
            this.XuatTabPage.Text = "Trang Xuất";
            this.XuatTabPage.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Location = new System.Drawing.Point(16, 12);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1873, 636);
            this.panel4.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(2, 2);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(1869, 632);
            this.dataGridView2.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(2, 2);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(293, 31);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // SapHetHanTabPage
            // 
            this.SapHetHanTabPage.Location = new System.Drawing.Point(8, 39);
            this.SapHetHanTabPage.Name = "SapHetHanTabPage";
            this.SapHetHanTabPage.Size = new System.Drawing.Size(1902, 652);
            this.SapHetHanTabPage.TabIndex = 3;
            this.SapHetHanTabPage.Text = "Sản phẩm sắp hết hạn";
            this.SapHetHanTabPage.UseVisualStyleBackColor = true;
            // 
            // NhaCungCapTabPage
            // 
            this.NhaCungCapTabPage.Location = new System.Drawing.Point(8, 39);
            this.NhaCungCapTabPage.Name = "NhaCungCapTabPage";
            this.NhaCungCapTabPage.Size = new System.Drawing.Size(1902, 652);
            this.NhaCungCapTabPage.TabIndex = 4;
            this.NhaCungCapTabPage.Text = "Nhà cung cấp";
            this.NhaCungCapTabPage.UseVisualStyleBackColor = true;
            // 
            // SanPhamTabPage
            // 
            this.SanPhamTabPage.Location = new System.Drawing.Point(8, 39);
            this.SanPhamTabPage.Name = "SanPhamTabPage";
            this.SanPhamTabPage.Size = new System.Drawing.Size(1902, 652);
            this.SanPhamTabPage.TabIndex = 5;
            this.SanPhamTabPage.Text = "Sản phẩm";
            this.SanPhamTabPage.UseVisualStyleBackColor = true;
            // 
            // BieuDoTabPage
            // 
            this.BieuDoTabPage.Controls.Add(this.chart1);
            this.BieuDoTabPage.Location = new System.Drawing.Point(8, 39);
            this.BieuDoTabPage.Name = "BieuDoTabPage";
            this.BieuDoTabPage.Size = new System.Drawing.Size(1902, 652);
            this.BieuDoTabPage.TabIndex = 6;
            this.BieuDoTabPage.Text = "Biểu đồ";
            this.BieuDoTabPage.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1896, 649);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Location = new System.Drawing.Point(7, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1882, 59);
            this.panel5.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(410, 2);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(293, 31);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dateTimePicker1);
            this.panel6.Controls.Add(this.dateTimePicker2);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(718, 56);
            this.panel6.TabIndex = 7;
            // 
            // FormKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1951, 1111);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.TitlePanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKho";
            this.Text = "  System MiniMart - Kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.NhapTabPage.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.XuatTabPage.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.BieuDoTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox HoTenTextBox;
        private System.Windows.Forms.TextBox MnvTextBox;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ThemButton;
        private System.Windows.Forms.Button TimKiemButton;
        private System.Windows.Forms.Button SuaButton;
        private System.Windows.Forms.TextBox TimKiemTextBox;
        private System.Windows.Forms.Button XoaButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox TimKiemComboBox;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage NhapTabPage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage XuatTabPage;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabPage SapHetHanTabPage;
        private System.Windows.Forms.TabPage NhaCungCapTabPage;
        private System.Windows.Forms.TabPage SanPhamTabPage;
        private System.Windows.Forms.TabPage BieuDoTabPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}