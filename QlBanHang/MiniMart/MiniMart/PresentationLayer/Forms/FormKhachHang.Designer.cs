namespace MiniMart.PresentationLayer.Forms
{
    partial class FormKhachHang
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
            this.DiaChiKHTextBox = new System.Windows.Forms.TextBox();
            this.SDTKHTextBox = new System.Windows.Forms.TextBox();
            this.HoTenKHTextBox = new System.Windows.Forms.TextBox();
            this.HangKhachTextBox = new System.Windows.Forms.TextBox();
            this.MkhTextBox = new System.Windows.Forms.TextBox();
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
            this.KhachHangDirdView = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TitlePanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangDirdView)).BeginInit();
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
            this.TitlePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(1767, 138);
            this.TitlePanel.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.HoTenTextBox);
            this.flowLayoutPanel1.Controls.Add(this.MnvTextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1585, 9);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(164, 112);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // HoTenTextBox
            // 
            this.HoTenTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.HoTenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HoTenTextBox.Location = new System.Drawing.Point(3, 3);
            this.HoTenTextBox.Name = "HoTenTextBox";
            this.HoTenTextBox.ReadOnly = true;
            this.HoTenTextBox.Size = new System.Drawing.Size(153, 24);
            this.HoTenTextBox.TabIndex = 0;
            // 
            // MnvTextBox
            // 
            this.MnvTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.MnvTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MnvTextBox.Location = new System.Drawing.Point(3, 33);
            this.MnvTextBox.Name = "MnvTextBox";
            this.MnvTextBox.ReadOnly = true;
            this.MnvTextBox.Size = new System.Drawing.Size(153, 24);
            this.MnvTextBox.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(741, 31);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(304, 56);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Khách Hàng";
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.TimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TimeTextBox.Location = new System.Drawing.Point(27, 44);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.ReadOnly = true;
            this.TimeTextBox.Size = new System.Drawing.Size(190, 37);
            this.TimeTextBox.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.DiaChiKHTextBox);
            this.panel3.Controls.Add(this.SDTKHTextBox);
            this.panel3.Controls.Add(this.HoTenKHTextBox);
            this.panel3.Controls.Add(this.HangKhachTextBox);
            this.panel3.Controls.Add(this.MkhTextBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 783);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1766, 154);
            this.panel3.TabIndex = 8;
            // 
            // DiaChiKHTextBox
            // 
            this.DiaChiKHTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.DiaChiKHTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiaChiKHTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DiaChiKHTextBox.Location = new System.Drawing.Point(759, 59);
            this.DiaChiKHTextBox.Name = "DiaChiKHTextBox";
            this.DiaChiKHTextBox.Size = new System.Drawing.Size(236, 38);
            this.DiaChiKHTextBox.TabIndex = 25;
            // 
            // SDTKHTextBox
            // 
            this.SDTKHTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SDTKHTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SDTKHTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SDTKHTextBox.Location = new System.Drawing.Point(1106, 59);
            this.SDTKHTextBox.Name = "SDTKHTextBox";
            this.SDTKHTextBox.Size = new System.Drawing.Size(236, 38);
            this.SDTKHTextBox.TabIndex = 22;
            // 
            // HoTenKHTextBox
            // 
            this.HoTenKHTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.HoTenKHTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HoTenKHTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.HoTenKHTextBox.Location = new System.Drawing.Point(408, 59);
            this.HoTenKHTextBox.Name = "HoTenKHTextBox";
            this.HoTenKHTextBox.Size = new System.Drawing.Size(236, 38);
            this.HoTenKHTextBox.TabIndex = 21;
            // 
            // HangKhachTextBox
            // 
            this.HangKhachTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.HangKhachTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HangKhachTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.HangKhachTextBox.Location = new System.Drawing.Point(1442, 59);
            this.HangKhachTextBox.Name = "HangKhachTextBox";
            this.HangKhachTextBox.Size = new System.Drawing.Size(236, 38);
            this.HangKhachTextBox.TabIndex = 19;
            // 
            // MkhTextBox
            // 
            this.MkhTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MkhTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MkhTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MkhTextBox.Location = new System.Drawing.Point(70, 59);
            this.MkhTextBox.Name = "MkhTextBox";
            this.MkhTextBox.Size = new System.Drawing.Size(236, 38);
            this.MkhTextBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(754, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1437, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hạng khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1101, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số điện thoại";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TimKiemButton);
            this.panel4.Controls.Add(this.XoaButton);
            this.panel4.Controls.Add(this.SuaButton);
            this.panel4.Controls.Add(this.ThemButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel4.Location = new System.Drawing.Point(0, 947);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1767, 95);
            this.panel4.TabIndex = 9;
            // 
            // TimKiemButton
            // 
            this.TimKiemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TimKiemButton.Location = new System.Drawing.Point(1348, 17);
            this.TimKiemButton.Name = "TimKiemButton";
            this.TimKiemButton.Size = new System.Drawing.Size(290, 59);
            this.TimKiemButton.TabIndex = 4;
            this.TimKiemButton.Text = "Tìm kiếm";
            this.TimKiemButton.UseVisualStyleBackColor = true;
            this.TimKiemButton.Click += new System.EventHandler(this.TimKiemButton_Click);
            // 
            // XoaButton
            // 
            this.XoaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.XoaButton.Location = new System.Drawing.Point(936, 17);
            this.XoaButton.Name = "XoaButton";
            this.XoaButton.Size = new System.Drawing.Size(290, 59);
            this.XoaButton.TabIndex = 1;
            this.XoaButton.Text = "Xóa";
            this.XoaButton.UseVisualStyleBackColor = true;
            this.XoaButton.Click += new System.EventHandler(this.XoaButton_Click);
            // 
            // SuaButton
            // 
            this.SuaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SuaButton.Location = new System.Drawing.Point(524, 17);
            this.SuaButton.Name = "SuaButton";
            this.SuaButton.Size = new System.Drawing.Size(290, 61);
            this.SuaButton.TabIndex = 2;
            this.SuaButton.Text = "Sửa";
            this.SuaButton.UseVisualStyleBackColor = true;
            this.SuaButton.Click += new System.EventHandler(this.SuaButton_Click);
            // 
            // ThemButton
            // 
            this.ThemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ThemButton.Location = new System.Drawing.Point(111, 17);
            this.ThemButton.Name = "ThemButton";
            this.ThemButton.Size = new System.Drawing.Size(290, 59);
            this.ThemButton.TabIndex = 0;
            this.ThemButton.Text = "Thêm";
            this.ThemButton.UseVisualStyleBackColor = true;
            this.ThemButton.Click += new System.EventHandler(this.ThemButton_Click);
            // 
            // KhachHangDirdView
            // 
            this.KhachHangDirdView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KhachHangDirdView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.KhachHangDirdView.ColumnHeadersHeight = 46;
            this.KhachHangDirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.KhachHangDirdView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KhachHangDirdView.Location = new System.Drawing.Point(0, 147);
            this.KhachHangDirdView.Name = "KhachHangDirdView";
            this.KhachHangDirdView.RowHeadersWidth = 82;
            this.KhachHangDirdView.RowTemplate.Height = 33;
            this.KhachHangDirdView.Size = new System.Drawing.Size(1767, 628);
            this.KhachHangDirdView.TabIndex = 10;
            this.KhachHangDirdView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KhachHangDirdView_CellClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1767, 1042);
            this.Controls.Add(this.KhachHangDirdView);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TitlePanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangDirdView)).EndInit();
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
        private System.Windows.Forms.TextBox DiaChiKHTextBox;
        private System.Windows.Forms.TextBox SDTKHTextBox;
        private System.Windows.Forms.TextBox HoTenKHTextBox;
        private System.Windows.Forms.TextBox HangKhachTextBox;
        private System.Windows.Forms.TextBox MkhTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button XoaButton;
        private System.Windows.Forms.Button SuaButton;
        private System.Windows.Forms.Button ThemButton;
        private System.Windows.Forms.DataGridView KhachHangDirdView;
        private System.Windows.Forms.Button TimKiemButton;
        private System.Windows.Forms.Timer timer1;
    }
}