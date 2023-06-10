using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }

        public string PassWord { get; set; }

        public string Role { get; set; }

        
    }
}
