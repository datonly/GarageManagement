using BLL;
using BLL.BLL_DTO;
using BLL.ViewModels;
using System;
using System.Windows.Forms;

namespace GUILayer.ChildForm
{
    public partial class FormTaiKhoan : Form
    {
        public FormTaiKhoan()
        {
            InitializeComponent();
            dgvDSTK.FormatTable();
            LoadData();
        }
        public void LoadData(string tentaikhoan = "")
        {
            Account_BLL acc_bll = new Account_BLL();
            dgvDSTK.DataSource = acc_bll.GetAllAccounts();
            dgvDSTK.Columns["Id"].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            grbThem.Visible = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                Account_BLL acc_bll = new Account_BLL();
                acc_bll.AddAccount(new AccountVM
                {
                    UserName = txtTenTaiKhoan.Text,
                    PassWord = txtMatKhau.Text,
                    Role = cbbVaiTro.Text
                });
                grbThem.Visible = false;
                MessageBox.Show("Thêm tài khoản thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                grbThem.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grbThem.Visible = false;
        }

        private void dgvDSTK_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvDSTK.SelectedRows;
            if (r.Count == 1)
            {
                txtTenTaiKhoan.Text = r[0].Cells["UserName"].Value.ToString();
                cbbVaiTro.Text = r[0].Cells["Role"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSTK.SelectedRows.Count == 1)
            {
                try
                {

                    Account_BLL acc_bll = new Account_BLL();
                    AccountVM data = new AccountVM()
                    {
                        Id = Convert.ToInt32(dgvDSTK.SelectedRows[0].Cells["Id"].Value),
                        UserName = txtTenTaiKhoan.Text,
                        Role = cbbVaiTro.Text
                    };
                    acc_bll.UpdateAccount(data);
                    MessageBox.Show("Sửa tài khoản thành công!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Không thể sửa 2 tài khoản cùng 1 lúc!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvDSTK.SelectedRows.Count >= 1)
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận xoá ?", "Bình tĩnh !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Account_BLL acc_bll = new Account_BLL();
                    foreach (DataGridViewRow row in dgvDSTK.SelectedRows)
                    {
                        acc_bll.DeleteAccount(Convert.ToInt32(row.Cells["Id"].Value));
                    }
                    MessageBox.Show("Đã xóa các tài khoản vừa chọn!");
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn tài khoản nào để xóa!");
            }    
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Text = cbbVaiTro.Text = "";
        }
    }
}
