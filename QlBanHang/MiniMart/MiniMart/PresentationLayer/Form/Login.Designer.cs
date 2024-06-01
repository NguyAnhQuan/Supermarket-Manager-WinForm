namespace MiniMart
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DangNhaplabel = new System.Windows.Forms.Label();
            this.DangNhapBtn = new System.Windows.Forms.Button();
            this.MatKhauLabel = new System.Windows.Forms.Label();
            this.TaiKhoanLabel = new System.Windows.Forms.Label();
            this.TaiKhoanTxt = new System.Windows.Forms.TextBox();
            this.MatKhauTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MatKhauTxt);
            this.panel1.Controls.Add(this.TaiKhoanTxt);
            this.panel1.Controls.Add(this.MatKhauLabel);
            this.panel1.Controls.Add(this.TaiKhoanLabel);
            this.panel1.Controls.Add(this.DangNhapBtn);
            this.panel1.Location = new System.Drawing.Point(99, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 327);
            this.panel1.TabIndex = 0;
            // 
            // DangNhaplabel
            // 
            this.DangNhaplabel.AutoSize = true;
            this.DangNhaplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DangNhaplabel.Location = new System.Drawing.Point(354, 33);
            this.DangNhaplabel.Name = "DangNhaplabel";
            this.DangNhaplabel.Size = new System.Drawing.Size(248, 51);
            this.DangNhaplabel.TabIndex = 1;
            this.DangNhaplabel.Text = "Đăng Nhập";
            // 
            // DangNhapBtn
            // 
            this.DangNhapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DangNhapBtn.Location = new System.Drawing.Point(349, 253);
            this.DangNhapBtn.Name = "DangNhapBtn";
            this.DangNhapBtn.Size = new System.Drawing.Size(203, 55);
            this.DangNhapBtn.TabIndex = 0;
            this.DangNhapBtn.Text = "Đăng  Nhập";
            this.DangNhapBtn.UseVisualStyleBackColor = true;
            this.DangNhapBtn.Click += new System.EventHandler(this.DangNhapBtn_click);
            // 
            // MatKhauLabel
            // 
            this.MatKhauLabel.AutoSize = true;
            this.MatKhauLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MatKhauLabel.Location = new System.Drawing.Point(55, 161);
            this.MatKhauLabel.Name = "MatKhauLabel";
            this.MatKhauLabel.Size = new System.Drawing.Size(154, 37);
            this.MatKhauLabel.TabIndex = 2;
            this.MatKhauLabel.Text = "Mật Khẩu";
            // 
            // TaiKhoanLabel
            // 
            this.TaiKhoanLabel.AutoSize = true;
            this.TaiKhoanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TaiKhoanLabel.Location = new System.Drawing.Point(55, 61);
            this.TaiKhoanLabel.Name = "TaiKhoanLabel";
            this.TaiKhoanLabel.Size = new System.Drawing.Size(164, 37);
            this.TaiKhoanLabel.TabIndex = 3;
            this.TaiKhoanLabel.Text = "Tài Khoản";
            // 
            // TaiKhoanTxt
            // 
            this.TaiKhoanTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TaiKhoanTxt.Location = new System.Drawing.Point(297, 57);
            this.TaiKhoanTxt.Name = "TaiKhoanTxt";
            this.TaiKhoanTxt.Size = new System.Drawing.Size(306, 44);
            this.TaiKhoanTxt.TabIndex = 4;
            // 
            // MatKhauTxt
            // 
            this.MatKhauTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MatKhauTxt.Location = new System.Drawing.Point(297, 157);
            this.MatKhauTxt.Name = "MatKhauTxt";
            this.MatKhauTxt.Size = new System.Drawing.Size(306, 44);
            this.MatKhauTxt.TabIndex = 5;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 533);
            this.ControlBox = false;
            this.Controls.Add(this.DangNhaplabel);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login System - Minimart";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DangNhapBtn;
        private System.Windows.Forms.Label DangNhaplabel;
        private System.Windows.Forms.TextBox MatKhauTxt;
        private System.Windows.Forms.TextBox TaiKhoanTxt;
        private System.Windows.Forms.Label MatKhauLabel;
        private System.Windows.Forms.Label TaiKhoanLabel;
    }
}

