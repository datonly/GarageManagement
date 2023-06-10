using BLL;
using BLL.BLL_DTO;
using BLL.ViewModels;
using System;
using System.Windows.Forms;

namespace GUILayer.ChildForm
{
    public partial class FormTiepNhanXe : Form
    {
        public FormTiepNhanXe()
        {
            InitializeComponent();
            dgvTiepNhanXe.FormatTable();
            LoadData();
        }
        private void LoadData(string BienSoXe = "")
        {
            KhachHang_BLL kh_bll = new KhachHang_BLL();
            dgvTiepNhanXe.DataSource = kh_bll.getAllKHByBienSo(BienSoXe);
            dgvTiepNhanXe.Columns["Id"].Visible = false;
            dgvTiepNhanXe.Columns["HieuXe_ID"].Visible = false;
            HieuXe_BLL hx_bll = new HieuXe_BLL();

            cbbHieuXe.DataSource = hx_bll.getAllHieuXe();
            cbbHieuXe.DisplayMember = "NameHieuXe";
            cbbHieuXe.ValueMember = "Id";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHangVM khvm = new KhachHangVM()
                {
                    TenChuXe = txtTenKhachHang.Text,
                    BienSoXe = txtBienSo.Text,
                    HieuXe_ID = Convert.ToInt32(cbbHieuXe.SelectedValue),
                    SoDienThoai = txtSoDienThoai.Text,
                    DiaChi = txtDiaChi.Text,
                    Email = txtEmail.Text,

                };
                KhachHang_BLL kh_bll = new KhachHang_BLL();
                kh_bll.themKhachHang(khvm);
                MessageBox.Show("Tiếp nhận thành công xe vào hệ thống!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            KhachHang_BLL kh_bll = new KhachHang_BLL();
            if (dgvTiepNhanXe.SelectedRows.Count == 1)
            {
                int idkh = Convert.ToInt32(dgvTiepNhanXe.SelectedRows[0].Cells["Id"].Value);
                if (kh_bll.checkKhachHang(idkh))
                {
                    MessageBox.Show("Không thể xóa khách hàng vì khách hàng tồn tại hóa đơn chưa thanh toán!");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Xác nhận xoá ?", "Bình tĩnh !", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {

                        kh_bll.deleteKhachHang(idkh);
                        MessageBox.Show("Đã xóa khách hàng vừa chọn!");
                        LoadData();
                    }
                }
            }
            else if (dgvTiepNhanXe.SelectedRows.Count == 1)
            {
                MessageBox.Show("Không được xóa nhiều khách hàng cùng lúc!");
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn tài khoản nào để xóa!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTiepNhanXe.SelectedRows.Count == 1)
            {
                try
                {
                    KhachHangVM khvm = new KhachHangVM()
                    {
                        Id = Convert.ToInt32(dgvTiepNhanXe.SelectedRows[0].Cells["Id"].Value),
                        TenChuXe = txtTenKhachHang.Text,
                        BienSoXe = txtBienSo.Text,
                        HieuXe_ID = Convert.ToInt32(cbbHieuXe.SelectedValue),
                        SoDienThoai = txtSoDienThoai.Text,
                        DiaChi = txtDiaChi.Text,
                        Email = txtEmail.Text,

                    };
                    KhachHang_BLL kh_bll = new KhachHang_BLL();
                    kh_bll.UpdateKhachHang(khvm);
                    MessageBox.Show("Đã sửa thành công thông tin cho khách hàng!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvTiepNhanXe_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvTiepNhanXe.SelectedRows;
            if (r.Count == 1)
            {
                txtTenKhachHang.Text = r[0].Cells["TenChuXe"].Value.ToString();
                txtSoDienThoai.Text = r[0].Cells["SoDienThoai"].Value.ToString();
                txtDiaChi.Text = r[0].Cells["DiaChi"].Value.ToString();
                txtEmail.Text = r[0].Cells["Email"].Value.ToString();
                txtBienSo.Text = r[0].Cells["BienSoXe"].Value.ToString();
                cbbHieuXe.SelectedValue = Convert.ToInt32(r[0].Cells["HieuXe_ID"].Value.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenKhachHang.Text = txtSoDienThoai.Text = txtBienSo.Text = txtDiaChi.Text = txtEmail.Text = "";
        }
    }
}

