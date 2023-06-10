using BLL;
using BLL.BLL_DTO;
using BLL.ViewModels;
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
    public partial class ChiTietBill : Form
    {
        private readonly PhieuSuaChuaVM pscvm;
        private readonly List<ChiTietPhieuSCVM>ctpscvm;
        public ChiTietBill(int bill_Id)
        {
            
            InitializeComponent();
            PhieuSuaChua_BLL psc_bll = new PhieuSuaChua_BLL();
            psc_bll.getPSCById(bill_Id, out pscvm, out ctpscvm);
            LoadData();
            LoadLabel();
        }
        public void LoadLabel()
        {
            lblMaHoaDon.Text = pscvm.BillCode.ToString();
            lblNgayLap.Text = pscvm.NgayLapPhieu.ToString();
            lblNgayThanhToan.Text = pscvm.NgayThanhToan.ToString();
            lblTenThuNgan.Text = pscvm.Cashier_Name.ToString();
            lblTenKhachHang.Text = pscvm.Customer_Name.ToString();
            lblSoDienThoai.Text = pscvm.Customer_Phone.ToString();
            lblBienSo.Text = pscvm.BienSoXe.ToString();
            lblDaCoc.Text = String.Format("{0:0,0}", pscvm.TienUng);
            lblTongCong.Text = String.Format("{0:0,0}",pscvm.TongTien);
            lblPhaiTra.Text = String.Format("{0:0,0}",(pscvm.TongTien - pscvm.TienUng));
        }
        public void LoadData()
        {
            dgvMain.FormatTable();
            dgvMain.DataSource = ctpscvm;
            dgvMain.Columns["Id"].Visible = false;
            dgvMain.Columns["Bill_Code"].Visible = false;
            dgvMain.Columns["ID_TienCong"].Visible = false;
            dgvMain.Columns["ID_PhuTung"].Visible = false;
            dgvMain.Columns["isDone"].Visible = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
