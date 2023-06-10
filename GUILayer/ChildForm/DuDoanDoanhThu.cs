using BLL;
using BLL.LinearRegression;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUILayer.ChildForm
{
    public partial class DuDoanDoanhThu : Form
    {
        private LinearRegression _lr;
        public DuDoanDoanhThu()
        {
            InitializeComponent();
            _lr = new LinearRegression();
            DuDoanDoanhThu1();
            PhuongTrinhHoiQuy();
            KhachHangTrungBinh();
        }
        private void PhuongTrinhHoiQuy()
        {
            _lr.CalculateCoefficient(out double a, out double b);
            a = Math.Round(a);
            b = Math.Round(b);
            string preOperator = (b < 0) ? "-" : "+";
            if (b < 0) b *= (-1);
            lblPhuongTrinh.Text = $@"Phương trình hồi quy : Doanh Thu = Số Khách * {a} {preOperator} {b}";
        }
        private void DuDoanDoanhThu1()
        {
            chartDuDoan.Series["Doanh thu"].Points.Clear();
            chartDuDoan.Series["Doanh thu"]["PixelPointWidth"] = "40";
            chartDuDoan.Series["Doanh thu"].IsValueShownAsLabel = true;
            chartDuDoan.ChartAreas["ChartDuDoan"].AxisX.Title = "Ngày";
            chartDuDoan.ChartAreas["ChartDuDoan"].AxisY.Title = "VND";

            double[] _predit = _lr.PredictSalePerDayWeek();
            chartDuDoan.Series["Doanh thu"].Points.AddXY("Thứ 2", _predit[1]);
            chartDuDoan.Series["Doanh thu"].Points.AddXY("Thứ 3", _predit[2]);
            chartDuDoan.Series["Doanh thu"].Points.AddXY("Thứ 4", _predit[3]);
            chartDuDoan.Series["Doanh thu"].Points.AddXY("Thứ 5", _predit[4]);
            chartDuDoan.Series["Doanh thu"].Points.AddXY("Thứ 6", _predit[5]);
            chartDuDoan.Series["Doanh thu"].Points.AddXY("Thứ 7", _predit[6]);
            chartDuDoan.Series["Doanh thu"].Points.AddXY("Chủ nhật", _predit[0]);
        }
        private void KhachHangTrungBinh()
        {
            dgvKhachTB.Rows.Clear();
            SortableBindingList<double> list = (new GetData()).GetAverageCustomer().ToSortableBindingList();
            dgvKhachTB.Rows.Add(new string[] { "Thứ 2", list[1].ToString() });
            dgvKhachTB.Rows.Add(new string[] { "Thứ 3", list[2].ToString() });
            dgvKhachTB.Rows.Add(new string[] { "Thứ 4", list[3].ToString() });
            dgvKhachTB.Rows.Add(new string[] { "Thứ 5", list[4].ToString() });
            dgvKhachTB.Rows.Add(new string[] { "Thứ 6", list[5].ToString() });
            dgvKhachTB.Rows.Add(new string[] { "Thứ 7", list[6].ToString() });
            dgvKhachTB.Rows.Add(new string[] { "Chủ nhật", list[0].ToString() });
        }

    }
}
