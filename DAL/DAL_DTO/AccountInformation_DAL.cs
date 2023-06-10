using DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.DAL_DTO
{
    public class AccountInformation_DAL
    {
        public AccountInformation GetAIByAccountId(int Account_Id)
        {
            CSDL db = new CSDL();
            var AI = db.AccountInformations.FirstOrDefault(p => p.Account_Id == Account_Id);
            return AI;
        }
        public List<AccountInformation> getAllAccInfo()
        {
            CSDL db = new CSDL();
            return db.AccountInformations.ToList();
        }
        public void addAccInfo(AccountInformation a)
        {
            CSDL db = new CSDL();
            db.AccountInformations.Add(a);
            db.SaveChanges();
        }
        public void delAccInfo(int id)
        {
            CSDL db = new CSDL();
            var s = db.AccountInformations.Where(p => p.Id == id).FirstOrDefault();
            db.AccountInformations.Remove(s);
            db.SaveChanges();
        }
        public void updateAccInfo(AccountInformation a)
        {
            CSDL db = new CSDL();
            var s = db.AccountInformations.Where(p => p.Id == a.Id).FirstOrDefault();
            s.Name = a.Name;
            s.Gender = a.Gender;
            s.PhoneNumber = a.PhoneNumber;
            s.IdentityCard = a.IdentityCard;
            s.Salary = a.Salary;
            s.Address = a.Address;
                        
            db.SaveChanges();
        }
    }
}
