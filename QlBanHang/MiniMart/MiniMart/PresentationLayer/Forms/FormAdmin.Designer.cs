namespace MiniMart.PresentationLayer.Forms
{
    partial class FormAdmin
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.GioVaoTextBox = new System.Windows.Forms.TextBox();
            this.GioRaTextBox = new System.Windows.Forms.TextBox();
            this.ManvTextBox = new System.Windows.Forms.TextBox();
            this.MatKhauTextBox = new System.Windows.Forms.TextBox();
            this.MdnTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TimKiemButton = new System.Windows.Forms.Button();
            this.XoaButton = new System.Windows.Forms.Button();
            this.SuaButton = new System.Windows.Forms.Button();
            this.ThemButton = new System.Windows.Forms.Button();
            this.DangNhapDirdView = new System.Windows.Forms.DataGridView();
            this.NhanVienGirdView = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TitlePanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DangNhapDirdView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienGirdView)).BeginInit();
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
            this.TitlePanel.Size = new System.Drawing.Size(1169, 89);
            this.TitlePanel.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.HoTenTextBox);
            this.flowLayoutPanel1.Controls.Add(this.MnvTextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1047, 6);
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
            this.TitleLabel.Location = new System.Drawing.Point(354, 20);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(460, 35);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Quản Lý Phân Quyền Hệ Thống";
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
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.GioVaoTextBox);
            this.panel3.Controls.Add(this.GioRaTextBox);
            this.panel3.Controls.Add(this.ManvTextBox);
            this.panel3.Controls.Add(this.MatKhauTextBox);
            this.panel3.Controls.Add(this.MdnTextBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(1, 510);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1168, 97);
            this.panel3.TabIndex = 7;
            // 
            // GioVaoTextBox
            // 
            this.GioVaoTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GioVaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GioVaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GioVaoTextBox.Location = new System.Drawing.Point(506, 38);
            this.GioVaoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GioVaoTextBox.Name = "GioVaoTextBox";
            this.GioVaoTextBox.Size = new System.Drawing.Size(158, 27);
            this.GioVaoTextBox.TabIndex = 25;
            // 
            // GioRaTextBox
            // 
            this.GioRaTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GioRaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GioRaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GioRaTextBox.Location = new System.Drawing.Point(737, 38);
            this.GioRaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GioRaTextBox.Name = "GioRaTextBox";
            this.GioRaTextBox.Size = new System.Drawing.Size(158, 27);
            this.GioRaTextBox.TabIndex = 22;
            // 
            // ManvTextBox
            // 
            this.ManvTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ManvTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManvTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ManvTextBox.Location = new System.Drawing.Point(272, 38);
            this.ManvTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ManvTextBox.Name = "ManvTextBox";
            this.ManvTextBox.Size = new System.Drawing.Size(158, 27);
            this.ManvTextBox.TabIndex = 21;
            // 
            // MatKhauTextBox
            // 
            this.MatKhauTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MatKhauTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatKhauTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MatKhauTextBox.Location = new System.Drawing.Point(961, 38);
            this.MatKhauTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MatKhauTextBox.Name = "MatKhauTextBox";
            this.MatKhauTextBox.Size = new System.Drawing.Size(158, 27);
            this.MatKhauTextBox.TabIndex = 19;
            // 
            // MdnTextBox
            // 
            this.MdnTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MdnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MdnTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MdnTextBox.Location = new System.Drawing.Point(47, 38);
            this.MdnTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MdnTextBox.Name = "MdnTextBox";
            this.MdnTextBox.Size = new System.Drawing.Size(158, 27);
            this.MdnTextBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Giờ vào";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(958, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(734, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giờ ra";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TimKiemButton);
            this.panel4.Controls.Add(this.XoaButton);
            this.panel4.Controls.Add(this.SuaButton);
            this.panel4.Controls.Add(this.ThemButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel4.Location = new System.Drawing.Point(0, 611);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1169, 61);
            this.panel4.TabIndex = 8;
            // 
            // TimKiemButton
            // 
            this.TimKiemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TimKiemButton.Location = new System.Drawing.Point(871, 12);
            this.TimKiemButton.Margin = new System.Windows.Forms.Padding(2);
            this.TimKiemButton.Name = "TimKiemButton";
            this.TimKiemButton.Size = new System.Drawing.Size(193, 38);
            this.TimKiemButton.TabIndex = 3;
            this.TimKiemButton.Text = "Tìm kiếm";
            this.TimKiemButton.UseVisualStyleBackColor = true;
            // 
            // XoaButton
            // 
            this.XoaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.XoaButton.Location = new System.Drawing.Point(615, 12);
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
            this.SuaButton.Location = new System.Drawing.Point(359, 12);
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
            this.ThemButton.Location = new System.Drawing.Point(103, 12);
            this.ThemButton.Margin = new System.Windows.Forms.Padding(2);
            this.ThemButton.Name = "ThemButton";
            this.ThemButton.Size = new System.Drawing.Size(193, 38);
            this.ThemButton.TabIndex = 0;
            this.ThemButton.Text = "Thêm";
            this.ThemButton.UseVisualStyleBackColor = true;
            // 
            // DangNhapDirdView
            // 
            this.DangNhapDirdView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DangNhapDirdView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DangNhapDirdView.ColumnHeadersHeight = 46;
            this.DangNhapDirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DangNhapDirdView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DangNhapDirdView.Location = new System.Drawing.Point(0, 93);
            this.DangNhapDirdView.Margin = new System.Windows.Forms.Padding(2);
            this.DangNhapDirdView.Name = "DangNhapDirdView";
            this.DangNhapDirdView.RowHeadersWidth = 82;
            this.DangNhapDirdView.RowTemplate.Height = 33;
            this.DangNhapDirdView.Size = new System.Drawing.Size(735, 412);
            this.DangNhapDirdView.TabIndex = 9;
            // 
            // NhanVienGirdView
            // 
            this.NhanVienGirdView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NhanVienGirdView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NhanVienGirdView.ColumnHeadersHeight = 46;
            this.NhanVienGirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.NhanVienGirdView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NhanVienGirdView.Location = new System.Drawing.Point(739, 93);
            this.NhanVienGirdView.Margin = new System.Windows.Forms.Padding(2);
            this.NhanVienGirdView.Name = "NhanVienGirdView";
            this.NhanVienGirdView.RowHeadersWidth = 82;
            this.NhanVienGirdView.RowTemplate.Height = 33;
            this.NhanVienGirdView.Size = new System.Drawing.Size(430, 411);
            this.NhanVienGirdView.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 672);
            this.Controls.Add(this.NhanVienGirdView);
            this.Controls.Add(this.DangNhapDirdView);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TitlePanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DangNhapDirdView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienGirdView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox HoTenTextBox;
        private System.Windows.Forms.TextBox MnvTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox GioVaoTextBox;
        private System.Windows.Forms.TextBox GioRaTextBox;
        private System.Windows.Forms.TextBox ManvTextBox;
        private System.Windows.Forms.TextBox MatKhauTextBox;
        private System.Windows.Forms.TextBox MdnTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button XoaButton;
        private System.Windows.Forms.Button SuaButton;
        private System.Windows.Forms.Button ThemButton;
        private System.Windows.Forms.DataGridView DangNhapDirdView;
        private System.Windows.Forms.DataGridView NhanVienGirdView;
        private System.Windows.Forms.Button TimKiemButton;
        private System.Windows.Forms.Timer timer1;
    }
}