namespace GUILayer.ChildForm
{
    partial class DuDoanDoanhThu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartDuDoan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblPhuongTrinh = new System.Windows.Forms.Label();
            this.dgvKhachTB = new System.Windows.Forms.DataGridView();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chartDuDoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachTB)).BeginInit();
            this.SuspendLayout();
            // 
            // chartDuDoan
            // 
            chartArea4.Name = "ChartDuDoan";
            this.chartDuDoan.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartDuDoan.Legends.Add(legend4);
            this.chartDuDoan.Location = new System.Drawing.Point(12, 12);
            this.chartDuDoan.Name = "chartDuDoan";
            series4.ChartArea = "ChartDuDoan";
            series4.Legend = "Legend1";
            series4.Name = "Doanh thu";
            this.chartDuDoan.Series.Add(series4);
            this.chartDuDoan.Size = new System.Drawing.Size(1032, 620);
            this.chartDuDoan.TabIndex = 0;
            this.chartDuDoan.Text = "Doanh thu";
            // 
            // lblPhuongTrinh
            // 
            this.lblPhuongTrinh.AutoSize = true;
            this.lblPhuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhuongTrinh.Location = new System.Drawing.Point(83, 663);
            this.lblPhuongTrinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhuongTrinh.Name = "lblPhuongTrinh";
            this.lblPhuongTrinh.Size = new System.Drawing.Size(60, 33);
            this.lblPhuongTrinh.TabIndex = 17;
            this.lblPhuongTrinh.Text = "xxx";
            // 
            // dgvKhachTB
            // 
            this.dgvKhachTB.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachTB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ngay,
            this.SoKhach});
            this.dgvKhachTB.Location = new System.Drawing.Point(1075, 189);
            this.dgvKhachTB.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKhachTB.Name = "dgvKhachTB";
            this.dgvKhachTB.RowHeadersVisible = false;
            this.dgvKhachTB.RowHeadersWidth = 51;
            this.dgvKhachTB.Size = new System.Drawing.Size(300, 317);
            this.dgvKhachTB.TabIndex = 18;
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            this.Ngay.Width = 125;
            // 
            // SoKhach
            // 
            this.SoKhach.HeaderText = "Số khách trung bình";
            this.SoKhach.MinimumWidth = 6;
            this.SoKhach.Name = "SoKhach";
            this.SoKhach.Width = 125;
            // 
            // DuDoanDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 741);
            this.Controls.Add(this.dgvKhachTB);
            this.Controls.Add(this.lblPhuongTrinh);
            this.Controls.Add(this.chartDuDoan);
            this.Name = "DuDoanDoanhThu";
            this.Text = "Dự đoán doanh thu";
            ((System.ComponentModel.ISupportInitialize)(this.chartDuDoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDuDoan;
        private System.Windows.Forms.Label lblPhuongTrinh;
        private System.Windows.Forms.DataGridView dgvKhachTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoKhach;
    }
}