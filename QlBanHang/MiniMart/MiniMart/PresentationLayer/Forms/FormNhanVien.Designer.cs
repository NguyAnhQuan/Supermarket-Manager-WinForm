namespace MiniMart.PresentationLayer.Forms
{
    partial class FormNhanVien
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.TimKiemButton = new System.Windows.Forms.Button();
            this.XoaButton = new System.Windows.Forms.Button();
            this.SuaButton = new System.Windows.Forms.Button();
            this.ThemButton = new System.Windows.Forms.Button();
            this.NhanVienDirdView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LuongTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ChucVuTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DiaChiNVTextBox = new System.Windows.Forms.TextBox();
            this.SDTNVTextBox = new System.Windows.Forms.TextBox();
            this.HoTenNVTextBox = new System.Windows.Forms.TextBox();
            this.SinhNhatTextBox = new System.Windows.Forms.TextBox();
            this.GioiTinhTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MaNVTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TitlePanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienDirdView)).BeginInit();
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
            this.TitlePanel.Size = new System.Drawing.Size(1168, 89);
            this.TitlePanel.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.HoTenTextBox);
            this.flowLayoutPanel1.Controls.Add(this.MnvTextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1046, 6);
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
            this.TitleLabel.Location = new System.Drawing.Point(504, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(160, 35);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Nhân Viên";
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
            // panel4
            // 
            this.panel4.Controls.Add(this.TimKiemButton);
            this.panel4.Controls.Add(this.XoaButton);
            this.panel4.Controls.Add(this.SuaButton);
            this.panel4.Controls.Add(this.ThemButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel4.Location = new System.Drawing.Point(0, 681);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1168, 61);
            this.panel4.TabIndex = 10;
            // 
            // TimKiemButton
            // 
            this.TimKiemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TimKiemButton.Location = new System.Drawing.Point(899, 11);
            this.TimKiemButton.Margin = new System.Windows.Forms.Padding(2);
            this.TimKiemButton.Name = "TimKiemButton";
            this.TimKiemButton.Size = new System.Drawing.Size(193, 38);
            this.TimKiemButton.TabIndex = 4;
            this.TimKiemButton.Text = "Tìm kiếm";
            this.TimKiemButton.UseVisualStyleBackColor = true;
            // 
            // XoaButton
            // 
            this.XoaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.XoaButton.Location = new System.Drawing.Point(624, 11);
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
            this.SuaButton.Location = new System.Drawing.Point(349, 11);
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
            this.ThemButton.Location = new System.Drawing.Point(74, 11);
            this.ThemButton.Margin = new System.Windows.Forms.Padding(2);
            this.ThemButton.Name = "ThemButton";
            this.ThemButton.Size = new System.Drawing.Size(193, 38);
            this.ThemButton.TabIndex = 0;
            this.ThemButton.Text = "Thêm";
            this.ThemButton.UseVisualStyleBackColor = true;
            // 
            // NhanVienDirdView
            // 
            this.NhanVienDirdView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NhanVienDirdView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NhanVienDirdView.ColumnHeadersHeight = 46;
            this.NhanVienDirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.NhanVienDirdView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NhanVienDirdView.Location = new System.Drawing.Point(0, 94);
            this.NhanVienDirdView.Margin = new System.Windows.Forms.Padding(2);
            this.NhanVienDirdView.Name = "NhanVienDirdView";
            this.NhanVienDirdView.RowHeadersWidth = 82;
            this.NhanVienDirdView.RowTemplate.Height = 33;
            this.NhanVienDirdView.Size = new System.Drawing.Size(1168, 434);
            this.NhanVienDirdView.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.LuongTextBox);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.ChucVuTextBox);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.DiaChiNVTextBox);
            this.panel3.Controls.Add(this.SDTNVTextBox);
            this.panel3.Controls.Add(this.HoTenNVTextBox);
            this.panel3.Controls.Add(this.SinhNhatTextBox);
            this.panel3.Controls.Add(this.GioiTinhTextBox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.MaNVTextBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 533);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1168, 142);
            this.panel3.TabIndex = 12;
            // 
            // LuongTextBox
            // 
            this.LuongTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LuongTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LuongTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LuongTextBox.Location = new System.Drawing.Point(961, 95);
            this.LuongTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LuongTextBox.Name = "LuongTextBox";
            this.LuongTextBox.Size = new System.Drawing.Size(158, 27);
            this.LuongTextBox.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(958, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Lương";
            // 
            // ChucVuTextBox
            // 
            this.ChucVuTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ChucVuTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChucVuTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ChucVuTextBox.Location = new System.Drawing.Point(677, 95);
            this.ChucVuTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ChucVuTextBox.Name = "ChucVuTextBox";
            this.ChucVuTextBox.Size = new System.Drawing.Size(158, 27);
            this.ChucVuTextBox.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(674, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Chức vụ";
            // 
            // DiaChiNVTextBox
            // 
            this.DiaChiNVTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.DiaChiNVTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiaChiNVTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DiaChiNVTextBox.Location = new System.Drawing.Point(677, 38);
            this.DiaChiNVTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DiaChiNVTextBox.Name = "DiaChiNVTextBox";
            this.DiaChiNVTextBox.Size = new System.Drawing.Size(158, 27);
            this.DiaChiNVTextBox.TabIndex = 25;
            // 
            // SDTNVTextBox
            // 
            this.SDTNVTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SDTNVTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SDTNVTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SDTNVTextBox.Location = new System.Drawing.Point(339, 95);
            this.SDTNVTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SDTNVTextBox.Name = "SDTNVTextBox";
            this.SDTNVTextBox.Size = new System.Drawing.Size(158, 27);
            this.SDTNVTextBox.TabIndex = 22;
            // 
            // HoTenNVTextBox
            // 
            this.HoTenNVTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.HoTenNVTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HoTenNVTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.HoTenNVTextBox.Location = new System.Drawing.Point(339, 38);
            this.HoTenNVTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HoTenNVTextBox.Name = "HoTenNVTextBox";
            this.HoTenNVTextBox.Size = new System.Drawing.Size(158, 27);
            this.HoTenNVTextBox.TabIndex = 21;
            // 
            // SinhNhatTextBox
            // 
            this.SinhNhatTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SinhNhatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SinhNhatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SinhNhatTextBox.Location = new System.Drawing.Point(961, 38);
            this.SinhNhatTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SinhNhatTextBox.Name = "SinhNhatTextBox";
            this.SinhNhatTextBox.Size = new System.Drawing.Size(158, 27);
            this.SinhNhatTextBox.TabIndex = 19;
            // 
            // GioiTinhTextBox
            // 
            this.GioiTinhTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GioiTinhTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GioiTinhTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GioiTinhTextBox.Location = new System.Drawing.Point(47, 95);
            this.GioiTinhTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GioiTinhTextBox.Name = "GioiTinhTextBox";
            this.GioiTinhTextBox.Size = new System.Drawing.Size(158, 27);
            this.GioiTinhTextBox.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Giới tính ";
            // 
            // MaNVTextBox
            // 
            this.MaNVTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MaNVTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaNVTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaNVTextBox.Location = new System.Drawing.Point(47, 38);
            this.MaNVTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaNVTextBox.Name = "MaNVTextBox";
            this.MaNVTextBox.Size = new System.Drawing.Size(158, 27);
            this.MaNVTextBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(674, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(958, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sinh nhật ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số điện thoại";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 742);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.NhanVienDirdView);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.TitlePanel);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienDirdView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox HoTenTextBox;
        private System.Windows.Forms.TextBox MnvTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button TimKiemButton;
        private System.Windows.Forms.Button XoaButton;
        private System.Windows.Forms.Button SuaButton;
        private System.Windows.Forms.Button ThemButton;
        private System.Windows.Forms.DataGridView NhanVienDirdView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox DiaChiNVTextBox;
        private System.Windows.Forms.TextBox SDTNVTextBox;
        private System.Windows.Forms.TextBox HoTenNVTextBox;
        private System.Windows.Forms.TextBox SinhNhatTextBox;
        private System.Windows.Forms.TextBox MaNVTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LuongTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ChucVuTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox GioiTinhTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}