namespace WindowsFormsClass
{
    partial class Form1
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
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.textdel = new System.Windows.Forms.TextBox();
            this.textC = new System.Windows.Forms.TextBox();
            this.textB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtX2);
            this.panel1.Controls.Add(this.txtX1);
            this.panel1.Controls.Add(this.textdel);
            this.panel1.Controls.Add(this.textC);
            this.panel1.Controls.Add(this.textB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtA);
            this.panel1.Controls.Add(this.a);
            this.panel1.Location = new System.Drawing.Point(56, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 258);
            this.panel1.TabIndex = 1;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(725, 172);
            this.txtX2.Name = "txtX2";
            this.txtX2.ReadOnly = true;
            this.txtX2.Size = new System.Drawing.Size(100, 31);
            this.txtX2.TabIndex = 11;
            this.txtX2.Tag = "txtX2";
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(725, 115);
            this.txtX1.Name = "txtX1";
            this.txtX1.ReadOnly = true;
            this.txtX1.Size = new System.Drawing.Size(100, 31);
            this.txtX1.TabIndex = 10;
            this.txtX1.Tag = "txtX1";
            // 
            // textdel
            // 
            this.textdel.Location = new System.Drawing.Point(725, 55);
            this.textdel.Name = "textdel";
            this.textdel.ReadOnly = true;
            this.textdel.Size = new System.Drawing.Size(100, 31);
            this.textdel.TabIndex = 9;
            this.textdel.Tag = "txtDel";
            // 
            // textC
            // 
            this.textC.Location = new System.Drawing.Point(276, 172);
            this.textC.Name = "textC";
            this.textC.Size = new System.Drawing.Size(100, 31);
            this.textC.TabIndex = 8;
            this.textC.Tag = "txtC";
            this.textC.Enter += new System.EventHandler(this.textboxC_enter);
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(276, 115);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(100, 31);
            this.textB.TabIndex = 7;
            this.textB.Tag = "txtB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(595, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 25);
            this.label6.TabIndex = 6;
            this.label6.Tag = "x2Label";
            this.label6.Text = "x2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(595, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 25);
            this.label5.TabIndex = 5;
            this.label5.Tag = "x1Label";
            this.label5.Text = "x1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(595, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 25);
            this.label4.TabIndex = 4;
            this.label4.Tag = "delLabel";
            this.label4.Text = "del";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 3;
            this.label3.Tag = "bLabel";
            this.label3.Text = "b";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 2;
            this.label2.Tag = "cLabel";
            this.label2.Text = "c";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(276, 55);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 31);
            this.txtA.TabIndex = 1;
            this.txtA.Tag = "txtA";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(197, 55);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(24, 25);
            this.a.TabIndex = 0;
            this.a.Tag = "aLabel";
            this.a.Text = "a";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 2;
            this.button1.Tag = "BtnGiai";
            this.button1.Text = "Giải";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnGiai_click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(56, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 100);
            this.panel2.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(725, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 32);
            this.button3.TabIndex = 4;
            this.button3.Tag = "BtnThoat";
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnThoat_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 32);
            this.button2.TabIndex = 3;
            this.button2.Tag = "BtnXoa";
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnXoa_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox textdel;
        private System.Windows.Forms.TextBox textC;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

