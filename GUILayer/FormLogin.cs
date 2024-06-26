﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.BLL_DTO;
using BLL.ViewModels;

namespace GUILayer
{
    public partial class FormLogin : Form
    {
        private Account_BLL _db;
        private AccountInformation_BLL _dbAI;
        public static int currentAccount_Id;
        private readonly Task _loadDB;
        public FormLogin()
        {
            _loadDB = new Task(() =>
            {
                _db = new Account_BLL();
                _dbAI = new AccountInformation_BLL();
                
            });
            _loadDB.Start();
            InitializeComponent();
            if (txtPass.Text == "Mật khẩu") txtPass.UseSystemPasswordChar = false;
            btnHidePass.Hide();
        }

        private void CheckLogin()
        {
            string un = txtUser.Text;
            string pw = txtPass.Text;
            if (!string.IsNullOrWhiteSpace(un) && !string.IsNullOrWhiteSpace(pw))
            {
                currentAccount_Id = _db.Authentication(un, pw);
                if (currentAccount_Id > 0)
                {
                    AccountVM currentAcc = _db.GetAccountById(currentAccount_Id);
                    AccountInformationVM currentAccIfo = _dbAI.GetAIByAccountId(currentAccount_Id);
                    string Name = currentAccIfo != null ? currentAccIfo.Name : "";
                    if (currentAcc.Role == "Admin")
                    {
                        MessageBox.Show($"Chào mừng Quản lý {Name}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show($"Chào mừng Thu Ngân {Name}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormControl fc = new FormControl();
                    this.Hide();
                    fc.ShowDialog();
                    this.Show();
                    txtUser.Text = "Tài khoản";
                    txtPass.Text = "Mật khẩu";
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tài khoản và mật khẩu không được trống !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                
                _loadDB.Wait(5000);
                CheckLogin();
            }
            catch
            {
                MessageBox.Show("Gặp lỗi Database!");
                btnLogin.Focus();
            }
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
            btnHidePass.Hide();
            btnShowPass.Show();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
            btnShowPass.Hide();
            btnHidePass.Show();
        }

        

        private void txtpass_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
        }

        private void lbmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void txtUser_Click_1(object sender, EventArgs e)
        {
            txtUser.Clear();
        }
    }
}
