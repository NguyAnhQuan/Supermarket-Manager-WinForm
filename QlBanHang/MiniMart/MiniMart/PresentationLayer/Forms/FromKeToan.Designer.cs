namespace MiniMart.PresentationLayer.Forms
{
    partial class FromKeToan
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.HoTenTextBox = new System.Windows.Forms.TextBox();
            this.MnvTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.KeToanchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TaiChinhcheckBox = new System.Windows.Forms.CheckBox();
            this.ChiCheckBox = new System.Windows.Forms.CheckBox();
            this.ThuCheckBox = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TitlePanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeToanchart)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.TitlePanel.Size = new System.Drawing.Size(1746, 138);
            this.TitlePanel.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.HoTenTextBox);
            this.flowLayoutPanel1.Controls.Add(this.MnvTextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1564, 9);
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
            this.TitleLabel.Location = new System.Drawing.Point(754, 31);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(210, 56);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Kế Toán";
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
            // KeToanchart
            // 
            chartArea2.Name = "ChartArea1";
            this.KeToanchart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.KeToanchart.Legends.Add(legend2);
            this.KeToanchart.Location = new System.Drawing.Point(0, 148);
            this.KeToanchart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.KeToanchart.Name = "KeToanchart";
            this.KeToanchart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "ThongKeThu";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "ThongKeChi";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "ThongKeTaiChinh";
            this.KeToanchart.Series.Add(series4);
            this.KeToanchart.Series.Add(series5);
            this.KeToanchart.Series.Add(series6);
            this.KeToanchart.Size = new System.Drawing.Size(1746, 941);
            this.KeToanchart.TabIndex = 6;
            this.KeToanchart.Text = "chart1";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TaiChinhcheckBox);
            this.panel4.Controls.Add(this.ChiCheckBox);
            this.panel4.Controls.Add(this.ThuCheckBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel4.Location = new System.Drawing.Point(0, 1098);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1746, 138);
            this.panel4.TabIndex = 11;
            // 
            // TaiChinhcheckBox
            // 
            this.TaiChinhcheckBox.AutoSize = true;
            this.TaiChinhcheckBox.Location = new System.Drawing.Point(1352, 50);
            this.TaiChinhcheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TaiChinhcheckBox.Name = "TaiChinhcheckBox";
            this.TaiChinhcheckBox.Size = new System.Drawing.Size(267, 35);
            this.TaiChinhcheckBox.TabIndex = 8;
            this.TaiChinhcheckBox.Text = "Thống kê tài chính";
            this.TaiChinhcheckBox.UseVisualStyleBackColor = true;
            this.TaiChinhcheckBox.CheckedChanged += new System.EventHandler(this.TaiChinhcheckBox_CheckedChanged);
            // 
            // ChiCheckBox
            // 
            this.ChiCheckBox.AutoSize = true;
            this.ChiCheckBox.Location = new System.Drawing.Point(756, 59);
            this.ChiCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChiCheckBox.Name = "ChiCheckBox";
            this.ChiCheckBox.Size = new System.Drawing.Size(201, 35);
            this.ChiCheckBox.TabIndex = 6;
            this.ChiCheckBox.Text = "Thống kê chi";
            this.ChiCheckBox.UseVisualStyleBackColor = true;
            this.ChiCheckBox.CheckedChanged += new System.EventHandler(this.ChiCheckBox_CheckedChanged);
            // 
            // ThuCheckBox
            // 
            this.ThuCheckBox.AutoSize = true;
            this.ThuCheckBox.Location = new System.Drawing.Point(114, 50);
            this.ThuCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ThuCheckBox.Name = "ThuCheckBox";
            this.ThuCheckBox.Size = new System.Drawing.Size(204, 35);
            this.ThuCheckBox.TabIndex = 5;
            this.ThuCheckBox.Text = "Thống kê thu";
            this.ThuCheckBox.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FromKeToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1746, 1236);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.KeToanchart);
            this.Controls.Add(this.TitlePanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FromKeToan";
            this.Text = "FromKeToan";
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeToanchart)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox HoTenTextBox;
        private System.Windows.Forms.TextBox MnvTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart KeToanchart;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox ThuCheckBox;
        private System.Windows.Forms.CheckBox ChiCheckBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox TaiChinhcheckBox;
    }
}