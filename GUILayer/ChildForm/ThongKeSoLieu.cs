using BLL.BLL_DTO;
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
    public partial class ThongKeSoLieu : Form
    {
        public ThongKeSoLieu()
        {
            InitializeComponent();
            ThongKeThangVaHomNay();
            DoanhThuTungThang();
        }
        private void ThongKeThangVaHomNay()
        {
            ThongKeHoaDon _db = new ThongKeHoaDon();
            _db.StatisticMonthAndToday(out int _billMonth, out int _billToday,
                                       out int _cusMonth, out int _cusToday,
                                       out double _saleMonth, out double _saleToday);
            lblHoaDonThang.Text = _billMonth.ToString();
            lblHoaDonHomNay.Text = _billToday.ToString();
            lblKhachHangThang.Text = _cusMonth.ToString();
            lblKhachHangHomNay.Text = _cusToday.ToString();
            lblDoanhThuThang.Text = _saleMonth.ToString();
            lblDoanhThuHomNay.Text = _saleToday.ToString();
        }
        private void DoanhThuTungThang()
        {
            ThongKeHoaDon _db = new ThongKeHoaDon();
            chartDoanhThu.Series["Doanh thu"].Points.Clear();
            chartDoanhThu.Series["Doanh thu"]["PixelPointWidth"] = "20";
            chartDoanhThu.Series["Doanh thu"].IsValueShownAsLabel = true;
            chartDoanhThu.ChartAreas["ChartDoanhThu"].AxisX.Title = "Tháng";
            chartDoanhThu.ChartAreas["ChartDoanhThu"].AxisY.Title = "VND";

            _db.StatisticSalePerMonth(out double[] _doanhThuThang);
            for (int i = 1; i <= 12; i++)
            {
                chartDoanhThu.Series["Doanh thu"].Points.AddXY(i, _doanhThuThang[i]);
            }
        }
    }
}
