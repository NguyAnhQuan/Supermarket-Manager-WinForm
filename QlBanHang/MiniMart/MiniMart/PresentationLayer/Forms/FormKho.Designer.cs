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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKho));
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.HoTenTextBox = new System.Windows.Forms.TextBox();
            this.MnvTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.TimKiemButton = new System.Windows.Forms.Button();
            this.TimKiemTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimKiemComboBox = new System.Windows.Forms.ComboBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.NhapTabPage = new System.Windows.Forms.TabPage();
            this.NhapDataGridView = new System.Windows.Forms.DataGridView();
            this.XuatTabPage = new System.Windows.Forms.TabPage();
            this.SapHetHanTabPage = new System.Windows.Forms.TabPage();
            this.NhaCungCapTabPage = new System.Windows.Forms.TabPage();
            this.SanPhamTabPage = new System.Windows.Forms.TabPage();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.XoaButton = new System.Windows.Forms.Button();
            this.SuaButton = new System.Windows.Forms.Button();
            this.ThemButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LuuButton = new System.Windows.Forms.Button();
            this.MspTextBox = new System.Windows.Forms.TextBox();
            this.MnccTextBox = new System.Windows.Forms.TextBox();
            this.SoLuongTextBox = new System.Windows.Forms.TextBox();
            this.ThoiGianTextBox = new System.Windows.Forms.TextBox();
            this.TongGiaTextBox = new System.Windows.Forms.TextBox();
            this.MNXtextBox = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TitlePanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.NhapTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NhapDataGridView)).BeginInit();
            this.XuatTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            //this.BieuDoTabPage.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();

            this.SuspendLayout();
            // 
            // TitlePanel
            // 
            this.TitlePanel.Controls.Add(this.flowLayoutPanel1);
            this.TitlePanel.Controls.Add(this.TitleLabel);
            this.TitlePanel.Controls.Add(this.TimeTextBox);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(1423, 82);
            this.TitlePanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.HoTenTextBox);
            this.flowLayoutPanel1.Controls.Add(this.MnvTextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1303, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(109, 72);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // HoTenTextBox
            // 
            this.HoTenTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.HoTenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HoTenTextBox.Location = new System.Drawing.Point(2, 2);
            this.HoTenTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HoTenTextBox.Name = "HoTenTextBox";
            this.HoTenTextBox.ReadOnly = true;
            this.HoTenTextBox.Size = new System.Drawing.Size(102, 15);
            this.HoTenTextBox.TabIndex = 0;
            // 
            // MnvTextBox
            // 
            this.MnvTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.MnvTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MnvTextBox.Location = new System.Drawing.Point(2, 21);
            this.MnvTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MnvTextBox.Name = "MnvTextBox";
            this.MnvTextBox.ReadOnly = true;
            this.MnvTextBox.Size = new System.Drawing.Size(102, 15);
            this.MnvTextBox.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(551, 13);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(200, 35);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Quản Lý Kho";
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.TimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TimeTextBox.Location = new System.Drawing.Point(18, 28);
            this.TimeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.ReadOnly = true;
            this.TimeTextBox.Size = new System.Drawing.Size(127, 23);
            this.TimeTextBox.TabIndex = 2;
            // 
            // TimKiemButton
            // 
            this.TimKiemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimKiemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TimKiemButton.Location = new System.Drawing.Point(1297, 4);
            this.TimKiemButton.Margin = new System.Windows.Forms.Padding(2);
            this.TimKiemButton.Name = "TimKiemButton";
            this.TimKiemButton.Size = new System.Drawing.Size(124, 31);
            this.TimKiemButton.TabIndex = 3;
            this.TimKiemButton.Text = "Tìm Kiếm";
            this.TimKiemButton.UseVisualStyleBackColor = true;
            this.TimKiemButton.Click += new System.EventHandler(this.TimKiemButton_Click);
            // 
            // TimKiemTextBox
            // 
            this.TimKiemTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TimKiemTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimKiemTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TimKiemTextBox.Location = new System.Drawing.Point(837, 6);
            this.TimKiemTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TimKiemTextBox.Name = "TimKiemTextBox";
            this.TimKiemTextBox.Size = new System.Drawing.Size(195, 27);
            this.TimKiemTextBox.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimKiemComboBox
            // 
            this.TimKiemComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TimKiemComboBox.FormattingEnabled = true;
            this.TimKiemComboBox.Items.AddRange(new object[] {
            "Mnx",
            "Msp",
            "Mncc",
            "SoLuong",
            "TongGia"});
            this.TimKiemComboBox.Location = new System.Drawing.Point(1042, 6);
            this.TimKiemComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.TimKiemComboBox.Name = "TimKiemComboBox";
            this.TimKiemComboBox.Size = new System.Drawing.Size(243, 28);
            this.TimKiemComboBox.TabIndex = 2;
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TabControl.Controls.Add(this.NhapTabPage);
            this.TabControl.Controls.Add(this.XuatTabPage);
            this.TabControl.Controls.Add(this.SapHetHanTabPage);
            this.TabControl.Controls.Add(this.NhaCungCapTabPage);
            this.TabControl.Controls.Add(this.SanPhamTabPage);
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TabControl.Location = new System.Drawing.Point(8, 134);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(961, 881);
            this.TabControl.TabIndex = 2;
            // 
            // NhapTabPage
            // 
            this.NhapTabPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NhapTabPage.Controls.Add(this.NhapDataGridView);
            this.NhapTabPage.Location = new System.Drawing.Point(4, 29);
            this.NhapTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.NhapTabPage.Name = "NhapTabPage";
            this.NhapTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.NhapTabPage.Size = new System.Drawing.Size(953, 848);
            this.NhapTabPage.TabIndex = 0;
            this.NhapTabPage.Text = "Trang Nhập";
            this.NhapTabPage.UseVisualStyleBackColor = true;
            // 
            // NhapDataGridView
            // 
            this.NhapDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NhapDataGridView.ColumnHeadersHeight = 46;
            this.NhapDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.NhapDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NhapDataGridView.Location = new System.Drawing.Point(-1, 1);
            this.NhapDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.NhapDataGridView.Name = "NhapDataGridView";
            this.NhapDataGridView.RowHeadersWidth = 82;
            this.NhapDataGridView.RowTemplate.Height = 33;
            this.NhapDataGridView.Size = new System.Drawing.Size(940, 821);
            this.NhapDataGridView.TabIndex = 0;
            // 
            // XuatTabPage
            // 
            this.XuatTabPage.Controls.Add(this.dataGridView2);
            this.XuatTabPage.Location = new System.Drawing.Point(4, 29);
            this.XuatTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.XuatTabPage.Name = "XuatTabPage";
            this.XuatTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.XuatTabPage.Size = new System.Drawing.Size(953, 848);
            this.XuatTabPage.TabIndex = 2;
            this.XuatTabPage.Text = "Trang Xuất";
            this.XuatTabPage.UseVisualStyleBackColor = true;
            // 
            // SapHetHanTabPage
            // 
            this.SapHetHanTabPage.Location = new System.Drawing.Point(4, 29);
            this.SapHetHanTabPage.Name = "SapHetHanTabPage";
            this.SapHetHanTabPage.Size = new System.Drawing.Size(953, 848);
            this.SapHetHanTabPage.TabIndex = 3;
            this.SapHetHanTabPage.Text = "Sản phẩm sắp hết hạn";
            this.SapHetHanTabPage.UseVisualStyleBackColor = true;
            // 
            // NhaCungCapTabPage
            // 
            this.NhaCungCapTabPage.Location = new System.Drawing.Point(4, 29);
            this.NhaCungCapTabPage.Name = "NhaCungCapTabPage";
            this.NhaCungCapTabPage.Size = new System.Drawing.Size(953, 848);
            this.NhaCungCapTabPage.TabIndex = 4;
            this.NhaCungCapTabPage.Text = "Nhà cung cấp";
            this.NhaCungCapTabPage.UseVisualStyleBackColor = true;
            // 
            // SanPhamTabPage
            // 
            this.SanPhamTabPage.Location = new System.Drawing.Point(4, 29);
            this.SanPhamTabPage.Name = "SanPhamTabPage";
            this.SanPhamTabPage.Size = new System.Drawing.Size(953, 848);
            this.SanPhamTabPage.TabIndex = 5;
            this.SanPhamTabPage.Text = "Sản phẩm";
            this.SanPhamTabPage.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker2.Location = new System.Drawing.Point(325, 8);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(293, 27);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 8);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(293, 27);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2024, 1, 4, 0, 0, 0, 0);
            // 
            // XoaButton
            // 
            this.XoaButton.Location = new System.Drawing.Point(639, 30);
            this.XoaButton.Margin = new System.Windows.Forms.Padding(2);
            this.XoaButton.Name = "XoaButton";
            this.XoaButton.Size = new System.Drawing.Size(193, 38);
            this.XoaButton.TabIndex = 1;
            this.XoaButton.Text = "Xóa";
            this.XoaButton.UseVisualStyleBackColor = true;
            this.XoaButton.Click += new System.EventHandler(this.XoaButton_Click);
            // 
            // SuaButton
            // 
            this.SuaButton.Location = new System.Drawing.Point(406, 29);
            this.SuaButton.Margin = new System.Windows.Forms.Padding(2);
            this.SuaButton.Name = "SuaButton";
            this.SuaButton.Size = new System.Drawing.Size(193, 39);
            this.SuaButton.TabIndex = 2;
            this.SuaButton.Text = "Sửa";
            this.SuaButton.UseVisualStyleBackColor = true;
            this.SuaButton.Click += new System.EventHandler(this.SuaButton_Click_1);
            // 
            // ThemButton
            // 
            this.ThemButton.Location = new System.Drawing.Point(161, 30);
            this.ThemButton.Margin = new System.Windows.Forms.Padding(2);
            this.ThemButton.Name = "ThemButton";
            this.ThemButton.Size = new System.Drawing.Size(193, 38);
            this.ThemButton.TabIndex = 0;
            this.ThemButton.Text = "Thêm";
            this.ThemButton.UseVisualStyleBackColor = true;
            this.ThemButton.Click += new System.EventHandler(this.ThemButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.XoaButton);
            this.panel1.Controls.Add(this.SuaButton);
            this.panel1.Controls.Add(this.ThemButton);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(252, 1020);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 79);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TimKiemButton);
            this.panel2.Controls.Add(this.TimKiemComboBox);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.TimKiemTextBox);
            this.panel2.Location = new System.Drawing.Point(7, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1470, 49);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.LuuButton);
            this.panel3.Controls.Add(this.MspTextBox);
            this.panel3.Controls.Add(this.MnccTextBox);
            this.panel3.Controls.Add(this.SoLuongTextBox);
            this.panel3.Controls.Add(this.ThoiGianTextBox);
            this.panel3.Controls.Add(this.TongGiaTextBox);
            this.panel3.Controls.Add(this.MNXtextBox);
            this.panel3.Location = new System.Drawing.Point(981, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(441, 843);
            this.panel3.TabIndex = 4;
            // 
            // LuuButton
            // 
            this.LuuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LuuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LuuButton.Location = new System.Drawing.Point(165, 478);
            this.LuuButton.Margin = new System.Windows.Forms.Padding(2);
            this.LuuButton.Name = "LuuButton";
            this.LuuButton.Size = new System.Drawing.Size(124, 31);
            this.LuuButton.TabIndex = 7;
            this.LuuButton.Text = "Lưu ";
            this.LuuButton.UseVisualStyleBackColor = true;
            // 
            // MspTextBox
            // 
            this.MspTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MspTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MspTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MspTextBox.Location = new System.Drawing.Point(88, 104);
            this.MspTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MspTextBox.Name = "MspTextBox";
            this.MspTextBox.Size = new System.Drawing.Size(278, 27);
            this.MspTextBox.TabIndex = 12;
            // 
            // MnccTextBox
            // 
            this.MnccTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MnccTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MnccTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MnccTextBox.Location = new System.Drawing.Point(88, 174);
            this.MnccTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MnccTextBox.Name = "MnccTextBox";
            this.MnccTextBox.Size = new System.Drawing.Size(278, 27);
            this.MnccTextBox.TabIndex = 11;
            // 
            // SoLuongTextBox
            // 
            this.SoLuongTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SoLuongTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoLuongTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SoLuongTextBox.Location = new System.Drawing.Point(88, 244);
            this.SoLuongTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SoLuongTextBox.Name = "SoLuongTextBox";
            this.SoLuongTextBox.Size = new System.Drawing.Size(278, 27);
            this.SoLuongTextBox.TabIndex = 10;
            // 
            // ThoiGianTextBox
            // 
            this.ThoiGianTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ThoiGianTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThoiGianTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ThoiGianTextBox.Location = new System.Drawing.Point(88, 384);
            this.ThoiGianTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ThoiGianTextBox.Name = "ThoiGianTextBox";
            this.ThoiGianTextBox.Size = new System.Drawing.Size(278, 27);
            this.ThoiGianTextBox.TabIndex = 9;
            // 
            // TongGiaTextBox
            // 
            this.TongGiaTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TongGiaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TongGiaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TongGiaTextBox.Location = new System.Drawing.Point(88, 314);
            this.TongGiaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TongGiaTextBox.Name = "TongGiaTextBox";
            this.TongGiaTextBox.Size = new System.Drawing.Size(278, 27);
            this.TongGiaTextBox.TabIndex = 8;
            // 
            // MNXtextBox
            // 
            this.MNXtextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MNXtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MNXtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MNXtextBox.Location = new System.Drawing.Point(88, 34);
            this.MNXtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MNXtextBox.Name = "MNXtextBox";
            this.MNXtextBox.Size = new System.Drawing.Size(278, 27);
            this.MNXtextBox.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 4);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(941, 820);
            this.dataGridView2.TabIndex = 0;
            // 
            // FormKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 1142);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.TitlePanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKho";
            this.Text = "  System MiniMart - Kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormKho_Load);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.NhapTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NhapDataGridView)).EndInit();
            this.XuatTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            //this.BieuDoTabPage.ResumeLayout(false);
            //((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox HoTenTextBox;
        private System.Windows.Forms.TextBox MnvTextBox;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.Button TimKiemButton;
        private System.Windows.Forms.TextBox TimKiemTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox TimKiemComboBox;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage NhapTabPage;
        private System.Windows.Forms.TabPage XuatTabPage;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TabPage SapHetHanTabPage;
        private System.Windows.Forms.TabPage NhaCungCapTabPage;
        private System.Windows.Forms.TabPage SanPhamTabPage;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView NhapDataGridView;
        private System.Windows.Forms.Button XoaButton;
        private System.Windows.Forms.Button SuaButton;
        private System.Windows.Forms.Button ThemButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TongGiaTextBox;
        private System.Windows.Forms.TextBox MNXtextBox;
        private System.Windows.Forms.Button LuuButton;
        private System.Windows.Forms.TextBox MspTextBox;
        private System.Windows.Forms.TextBox MnccTextBox;
        private System.Windows.Forms.TextBox SoLuongTextBox;
        private System.Windows.Forms.TextBox ThoiGianTextBox;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}