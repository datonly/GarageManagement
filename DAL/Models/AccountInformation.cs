﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class AccountInformation
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Gender { get; set; }

        public string PhoneNumber { get; set; }

        public string IdentityCard { get; set; }

        public float Salary { get; set; }

        public string Address { get; set; }

        public int Account_Id { get; set; }
        [ForeignKey(nameof(Account_Id))]
        public virtual Account Account { get; set; }
        

        public virtual HashSet<PhieuSuaChua> PhieuSuaChuas { get; set; }
    }
}
