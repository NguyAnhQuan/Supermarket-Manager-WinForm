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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.ButtonOut = new System.Windows.Forms.Button();
            this.buttonPowert = new System.Windows.Forms.Button();
            this.TitlePanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DangNhapDirdView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.TitlePanel.Size = new System.Drawing.Size(1754, 138);
            this.TitlePanel.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.HoTenTextBox);
            this.flowLayoutPanel1.Controls.Add(this.MnvTextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1572, 9);
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
            this.TitleLabel.Location = new System.Drawing.Point(532, 31);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(741, 56);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Quản Lý Phân Quyền Hệ Thống";
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
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
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
            this.panel3.Location = new System.Drawing.Point(2, 797);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1751, 150);
            this.panel3.TabIndex = 7;
            // 
            // GioVaoTextBox
            // 
            this.GioVaoTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GioVaoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GioVaoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GioVaoTextBox.Location = new System.Drawing.Point(759, 59);
            this.GioVaoTextBox.Name = "GioVaoTextBox";
            this.GioVaoTextBox.Size = new System.Drawing.Size(236, 38);
            this.GioVaoTextBox.TabIndex = 25;
            // 
            // GioRaTextBox
            // 
            this.GioRaTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GioRaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GioRaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GioRaTextBox.Location = new System.Drawing.Point(1106, 59);
            this.GioRaTextBox.Name = "GioRaTextBox";
            this.GioRaTextBox.Size = new System.Drawing.Size(236, 38);
            this.GioRaTextBox.TabIndex = 22;
            // 
            // ManvTextBox
            // 
            this.ManvTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ManvTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManvTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ManvTextBox.Location = new System.Drawing.Point(408, 59);
            this.ManvTextBox.Name = "ManvTextBox";
            this.ManvTextBox.Size = new System.Drawing.Size(236, 38);
            this.ManvTextBox.TabIndex = 21;
            // 
            // MatKhauTextBox
            // 
            this.MatKhauTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MatKhauTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatKhauTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MatKhauTextBox.Location = new System.Drawing.Point(1442, 59);
            this.MatKhauTextBox.Name = "MatKhauTextBox";
            this.MatKhauTextBox.Size = new System.Drawing.Size(236, 38);
            this.MatKhauTextBox.TabIndex = 19;
            // 
            // MdnTextBox
            // 
            this.MdnTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MdnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MdnTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MdnTextBox.Location = new System.Drawing.Point(70, 59);
            this.MdnTextBox.Name = "MdnTextBox";
            this.MdnTextBox.Size = new System.Drawing.Size(236, 38);
            this.MdnTextBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(754, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Giờ vào";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1437, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1101, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giờ ra";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonPowert);
            this.panel4.Controls.Add(this.ButtonOut);
            this.panel4.Controls.Add(this.buttonReset);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.TimKiemButton);
            this.panel4.Controls.Add(this.XoaButton);
            this.panel4.Controls.Add(this.SuaButton);
            this.panel4.Controls.Add(this.ThemButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel4.Location = new System.Drawing.Point(0, 955);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1754, 95);
            this.panel4.TabIndex = 8;
            // 
            // TimKiemButton
            // 
            this.TimKiemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TimKiemButton.Location = new System.Drawing.Point(1109, 24);
            this.TimKiemButton.Name = "TimKiemButton";
            this.TimKiemButton.Size = new System.Drawing.Size(262, 59);
            this.TimKiemButton.TabIndex = 3;
            this.TimKiemButton.Text = "Tìm kiếm";
            this.TimKiemButton.UseVisualStyleBackColor = true;
            this.TimKiemButton.Click += new System.EventHandler(this.TimKiemButton_Click);
            // 
            // XoaButton
            // 
            this.XoaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.XoaButton.Location = new System.Drawing.Point(787, 24);
            this.XoaButton.Name = "XoaButton";
            this.XoaButton.Size = new System.Drawing.Size(199, 59);
            this.XoaButton.TabIndex = 1;
            this.XoaButton.Text = "Xóa";
            this.XoaButton.UseVisualStyleBackColor = true;
            this.XoaButton.Click += new System.EventHandler(this.XoaButton_Click);
            // 
            // SuaButton
            // 
            this.SuaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SuaButton.Location = new System.Drawing.Point(440, 21);
            this.SuaButton.Name = "SuaButton";
            this.SuaButton.Size = new System.Drawing.Size(207, 61);
            this.SuaButton.TabIndex = 2;
            this.SuaButton.Text = "Sửa";
            this.SuaButton.UseVisualStyleBackColor = true;
            this.SuaButton.Click += new System.EventHandler(this.SuaButton_Click);
            // 
            // ThemButton
            // 
            this.ThemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ThemButton.Location = new System.Drawing.Point(73, 21);
            this.ThemButton.Name = "ThemButton";
            this.ThemButton.Size = new System.Drawing.Size(236, 59);
            this.ThemButton.TabIndex = 0;
            this.ThemButton.Text = "Thêm";
            this.ThemButton.UseVisualStyleBackColor = true;
            this.ThemButton.Click += new System.EventHandler(this.ThemButton_Click);
            // 
            // DangNhapDirdView
            // 
            this.DangNhapDirdView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DangNhapDirdView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DangNhapDirdView.ColumnHeadersHeight = 46;
            this.DangNhapDirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DangNhapDirdView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DangNhapDirdView.Location = new System.Drawing.Point(0, 145);
            this.DangNhapDirdView.Name = "DangNhapDirdView";
            this.DangNhapDirdView.RowHeadersWidth = 82;
            this.DangNhapDirdView.RowTemplate.Height = 33;
            this.DangNhapDirdView.Size = new System.Drawing.Size(1753, 644);
            this.DangNhapDirdView.TabIndex = 9;
            this.DangNhapDirdView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DangNhapDirdView_CellClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::MiniMart.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(92, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::MiniMart.Properties.Resources.fix;
            this.pictureBox2.Location = new System.Drawing.Point(456, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::MiniMart.Properties.Resources.delete;
            this.pictureBox3.Location = new System.Drawing.Point(810, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Image = global::MiniMart.Properties.Resources.search;
            this.pictureBox4.Location = new System.Drawing.Point(1132, 35);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonReset.BackgroundImage = global::MiniMart.Properties.Resources.reset;
            this.buttonReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonReset.Location = new System.Drawing.Point(1445, 24);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 59);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // ButtonOut
            // 
            this.ButtonOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonOut.BackgroundImage = global::MiniMart.Properties.Resources._out;
            this.ButtonOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonOut.Location = new System.Drawing.Point(1545, 24);
            this.ButtonOut.Name = "ButtonOut";
            this.ButtonOut.Size = new System.Drawing.Size(75, 59);
            this.ButtonOut.TabIndex = 9;
            this.ButtonOut.UseVisualStyleBackColor = true;
            this.ButtonOut.Click += new System.EventHandler(this.ButtonOut_Click);
            // 
            // buttonPowert
            // 
            this.buttonPowert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPowert.BackgroundImage = global::MiniMart.Properties.Resources.power;
            this.buttonPowert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPowert.Location = new System.Drawing.Point(1644, 23);
            this.buttonPowert.Name = "buttonPowert";
            this.buttonPowert.Size = new System.Drawing.Size(75, 59);
            this.buttonPowert.TabIndex = 10;
            this.buttonPowert.UseVisualStyleBackColor = true;
            this.buttonPowert.Click += new System.EventHandler(this.buttonPowert_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1754, 1050);
            this.Controls.Add(this.DangNhapDirdView);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TitlePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.Button TimKiemButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonPowert;
        private System.Windows.Forms.Button ButtonOut;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}