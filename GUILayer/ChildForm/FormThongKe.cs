using System;
using BLL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.BLL_DTO;

namespace GUILayer.ChildForm
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
            dgvBill.FormatTable();
            
            LoadData();
            CalculateSales();
        }
        private void LoadData(string CustomerName = "", DateTime? _fromDate = null,
                                DateTime? _toDate = null)
        {
            ThongKeHoaDon tkhd = new ThongKeHoaDon();
            dgvBill.DataSource = null;
            dgvBill.Rows.Clear();
            dgvBill.DataSource = tkhd.GetBillHistory(CustomerName, _fromDate, _toDate);
            dgvBill.Columns["Id"].Visible = false;
        }
        private void CalculateSales()
        {
            double _sale = 0;
            foreach (DataGridViewRow row in dgvBill.Rows)
            {
                _sale += Convert.ToDouble(row.Cells["TongTien"].Value);
            }
            lblTongDoanhTHu.Text = _sale.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {

        }

        private void dgvBill_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnLoc_Click_1(object sender, EventArgs e)
        {
            DateTime? _fromDate = dtpFromDate.Value;
            DateTime? _toDate = dtpToDate.Value;
            LoadData("", _fromDate, _toDate);
            CalculateSales();
        }

        private void dgvBill_DoubleClick_1(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvBill.SelectedRows;
            ChiTietBill f = new ChiTietBill(Convert.ToInt32(r[0].Cells["Id"].Value));
            f.Show();
        }
    }
}
