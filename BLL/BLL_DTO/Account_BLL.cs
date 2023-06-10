using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAL_DTO;
using AutoMapper;
using BLL.ViewModels;

namespace BLL.BLL_DTO
{
    public class Account_BLL
    {
       
        public int Authentication(string username, string password)
        {
            Account_DAL acc_dal = new Account_DAL();
            string passwordMD5 = password.GetMD5();
            Account account = acc_dal.getAccount(username, passwordMD5);
            if (account == null) return 0;
            return account.Id;
        }
        public AccountVM GetAccountById(int id)
        {
            Account_DAL acc_dal = new Account_DAL();
            Account account = acc_dal.getByID(id);
            return new AccountVM
            {
                Id = account.Id,
                UserName = account.UserName,
                PassWord = account.PassWord,
                Role = account.Role
            };
        }
        public List<AccountVM> GetAllAccounts() 
        {
            Account_DAL acc_dal = new Account_DAL();
            List<AccountVM> data = new List<AccountVM>();
            foreach(Account i in acc_dal.getAllAccounts())
            {
                data.Add(new AccountVM
                {
                    Id = i.Id,
                    UserName = i.UserName,
                    PassWord = i.PassWord,
                    Role = i.Role
                });
            } 
            return data;
        }
        public bool checkExistUsername(string username, int Id)
        {
            Account_DAL acc_dal = new Account_DAL();
            foreach(Account i in acc_dal.getAllAccounts())
            {
                if(i.UserName == username && i.Id != Id) 
                    return false;
            }
            return true;
        }
        public void AddAccount(AccountVM a)
        {
            if (a.Validate().Length != 0)
            {
                throw new Exception(a.Validate());
            }
            else
            {
                if(checkExistUsername(a.UserName, a.Id) == false) 
                {
                    throw new Exception("Tên tài khoản không được trùng!");
                }
                else
                {
                    Account_DAL acc_dal = new Account_DAL();
                    Account data = new Account();
                    data.Id = a.Id;
                    data.UserName = a.UserName;
                    data.PassWord = a.PassWord.GetMD5();
                    data.Role = a.Role;
                    acc_dal.AddAccount(data);
                }    
            }    
        }
        public void UpdateAccount(AccountVM a)
        {
            if (a.Validate().Length != 0)
            {
                throw new Exception(a.Validate());
            }
            else
            {
                if (checkExistUsername(a.UserName, a.Id) == false)
                {
                    throw new Exception("Tên tài khoản không được trùng!");
                }
                else
                {
                    Account_DAL acc_dal = new Account_DAL();
                    Account data = acc_dal.getByID(a.Id);
                    data.UserName = a.UserName;
                    
                    data.Role = a.Role;
                    
                    acc_dal.UpdateAccount(data);
                }
            }    
        }
        public void DeleteAccount(int Id)
        {
            Account_DAL acc_dal = new Account_DAL();
            acc_dal.DeleteAccount(Id);

        }
        public void UpdateMatKhau(int Id, string newpass)
        {
            Account_DAL acc_dal = new Account_DAL();
            acc_dal.updatePass(Id, newpass.GetMD5());
        }

    }
}
