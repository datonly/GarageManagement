namespace GUILayer.ChildForm
{
    partial class ThongKeSoLieu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconDBHoaDon = new FontAwesome.Sharp.IconPictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHoaDonHomNay = new System.Windows.Forms.Label();
            this.lblHoaDonThang = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconDBProduct = new FontAwesome.Sharp.IconPictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblKhachHangHomNay = new System.Windows.Forms.Label();
            this.lblKhachHangThang = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconDBMoney = new FontAwesome.Sharp.IconPictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDoanhThuHomNay = new System.Windows.Forms.Label();
            this.lblDoanhThuThang = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDBHoaDon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDBProduct)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDBMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.iconDBHoaDon);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblHoaDonHomNay);
            this.panel1.Controls.Add(this.lblHoaDonThang);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(13, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 167);
            this.panel1.TabIndex = 7;
            // 
            // iconDBHoaDon
            // 
            this.iconDBHoaDon.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.iconDBHoaDon.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.iconDBHoaDon.IconColor = System.Drawing.Color.White;
            this.iconDBHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDBHoaDon.IconSize = 77;
            this.iconDBHoaDon.Location = new System.Drawing.Point(365, 14);
            this.iconDBHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.iconDBHoaDon.Name = "iconDBHoaDon";
            this.iconDBHoaDon.Size = new System.Drawing.Size(77, 82);
            this.iconDBHoaDon.TabIndex = 3;
            this.iconDBHoaDon.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hôm nay : ";
            // 
            // lblHoaDonHomNay
            // 
            this.lblHoaDonHomNay.AutoSize = true;
            this.lblHoaDonHomNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDonHomNay.ForeColor = System.Drawing.Color.White;
            this.lblHoaDonHomNay.Location = new System.Drawing.Point(185, 112);
            this.lblHoaDonHomNay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoaDonHomNay.Name = "lblHoaDonHomNay";
            this.lblHoaDonHomNay.Size = new System.Drawing.Size(56, 25);
            this.lblHoaDonHomNay.TabIndex = 2;
            this.lblHoaDonHomNay.Text = "9999";
            // 
            // lblHoaDonThang
            // 
            this.lblHoaDonThang.AutoSize = true;
            this.lblHoaDonThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDonThang.ForeColor = System.Drawing.Color.White;
            this.lblHoaDonThang.Location = new System.Drawing.Point(19, 54);
            this.lblHoaDonThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoaDonThang.Name = "lblHoaDonThang";
            this.lblHoaDonThang.Size = new System.Drawing.Size(206, 42);
            this.lblHoaDonThang.TabIndex = 1;
            this.lblHoaDonThang.Text = "10.000.000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hóa đơn (tháng)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkMagenta;
            this.panel2.Controls.Add(this.iconDBProduct);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblKhachHangHomNay);
            this.panel2.Controls.Add(this.lblKhachHangThang);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(467, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 167);
            this.panel2.TabIndex = 8;
            // 
            // iconDBProduct
            // 
            this.iconDBProduct.BackColor = System.Drawing.Color.DarkMagenta;
            this.iconDBProduct.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.iconDBProduct.IconColor = System.Drawing.Color.White;
            this.iconDBProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDBProduct.IconSize = 103;
            this.iconDBProduct.Location = new System.Drawing.Point(331, 1);
            this.iconDBProduct.Margin = new System.Windows.Forms.Padding(4);
            this.iconDBProduct.Name = "iconDBProduct";
            this.iconDBProduct.Size = new System.Drawing.Size(103, 106);
            this.iconDBProduct.TabIndex = 3;
            this.iconDBProduct.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(21, 113);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Hôm nay : ";
            // 
            // lblKhachHangHomNay
            // 
            this.lblKhachHangHomNay.AutoSize = true;
            this.lblKhachHangHomNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHangHomNay.ForeColor = System.Drawing.Color.White;
            this.lblKhachHangHomNay.Location = new System.Drawing.Point(183, 113);
            this.lblKhachHangHomNay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKhachHangHomNay.Name = "lblKhachHangHomNay";
            this.lblKhachHangHomNay.Size = new System.Drawing.Size(56, 25);
            this.lblKhachHangHomNay.TabIndex = 2;
            this.lblKhachHangHomNay.Text = "9999";
            // 
            // lblKhachHangThang
            // 
            this.lblKhachHangThang.AutoSize = true;
            this.lblKhachHangThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHangThang.ForeColor = System.Drawing.Color.White;
            this.lblKhachHangThang.Location = new System.Drawing.Point(15, 54);
            this.lblKhachHangThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKhachHangThang.Name = "lblKhachHangThang";
            this.lblKhachHangThang.Size = new System.Drawing.Size(206, 42);
            this.lblKhachHangThang.TabIndex = 1;
            this.lblKhachHangThang.Text = "10.000.000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Khách hàng (tháng)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Controls.Add(this.iconDBMoney);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lblDoanhThuHomNay);
            this.panel3.Controls.Add(this.lblDoanhThuThang);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(913, 27);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(481, 167);
            this.panel3.TabIndex = 9;
            // 
            // iconDBMoney
            // 
            this.iconDBMoney.BackColor = System.Drawing.Color.Crimson;
            this.iconDBMoney.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.iconDBMoney.IconColor = System.Drawing.Color.White;
            this.iconDBMoney.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDBMoney.IconSize = 93;
            this.iconDBMoney.Location = new System.Drawing.Point(380, 4);
            this.iconDBMoney.Margin = new System.Windows.Forms.Padding(4);
            this.iconDBMoney.Name = "iconDBMoney";
            this.iconDBMoney.Size = new System.Drawing.Size(93, 103);
            this.iconDBMoney.TabIndex = 3;
            this.iconDBMoney.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Hôm nay : ";
            // 
            // lblDoanhThuHomNay
            // 
            this.lblDoanhThuHomNay.AutoSize = true;
            this.lblDoanhThuHomNay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThuHomNay.ForeColor = System.Drawing.Color.White;
            this.lblDoanhThuHomNay.Location = new System.Drawing.Point(180, 112);
            this.lblDoanhThuHomNay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoanhThuHomNay.Name = "lblDoanhThuHomNay";
            this.lblDoanhThuHomNay.Size = new System.Drawing.Size(56, 25);
            this.lblDoanhThuHomNay.TabIndex = 2;
            this.lblDoanhThuHomNay.Text = "9999";
            // 
            // lblDoanhThuThang
            // 
            this.lblDoanhThuThang.AutoSize = true;
            this.lblDoanhThuThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThuThang.ForeColor = System.Drawing.Color.White;
            this.lblDoanhThuThang.Location = new System.Drawing.Point(15, 54);
            this.lblDoanhThuThang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoanhThuThang.Name = "lblDoanhThuThang";
            this.lblDoanhThuThang.Size = new System.Drawing.Size(206, 42);
            this.lblDoanhThuThang.TabIndex = 1;
            this.lblDoanhThuThang.Text = "10.000.000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Doanh thu (tháng)";
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartDoanhThu";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(12, 230);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartDoanhThu";
            series1.Legend = "Legend1";
            series1.Name = "Doanh thu";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Size = new System.Drawing.Size(1375, 485);
            this.chartDoanhThu.TabIndex = 10;
            this.chartDoanhThu.Text = "Doanh thu";
            // 
            // ThongKeSoLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 661);
            this.Controls.Add(this.chartDoanhThu);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ThongKeSoLieu";
            this.Text = "Thống kê số liệu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDBHoaDon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDBProduct)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDBMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconDBHoaDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHoaDonHomNay;
        private System.Windows.Forms.Label lblHoaDonThang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconDBProduct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblKhachHangHomNay;
        private System.Windows.Forms.Label lblKhachHangThang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconDBMoney;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDoanhThuHomNay;
        private System.Windows.Forms.Label lblDoanhThuThang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
    }
}