using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DAL.DAL_DTO
{
    public class Account_DAL
    {
        public Account getAccount(string username, string password)
        {
            CSDL db = new CSDL();
            var Account = db.Accounts.FirstOrDefault(p => p.UserName == username && p.PassWord == password);
            return Account;
        }
        public Account getByID(int id)
        {
            CSDL db = new CSDL();
            var Account = db.Accounts.Find(id);
            return Account;
        }
        public List<Account> getAllAccounts()
        {
            CSDL db = new CSDL();
            return db.Accounts.ToList();

        }
        public void AddAccount(Account account)
        {
            CSDL db = new CSDL();
            db.Accounts.Add(account);
            db.SaveChanges();
        }
        public void UpdateAccount(Account account)
        {
            CSDL db = new CSDL();
            var acc = db.Accounts.FirstOrDefault(p => p.Id == account.Id);
            acc.UserName = account.UserName;
            acc.Role = account.Role;
            db.SaveChanges();
        }
        public void DeleteAccount(int id)
        {
            CSDL db = new CSDL();
            var acc = db.Accounts.FirstOrDefault(p =>p.Id == id);
            db.Accounts.Remove(acc);
            db.SaveChanges();
        }
        public void updatePass(int Id, string newpass)
        {
            CSDL db = new CSDL();
            var acc = db.Accounts.FirstOrDefault(p => p.Id == Id);
            acc.PassWord = newpass;
            db.SaveChanges();
        }
            

        


    }
}
