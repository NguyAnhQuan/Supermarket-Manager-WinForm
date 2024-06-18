namespace MiniMart.PresentationLayer.Forms
{
    partial class FormSanPham
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
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.HoTenTextBox = new System.Windows.Forms.TextBox();
            this.MnvTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TimKiemButton = new System.Windows.Forms.Button();
            this.TimKiemComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.TimKiemTextBox = new System.Windows.Forms.TextBox();
            this.NhapDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NgayNhapTextBox = new System.Windows.Forms.TextBox();
            this.GiaTextBox = new System.Windows.Forms.TextBox();
            this.HetHangTextBox = new System.Windows.Forms.TextBox();
            this.HanTextBox = new System.Windows.Forms.TextBox();
            this.SoLuongTextBox = new System.Windows.Forms.TextBox();
            this.TenspTextBox = new System.Windows.Forms.TextBox();
            this.LoaiTextBox = new System.Windows.Forms.TextBox();
            this.MspTextBox = new System.Windows.Forms.TextBox();
            this.MnccTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.XoaButton = new System.Windows.Forms.Button();
            this.SuaButton = new System.Windows.Forms.Button();
            this.ThemButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TitlePanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NhapDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlePanel
            // 
            this.TitlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitlePanel.Controls.Add(this.flowLayoutPanel1);
            this.TitlePanel.Controls.Add(this.TitleLabel);
            this.TitlePanel.Controls.Add(this.TimeTextBox);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(1186, 89);
            this.TitlePanel.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.HoTenTextBox);
            this.flowLayoutPanel1.Controls.Add(this.MnvTextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1064, 6);
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
            this.TitleLabel.Location = new System.Drawing.Point(491, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(286, 35);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Quản Lý Sản Phẩm";
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.TimKiemButton);
            this.panel2.Controls.Add(this.TimKiemComboBox);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.TimKiemTextBox);
            this.panel2.Location = new System.Drawing.Point(0, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1186, 42);
            this.panel2.TabIndex = 4;
            // 
            // TimKiemButton
            // 
            this.TimKiemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimKiemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TimKiemButton.Location = new System.Drawing.Point(1046, 4);
            this.TimKiemButton.Margin = new System.Windows.Forms.Padding(2);
            this.TimKiemButton.Name = "TimKiemButton";
            this.TimKiemButton.Size = new System.Drawing.Size(124, 31);
            this.TimKiemButton.TabIndex = 3;
            this.TimKiemButton.Text = "Tìm Kiếm";
            this.TimKiemButton.UseVisualStyleBackColor = true;
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
            this.TimKiemComboBox.Location = new System.Drawing.Point(779, 5);
            this.TimKiemComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.TimKiemComboBox.Name = "TimKiemComboBox";
            this.TimKiemComboBox.Size = new System.Drawing.Size(243, 28);
            this.TimKiemComboBox.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 8);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 27);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2024, 1, 4, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker2.Location = new System.Drawing.Point(247, 7);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(230, 27);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // TimKiemTextBox
            // 
            this.TimKiemTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TimKiemTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimKiemTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TimKiemTextBox.Location = new System.Drawing.Point(562, 6);
            this.TimKiemTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TimKiemTextBox.Name = "TimKiemTextBox";
            this.TimKiemTextBox.Size = new System.Drawing.Size(195, 27);
            this.TimKiemTextBox.TabIndex = 2;
            // 
            // NhapDataGridView
            // 
            this.NhapDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NhapDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NhapDataGridView.ColumnHeadersHeight = 46;
            this.NhapDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.NhapDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NhapDataGridView.Location = new System.Drawing.Point(0, 142);
            this.NhapDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.NhapDataGridView.Name = "NhapDataGridView";
            this.NhapDataGridView.RowHeadersWidth = 82;
            this.NhapDataGridView.RowTemplate.Height = 33;
            this.NhapDataGridView.Size = new System.Drawing.Size(1186, 347);
            this.NhapDataGridView.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NgayNhapTextBox);
            this.panel1.Controls.Add(this.GiaTextBox);
            this.panel1.Controls.Add(this.HetHangTextBox);
            this.panel1.Controls.Add(this.HanTextBox);
            this.panel1.Controls.Add(this.SoLuongTextBox);
            this.panel1.Controls.Add(this.TenspTextBox);
            this.panel1.Controls.Add(this.LoaiTextBox);
            this.panel1.Controls.Add(this.MspTextBox);
            this.panel1.Controls.Add(this.MnccTextBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 495);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 137);
            this.panel1.TabIndex = 6;
            // 
            // NgayNhapTextBox
            // 
            this.NgayNhapTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.NgayNhapTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NgayNhapTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NgayNhapTextBox.Location = new System.Drawing.Point(514, 97);
            this.NgayNhapTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NgayNhapTextBox.Name = "NgayNhapTextBox";
            this.NgayNhapTextBox.Size = new System.Drawing.Size(158, 27);
            this.NgayNhapTextBox.TabIndex = 26;
            // 
            // GiaTextBox
            // 
            this.GiaTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GiaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GiaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GiaTextBox.Location = new System.Drawing.Point(514, 38);
            this.GiaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GiaTextBox.Name = "GiaTextBox";
            this.GiaTextBox.Size = new System.Drawing.Size(158, 27);
            this.GiaTextBox.TabIndex = 25;
            // 
            // HetHangTextBox
            // 
            this.HetHangTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.HetHangTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HetHangTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.HetHangTextBox.Location = new System.Drawing.Point(781, 97);
            this.HetHangTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HetHangTextBox.Name = "HetHangTextBox";
            this.HetHangTextBox.Size = new System.Drawing.Size(158, 27);
            this.HetHangTextBox.TabIndex = 24;
            // 
            // HanTextBox
            // 
            this.HanTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.HanTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HanTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.HanTextBox.Location = new System.Drawing.Point(781, 38);
            this.HanTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HanTextBox.Name = "HanTextBox";
            this.HanTextBox.Size = new System.Drawing.Size(158, 27);
            this.HanTextBox.TabIndex = 23;
            // 
            // SoLuongTextBox
            // 
            this.SoLuongTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SoLuongTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoLuongTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SoLuongTextBox.Location = new System.Drawing.Point(247, 97);
            this.SoLuongTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SoLuongTextBox.Name = "SoLuongTextBox";
            this.SoLuongTextBox.Size = new System.Drawing.Size(158, 27);
            this.SoLuongTextBox.TabIndex = 22;
            // 
            // TenspTextBox
            // 
            this.TenspTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TenspTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TenspTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TenspTextBox.Location = new System.Drawing.Point(247, 38);
            this.TenspTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TenspTextBox.Name = "TenspTextBox";
            this.TenspTextBox.Size = new System.Drawing.Size(158, 27);
            this.TenspTextBox.TabIndex = 21;
            // 
            // LoaiTextBox
            // 
            this.LoaiTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LoaiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoaiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LoaiTextBox.Location = new System.Drawing.Point(991, 38);
            this.LoaiTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LoaiTextBox.Name = "LoaiTextBox";
            this.LoaiTextBox.Size = new System.Drawing.Size(158, 27);
            this.LoaiTextBox.TabIndex = 20;
            // 
            // MspTextBox
            // 
            this.MspTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MspTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MspTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MspTextBox.Location = new System.Drawing.Point(47, 97);
            this.MspTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MspTextBox.Name = "MspTextBox";
            this.MspTextBox.Size = new System.Drawing.Size(158, 27);
            this.MspTextBox.TabIndex = 19;
            // 
            // MnccTextBox
            // 
            this.MnccTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MnccTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MnccTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MnccTextBox.Location = new System.Drawing.Point(47, 38);
            this.MnccTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MnccTextBox.Name = "MnccTextBox";
            this.MnccTextBox.Size = new System.Drawing.Size(158, 27);
            this.MnccTextBox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(988, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Phân loại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(778, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hết hạn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(778, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Hết hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ngày nhập ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã nhà cung cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sản phẩm";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.XoaButton);
            this.panel3.Controls.Add(this.SuaButton);
            this.panel3.Controls.Add(this.ThemButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel3.Location = new System.Drawing.Point(0, 638);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1186, 61);
            this.panel3.TabIndex = 7;
            // 
            // XoaButton
            // 
            this.XoaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.XoaButton.Location = new System.Drawing.Point(793, 12);
            this.XoaButton.Margin = new System.Windows.Forms.Padding(2);
            this.XoaButton.Name = "XoaButton";
            this.XoaButton.Size = new System.Drawing.Size(193, 38);
            this.XoaButton.TabIndex = 1;
            this.XoaButton.Text = "Xóa";
            this.XoaButton.UseVisualStyleBackColor = true;
            // 
            // SuaButton
            // 
            this.SuaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SuaButton.Location = new System.Drawing.Point(497, 10);
            this.SuaButton.Margin = new System.Windows.Forms.Padding(2);
            this.SuaButton.Name = "SuaButton";
            this.SuaButton.Size = new System.Drawing.Size(193, 39);
            this.SuaButton.TabIndex = 2;
            this.SuaButton.Text = "Sửa";
            this.SuaButton.UseVisualStyleBackColor = true;
            // 
            // ThemButton
            // 
            this.ThemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ThemButton.Location = new System.Drawing.Point(161, 12);
            this.ThemButton.Margin = new System.Windows.Forms.Padding(2);
            this.ThemButton.Name = "ThemButton";
            this.ThemButton.Size = new System.Drawing.Size(193, 38);
            this.ThemButton.TabIndex = 0;
            this.ThemButton.Text = "Thêm";
            this.ThemButton.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 699);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NhapDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TitlePanel);
            this.Name = "FormSanPham";
            this.Text = "FormSanPham";
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NhapDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox HoTenTextBox;
        private System.Windows.Forms.TextBox MnvTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button TimKiemButton;
        private System.Windows.Forms.ComboBox TimKiemComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox TimKiemTextBox;
        private System.Windows.Forms.DataGridView NhapDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button XoaButton;
        private System.Windows.Forms.Button SuaButton;
        private System.Windows.Forms.Button ThemButton;
        private System.Windows.Forms.TextBox MnccTextBox;
        private System.Windows.Forms.TextBox NgayNhapTextBox;
        private System.Windows.Forms.TextBox GiaTextBox;
        private System.Windows.Forms.TextBox HetHangTextBox;
        private System.Windows.Forms.TextBox HanTextBox;
        private System.Windows.Forms.TextBox SoLuongTextBox;
        private System.Windows.Forms.TextBox TenspTextBox;
        private System.Windows.Forms.TextBox LoaiTextBox;
        private System.Windows.Forms.TextBox MspTextBox;
        private System.Windows.Forms.Timer timer1;
    }
}