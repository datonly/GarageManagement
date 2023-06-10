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
    public partial class FormDSNV : Form
    {
        public FormDSNV()
        {
            InitializeComponent();
            LoadData();
            dgvDSNV.FormatTable();
        }
        private void LoadData(string Name = "")
        {
            AccountInformation_BLL accInfo = new AccountInformation_BLL();
            dgvDSNV.DataSource = accInfo.getAccInfobyName(Name);
            dgvDSNV.Columns["Id"].Visible = false;
            Account_BLL acc_bll = new Account_BLL();
            cbbTaiKhoan.DataSource = acc_bll.GetAllAccounts();
            cbbTaiKhoan.ValueMember = "Id";
            cbbTaiKhoan.DisplayMember = "UserName";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                AccountInformation_BLL Accinfo_bll = new AccountInformation_BLL();
                Accinfo_bll.addAccInfo(new AccountInformationVM
                {
                    Name = txtTenNhanVien.Text,
                    Gender = rdbNam.Checked ? true : false,
                    PhoneNumber = txtSoDienThoai.Text,
                    IdentityCard = txtCMND.Text,
                    Salary = float.Parse(txtLuong.Text),
                    Address = txtDiaChi.Text,
                    Account_Name = cbbTaiKhoan.Text,
                    Account_Id = Convert.ToInt32(cbbTaiKhoan.SelectedValue)
                });
                MessageBox.Show("Thêm thông tin thành công cho tài khoản! ");
                LoadData();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDSNV_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvDSNV.SelectedRows;
            if(r.Count == 1)
            {
                txtTenNhanVien.Text = r[0].Cells["Name"].Value.ToString();
                txtCMND.Text = r[0].Cells["IdentityCard"].Value.ToString();
                txtLuong.Text = r[0].Cells["Salary"].Value.ToString();
                if (Convert.ToBoolean(r[0].Cells["Gender"].Value))
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;
                txtDiaChi.Text = r[0].Cells["Address"].Value.ToString();
                txtSoDienThoai.Text = r[0].Cells["PhoneNumber"].Value.ToString();
                cbbTaiKhoan.Text = r[0].Cells["Account_Name"].Value.ToString();
            }    

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dgvDSNV.SelectedRows;
            if (r.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Xác nhận xoá ?", "Bình tĩnh !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in r)
                    {
                        AccountInformation_BLL Accinfo_bll = new AccountInformation_BLL();
                        Accinfo_bll.deleteAccountInfo(Convert.ToInt32(row.Cells["Id"].Value));
                    }
                    MessageBox.Show("Xóa thành công thông tin cho nhân viên này!");
                }
            }
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewSelectedRowCollection r = dgvDSNV.SelectedRows;
                AccountInformation_BLL Accinfo_bll = new AccountInformation_BLL();
                Accinfo_bll.updateAccInfo(new AccountInformationVM
                {
                    Id = Convert.ToInt32(r[0].Cells["Id"].Value),
                    Name = txtTenNhanVien.Text,
                    Gender = rdbNam.Checked ? true : false,
                    PhoneNumber = txtSoDienThoai.Text,
                    IdentityCard = txtCMND.Text,
                    Salary = float.Parse(txtLuong.Text),
                    Address = txtDiaChi.Text,
                    Account_Name = cbbTaiKhoan.Text,
                    Account_Id = Convert.ToInt32(cbbTaiKhoan.SelectedValue)
                });
                MessageBox.Show("Sửa thông tin thành công cho tài khoản! ");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenNhanVien.Text = cbbTaiKhoan.Text =
               txtSoDienThoai.Text = txtLuong.Text = txtDiaChi.Text = txtCMND.Text = "";
            
        }
    }
}
