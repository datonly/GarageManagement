using BLL.ViewModels;
using DAL.DAL_DTO;
using DAL.Models;
using System;
using System.Collections.Generic;

namespace BLL.BLL_DTO
{
    public class AccountInformation_BLL
    {
        #region All User
        public AccountInformationVM GetAIByAccountId(int Account_Id)
        {
            AccountInformation_DAL AIdal = new AccountInformation_DAL();
            AccountInformation ai = AIdal.GetAIByAccountId(Account_Id);
            if (ai == null) return null;
            return new AccountInformationVM
            {
                Id = ai.Id,
                Name = ai.Name,
                Gender = ai.Gender,
                PhoneNumber = ai.PhoneNumber,
                Salary = ai.Salary,
                Account_Id = ai.Account_Id,
                Address = ai.Address,
                IdentityCard = ai.IdentityCard,
                Account_Name = ai.Account.UserName
            };
            #endregion
        }
        public List<AccountInformationVM> getAccInfobyName(string Name)
        {
            AccountInformation_DAL AIdal = new AccountInformation_DAL();
            List<AccountInformationVM> data = new List<AccountInformationVM>();
            List<AccountInformation> data1 = new List<AccountInformation>();
            if (Name == "")
            {
                data1 = AIdal.getAllAccInfo();
            }
            else
            {
                foreach (AccountInformation i in AIdal.getAllAccInfo())
                {
                    if(i.Name == Name)
                    {
                        data1.Add(i);
                    }
                }
            }
            foreach(AccountInformation i in data1)
            {
                data.Add(new AccountInformationVM
                {
                    Id=i.Id,
                    Name = i.Name,
                    Gender = i.Gender,
                    PhoneNumber = i.PhoneNumber,
                    Salary = i.Salary,
                    Account_Id = i.Account.Id,
                    Address = i.Address,
                    IdentityCard = i.IdentityCard,
                    Account_Name = i.Account.UserName

                });
            }
            return data;
        }
        public bool checkExistAccInfo(int id, int idtaikhoan)
        {
            AccountInformation_DAL AI_dal = new AccountInformation_DAL();
            foreach(AccountInformation i in AI_dal.getAllAccInfo())
            {
                if(i.Id != id && i.Account.Id == idtaikhoan)
                {
                    return false;
                }    
            }
            return true;
        }
        public void addAccInfo(AccountInformationVM a)
        {
            if (a.Validate().Length != 0)
            {
                throw new Exception(a.Validate());
            }
            else
            {
                if(checkExistAccInfo(a.Id, a.Account_Id) == false)
                {
                    throw new Exception("Tài khoản này đã được thêm thông tin!");
                }    
                else
                {
                    AccountInformation_DAL AI_dal = new AccountInformation_DAL();
                    AI_dal.addAccInfo(new AccountInformation
                    {
                        Id = a.Id,
                        Name = a.Name,
                        Gender = a.Gender,
                        PhoneNumber = a.PhoneNumber,
                        IdentityCard = a.IdentityCard,
                        Salary = a.Salary,
                        Address = a.Address,
                        Account_Id = a.Account_Id
                    });
                    
                }    

            }    
        }
        public void deleteAccountInfo(int id)
        {
            AccountInformation_DAL AI_dal = new AccountInformation_DAL();
            AI_dal.delAccInfo(id);
        }
        public void updateAccInfo(AccountInformationVM a)
        {
            if (a.Validate().Length != 0)
            {
                throw new Exception(a.Validate());
            }
            else
            {
                if (checkExistAccInfo(a.Id, a.Account_Id) == false)
                {
                    throw new Exception("Tên tài khoản không trùng khớp với thông tin để sửa!");
                }
                else
                {
                    AccountInformation_DAL AI_dal = new AccountInformation_DAL();
                    AI_dal.updateAccInfo(new AccountInformation
                    {
                        Id = a.Id,
                        Name = a.Name,
                        Gender = a.Gender,
                        PhoneNumber = a.PhoneNumber,
                        IdentityCard = a.IdentityCard,
                        Salary = a.Salary,
                        Address = a.Address,
                        Account_Id = a.Account_Id
                    });

                }

            }
        }
    }
}
