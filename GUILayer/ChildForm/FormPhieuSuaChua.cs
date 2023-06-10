using BLL;
using BLL.BLL_DTO;
using BLL.ViewModels;
using GUILayer.ChildForm.SubForm;
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
    public partial class FormPhieuSuaChua : Form
    {
        private int currentCashier_Id;
        public FormPhieuSuaChua()
        {
            InitializeComponent();
            LoadData();
            currentCashier_Id = (new AccountInformation_BLL()).GetAIByAccountId(FormLogin.currentAccount_Id).Id;
            txtTenNhanVien.Text = (new AccountInformation_BLL()).GetAIByAccountId(FormLogin.currentAccount_Id).Name;
            printDocument1.DefaultPageSettings.Landscape = true;
        }
        public void LoadData(string bienso = "")
        {
            PhieuSuaChua_BLL psc_bll = new PhieuSuaChua_BLL();
            txtNgayTao.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            dgvHoaDon.DataSource = psc_bll.getPSCbyBS(bienso);
            dgvHoaDon.Columns["Id"].Visible = false;
            dgvHoaDon.Columns["NgayThanhToan"].Visible = false;
            dgvHoaDon.Columns["Customer_Phone"].Visible = false;
            
            dgvHoaDon.FormatTable();
        }

        private void btnTaoChiTiet_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvHoaDon.SelectedRows;
            if (r.Count == 1)
            {
                int Bill_Id = Convert.ToInt32(r[0].Cells["Id"].Value);
                string Bill_Code = r[0].Cells["BillCode"].Value.ToString();
                FormCT_PSC f = new FormCT_PSC(Bill_Id, Bill_Code);
                f.ShowDialog();
                SetBillTotal();
                LoadData();
            }
            else
            {
                MessageBox.Show("Chưa chọn hoá đơn");
            }
        }

        private void iconDice_Click(object sender, EventArgs e)
        {
            StringBuilder code = new StringBuilder();
            Random rd = new Random();
            string tmp1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string tmp2 = "0123456789";
            for (int i = 0; i < 3; i++)
            {
                code.Append(tmp1[rd.Next(0, 25)]);
            }
            for (int i = 0; i < 3; i++)
            {
                code.Append(tmp2[rd.Next(0, 9)]);
            }
            txtMaHD.Text = code.ToString();
        }

        private void btnCheckBS_Click(object sender, EventArgs e)
        {
            txtTienUng.Text = txtTongTien.Text = txtPhaiTra.Text = "";
            txtNgayTao.Text = DateTime.Now.ToString();
            KhachHang_BLL kh_bll = new KhachHang_BLL();
            KhachHangVM a = kh_bll.getKHbyBienSo(txtBienSo.Text);
            if(a != null)
            {
                txtTenKH.Text = a.TenChuXe;
                txtSDT.Text = a.SoDienThoai;
                btnThem.Enabled = true;
                txtMaKH.Text = a.Id.ToString();
                txtMaKH.Visible = false;
            }
            else
            {
                MessageBox.Show("Biển số xe chưa được tiếp nhận vào hệ thống!");
                txtTenKH.Text = "";
                txtSDT.Text = "";
                btnThem.Enabled = false;
            }    
        }

        private void txtBienSo_TextChanged(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
        }
        private void SetBillTotal()
        {
            DataGridViewSelectedRowCollection r = dgvHoaDon.SelectedRows;
            PhieuSuaChua_BLL psc_bll = new PhieuSuaChua_BLL();
            psc_bll.setBillTotal(Convert.ToInt32(r[0].Cells["Id"].Value));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                PhieuSuaChua_BLL psc_bll = new PhieuSuaChua_BLL();
                psc_bll.addPSC(new PhieuSuaChuaVM()
                {
                    BillCode = txtMaHD.Text,
                    Customer_ID = Convert.ToInt32(txtMaKH.Text),
                    Account_ID = currentCashier_Id,
                    NgayLapPhieu = DateTime.Now,
                    NgayThanhToan = null,
                    TongTien = 0,

                });
                MessageBox.Show("Tạo hóa đơn thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvHoaDon.SelectedRows;
            if (r.Count == 1)
            {
                txtMaHD.Text = r[0].Cells["BillCode"].Value.ToString();
                txtNgayTao.Text = r[0].Cells["NgayLapPhieu"].Value.ToString();
                txtTenNhanVien.Text = r[0].Cells["Cashier_Name"].Value.ToString();
                txtTenKH.Text = r[0].Cells["Customer_Name"].Value.ToString();
                txtSDT.Text = r[0].Cells["Customer_Phone"].Value.ToString();
                txtBienSo.Text = r[0].Cells["BienSoXe"].Value.ToString();

                double TienCoc = Convert.ToDouble(r[0].Cells["TienUng"].Value);
                double TongTien = Convert.ToDouble(r[0].Cells["TongTien"].Value);
                txtTienUng.Text = TienCoc.ToString();
                txtTongTien.Text = TongTien.ToString();
                txtPhaiTra.Text = (TongTien - TienCoc).ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNgayTao.Text = txtMaHD.Text =txtTenKH.Text= txtTenNhanVien.Text = txtTongTien.Text
                = txtBienSo.Text = txtSDT.Text = txtTienUng.Text = txtPhaiTra.Text = "";
            txtTenNhanVien.Text = (new AccountInformation_BLL()).GetAIByAccountId(FormLogin.currentAccount_Id).Name;
            btnThem.Enabled = false;
            txtNgayTao.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }
        private int _Bill_Id;
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            PhieuSuaChua_BLL psc_bll = new PhieuSuaChua_BLL();
            if (dgvHoaDon.SelectedRows.Count == 1)
            {
                _Bill_Id = Convert.ToInt32(dgvHoaDon.SelectedRows[0].Cells["Id"].Value);
                if(psc_bll.checkHoanThanh(_Bill_Id))
                {
                    MessageBox.Show("Vui lòng kiểm tra lại các nội dung chưa hoàn thành!", "Chú ý");
                }    
                else
                {
                    ThanhToan();
                }    

            }  
            else
            {
                MessageBox.Show("Chưa có hóa đơn nào được chọn!");
            }    

        }
        private void ThanhToan()
        {
            if (MessageBox.Show("In hoá đơn không ?", "Cân nhắc !",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                PrintBill();
            }
            PhieuSuaChua_BLL psc_bll = new PhieuSuaChua_BLL();
            psc_bll.PurchaseBill(_Bill_Id);
            MessageBox.Show("Thanh toán thành công", "Thành công");
            LoadData();
        }
        private void PrintBill()
        {
            try
            {
                printDialog1.Document = printDocument1;
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            catch
            {
                MessageBox.Show("Không in được!", "Thông báo!");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PhieuSuaChua_BLL psc_bll = new PhieuSuaChua_BLL();
            string content = psc_bll.GetContentPrintBill(_Bill_Id);
            e.Graphics.DrawString(content, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 100, 100);
            MessageBox.Show("In hoá đơn thành công", "Thành công");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvHoaDon.SelectedRows;
            if (r.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận xoá ?", "Bình tĩnh !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in r)
                    {
                        PhieuSuaChua_BLL psc_bll = new PhieuSuaChua_BLL();
                        psc_bll.deleteHoaDon(Convert.ToInt32(row.Cells["Id"].Value));
                    }
                    MessageBox.Show("Xóa thành công các hóa đơn bạn chọn!");
                }
            }
            LoadData();
        }
    }
}
