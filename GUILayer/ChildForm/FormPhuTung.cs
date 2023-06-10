using BLL;
using BLL.BLL_DTO;
using BLL.ViewModels;
using System;
using System.Windows.Forms;

namespace GUILayer.ChildForm
{
    public partial class FormPhuTung : Form
    {
        public FormPhuTung()
        {
            InitializeComponent();
            dgvPhuTung.FormatTable();
            LoadData();
        }
        public void LoadData(string name = "")
        {
            PhuTung_BLL pt_bll = new PhuTung_BLL();
            dgvPhuTung.DataSource = pt_bll.getPhuTungByName(name);
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtTenPT.Clear();
            txtDonVi.Clear();
            txtDonGia.Clear();

            txtTenPT.Enabled = true;
            txtDonGia.Enabled = true;
            txtDonVi.Enabled = true;

            txtSoLuong.Text = "0";
            btnThayDoi.Enabled = false;
            btnXoa.Enabled = false;
            btnThemSL.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtSoLuong.Text) < 0)
            {
                MessageBox.Show("Số lượng nhập vào không được âm", "Thông báo", MessageBoxButtons.OK);

            }
            try
            {
                PhuTungVM phuTung = new PhuTungVM();
                phuTung.NameVTPT = txtTenPT.Text;
                phuTung.DonVi = txtDonVi.Text;
                phuTung.GiaBan = Convert.ToDouble(txtDonGia.Text);
                phuTung.SoLuong = Convert.ToDouble(txtSoLuong.Text);

                PhuTung_BLL pt_bll = new PhuTung_BLL();
                pt_bll.addPhuTung(phuTung);
                MessageBox.Show("Thêm phụ tùng thành công!", "Thông báo", MessageBoxButtons.OK);
                LoadData();

                txtSoLuong.Text = "0";
                txtTenPT.Clear();
                txtDonGia.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void dgvPhuTung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {

                    txtTenPT.Text = dgvPhuTung.Rows[e.RowIndex].Cells["NameVTPT"].Value.ToString();
                    txtSoLuong.Text = dgvPhuTung.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
                    txtDonGia.Text = String.Format("{0:0,0}", decimal.Parse(dgvPhuTung.Rows[e.RowIndex].Cells["GiaBan"].Value.ToString()));
                    txtDonVi.Text = dgvPhuTung.Rows[e.RowIndex].Cells["DonVi"].Value.ToString();
                    txtTenPT.Enabled = true;
                    txtDonGia.Enabled = true;
                    txtDonVi.Enabled = true;
                    btnThemSL.Enabled = true;
                    btnThayDoi.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnThemSL_Click(object sender, EventArgs e)
        {
            double soluong = Convert.ToDouble(txtSoLuong.Text);
            MuaPhuTung form = new MuaPhuTung(txtSoLuong);
            form.ShowDialog();
            if (btnThayDoi.Enabled)
            {

                int Id = Convert.ToInt32(dgvPhuTung.SelectedRows[0].Cells["Id"].Value);

                double SoLuong = Convert.ToDouble(txtSoLuong.Text);
                PhuTung_BLL pt_bll = new PhuTung_BLL();
                pt_bll.UpdateSoLuong(Id, SoLuong);
                LoadData();
            }
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            try
            {
                PhuTung_BLL pt_bll = new PhuTung_BLL();
                pt_bll.UpdatePhuTung(new PhuTungVM()
                {
                    Id = Convert.ToInt32(dgvPhuTung.SelectedRows[0].Cells["Id"].Value),
                    NameVTPT = txtTenPT.Text,
                    DonVi = txtDonVi.Text,
                    GiaBan = Convert.ToDouble(txtDonGia.Text),
                    SoLuong = Convert.ToDouble(txtSoLuong.Text)

                });
                LoadData();
                MessageBox.Show("Đã cập nhật thông tin cho phụ tùng!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhuTung.SelectedRows.Count == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận xoá ?", "Bình tĩnh !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    PhuTung_BLL pt_bll = new PhuTung_BLL();

                    pt_bll.deletePhuTung(Convert.ToInt32(dgvPhuTung.SelectedRows[0].Cells["Id"].Value));
                    
                    MessageBox.Show("Đã xóa phụ tùng vừa chọn!");
                    LoadData();
                }
            }
            else if (dgvPhuTung.SelectedRows.Count > 1)
            {
                MessageBox.Show("Không thể xóa nhiều phụ tùng 1 lúc!");
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn phụ tùng nào để xóa!");
            }
        }
    }
}
