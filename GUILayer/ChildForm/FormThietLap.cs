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
    public partial class FormThietLap : Form
    {
        private AccountVM acc;
        private AccountInformationVM accInfo;
        public FormThietLap()
        {
            InitializeComponent();
            Account_BLL acc_bll = new Account_BLL();
            AccountInformation_BLL accInfo_bll = new AccountInformation_BLL();
            acc = acc_bll.GetAccountById(FormLogin.currentAccount_Id);
            accInfo = accInfo_bll.GetAIByAccountId(FormLogin.currentAccount_Id);
            LoadData();

        }
        public void LoadData()
        {
            txtTenTaiKhoan.Text = acc.UserName.ToString();
            txtTen.Text = accInfo.Name.ToString();
            txtCMND.Text = accInfo.IdentityCard.ToString();
            txtDiaChi.Text = accInfo.Address.ToString();
            txtSoDienThoai.Text = accInfo.PhoneNumber.ToString();
            if(accInfo.Gender == true)
            {
                rdbNam.Checked = true;
            }
            else
            {
                rdbNu.Checked = true;
            }
            

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                
                AccountInformation_BLL Accinfo_bll = new AccountInformation_BLL();
                Accinfo_bll.updateAccInfo(new AccountInformationVM
                {
                    Id = accInfo.Id,
                    Name = txtTen.Text,
                    Gender = rdbNam.Checked ? true : false,
                    PhoneNumber = txtSoDienThoai.Text,
                    IdentityCard = txtCMND.Text,
                    Salary = accInfo.Salary,
                    Address = txtDiaChi.Text,
                    
                    Account_Id = accInfo.Account_Id
                });
                MessageBox.Show("Cập nhật thành công thông tin cho bạn! ");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXacNhanDoiMK_Click(object sender, EventArgs e)
        {
            int Id = acc.Id;
            if(txtMKCu.Text.GetMD5() != acc.PassWord)
            {
                MessageBox.Show("Mật khẩu cũ bạn nhập không đúng!");
                txtMKCu.Text = "";
            }
            else if(txtMKMoi.Text != txtXacNhanMK.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu sai!");
            }
            else if (string.IsNullOrWhiteSpace(txtMKMoi.Text))
            {
                MessageBox.Show("Mật khẩu không được là\nkhoảng trắng");
                
            }
            else
            {
                Account_BLL acc_bll = new Account_BLL();
                acc_bll.UpdateMatKhau(Id, txtMKMoi.Text);
                MessageBox.Show("Cập nhật mật khẩu thành công!");
                txtMKMoi.Text = txtXacNhanMK.Text = txtMKCu.Text = "";
            }    
        }

        private void ckbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbShowPass.Checked == true)
            {
                txtMKCu.UseSystemPasswordChar = false;
                txtMKMoi.UseSystemPasswordChar=false;
                txtXacNhanMK.UseSystemPasswordChar=false;
            }
            else
            {
                txtMKCu.UseSystemPasswordChar = true;
                txtMKMoi.UseSystemPasswordChar = true;
                txtXacNhanMK.UseSystemPasswordChar = true;
            }    
        }
    }
}
