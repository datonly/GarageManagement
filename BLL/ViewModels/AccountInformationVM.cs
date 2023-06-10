using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ViewModels
{
    public class AccountInformationVM
    {
        public int Id { get; set; }

        [DisplayName("Tên")]
        [Required(ErrorMessage = "Tên không được để trống")]
        public string Name { get; set; }

        [DisplayName("Giới tính")]
        [Required(ErrorMessage = "Phải chọn giới tính")]
        public bool Gender { get; set; }

        [DisplayName("SĐT")]
        [Required(ErrorMessage = "SĐT không được để trống")]
        [MaxLength(10, ErrorMessage = "SĐT không được quá 10 chữ số")]
        [Phone(ErrorMessage = "SĐT phải nhập số")]
        public string PhoneNumber { get; set; }

        [DisplayName("CMND")]
        [Required(ErrorMessage = "CMND không được để trống")]
        [MinLength(9, ErrorMessage = "CMND phải gồm 9 chữ số")]
        [MaxLength(9, ErrorMessage = "CMND phải gồm 9 chữ số")]
        [Phone(ErrorMessage = "CMND phải nhập số")]
        public string IdentityCard { get; set; }

        [DisplayName("Lương")]
        [Required(ErrorMessage = "Lương không được để trống")]
        public float Salary { get; set; }

        [DisplayName("Địa chỉ")]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        public string Address { get; set; }

        [Browsable(false)]
        public int Account_Id { get; set; }

        [DisplayName("Tài khoản")]
        public string Account_Name { get; set; }

        
    }
}
