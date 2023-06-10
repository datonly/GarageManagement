using BLL.ViewModels;
using DAL.DAL_DTO;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BLL.BLL_DTO
{
    public class KhachHang_BLL
    {
        public List<KhachHangVM> getAllKHByBienSo(string bienso)
        {
            List<KhachHang> data = new List<KhachHang>();
            List<KhachHangVM> datavm = new List<KhachHangVM>();
            KhachHang_DAL kh_dal = new KhachHang_DAL();
            if (bienso == "")
            {
                data = kh_dal.getAllKH();
            }
            else
            {
                foreach (KhachHang i in kh_dal.getAllKH())
                {
                    if (i.BienSoXe.Contains(bienso))
                    {
                        data.Add(i);
                    }
                }
            }
            foreach (KhachHang i in data)
            {
                datavm.Add(new KhachHangVM
                {
                    Id = i.Id,
                    BienSoXe = i.BienSoXe,
                    HieuXe_ID = i.HieuXe_ID,
                    HieuXe = i.HieuXe.NameHieuXe,
                    TenChuXe = i.TenChuXe,
                    SoDienThoai = i.SoDienThoai,
                    DiaChi = i.DiaChi,
                    Email = i.Email

                });
            }
            return datavm;
        }
        public bool checkBienSo(string licensePlate)
        {
            if (licensePlate.Length < 8 || licensePlate.Length > 9)
            {
                return false;
            }
            string firstTwoChars = licensePlate.Substring(0, 2);
            if (!Regex.IsMatch(firstTwoChars, @"^(1[1-9]|[2-9][0-9])$"))
            {
                return false;
            }
            string thirdChar = licensePlate.Substring(2, 1);
            if (!Regex.IsMatch(thirdChar, @"^[A-Za-z]$"))
            {
                return false;
            }
            if (licensePlate.Length == 9)
            {
                string fourthChar = licensePlate.Substring(3, 1);
                if (!Regex.IsMatch(fourthChar, @"^[1-9]$"))
                {
                    return false;
                }
            }
            string lastGroup = licensePlate.Substring(licensePlate.Length - 5, 5);
            if (!Regex.IsMatch(lastGroup, @"^0*(?:[1-9][0-9]{0,4}|[1-9][0-9]{0,3}|[1-9][0-9]{0,2}|[1-9][0-9]|[1-9])$"))
            {
                return false;
            }

            return true;

        }
        public bool checkExistBienSo(int Id, string biensoxe)
        {
            KhachHang_DAL kh_dal = new KhachHang_DAL();
            foreach (KhachHang i in kh_dal.getAllKH())
            {
                if (i.BienSoXe == biensoxe && i.Id != Id)
                {
                    return false;

                }
            }
            return true;
        }
        public void themKhachHang(KhachHangVM a)
        {
            if (a.Validate().Length != 0)
            {
                throw new Exception(a.Validate());
            }
            else
            {
                if (checkBienSo(a.BienSoXe) == false)
                {
                    throw new Exception("Biển số không đúng định dạng!");
                }
                else if (checkExistBienSo(a.Id, a.BienSoXe) == false)
                {
                    throw new Exception("Biển số này đã tồn tại!");
                }
                else
                {
                    KhachHang data = new KhachHang()
                    {
                        BienSoXe = a.BienSoXe,
                        HieuXe_ID = a.HieuXe_ID,
                        TenChuXe = a.TenChuXe,
                        SoDienThoai = a.SoDienThoai,
                        Email = a.Email,
                        DiaChi = a.DiaChi,


                    };
                    KhachHang_DAL kh_dal = new KhachHang_DAL();
                    kh_dal.themKhachHang(data);

                }
            }
        }
        public void UpdateKhachHang(KhachHangVM a)
        {
            if (a.Validate().Length != 0)
            {
                throw new Exception(a.Validate());
            }
            else
            {
                if (checkBienSo(a.BienSoXe) == false)
                {
                    throw new Exception("Biển số không đúng định dạng!");
                }
                else if (checkExistBienSo(a.Id, a.BienSoXe) == false)
                {
                    throw new Exception("Biển số này đã tồn tại!");
                }
                else
                {
                    KhachHang data = new KhachHang()
                    {
                        Id = a.Id,
                        BienSoXe = a.BienSoXe,
                        HieuXe_ID = a.HieuXe_ID,
                        TenChuXe = a.TenChuXe,
                        SoDienThoai = a.SoDienThoai,
                        Email = a.Email,
                        DiaChi = a.DiaChi,


                    };
                    KhachHang_DAL kh_dal = new KhachHang_DAL();
                    kh_dal.updateKhachHang(data);

                }
            }
        }
        public KhachHangVM getKHbyBienSo(string bienso)
        {
            KhachHang_DAL kh_dal = new KhachHang_DAL();
            foreach (KhachHang i in kh_dal.getAllKH())
            {
                if (i.BienSoXe == bienso)
                {
                    return new KhachHangVM()
                    {
                        Id = i.Id,
                        BienSoXe = i.BienSoXe,
                        HieuXe_ID = i.HieuXe_ID,
                        HieuXe = i.HieuXe.NameHieuXe,
                        TenChuXe = i.TenChuXe,
                        SoDienThoai = i.SoDienThoai,
                        DiaChi = i.DiaChi,
                        Email = i.Email
                    };

                }

            }
            return null;
        }
        public bool checkKhachHang(int Id)
        {
            KhachHang_DAL kh_dal = new KhachHang_DAL();
            HashSet<PhieuSuaChua> psc = kh_dal.getKHByID(Id).PhieuSuaChuas;
            foreach (PhieuSuaChua i in psc)
            {
                if (i.TrangThai == "UnPurchased")
                {
                    return true;
                }
            }
            return false;
        }
        public void deleteKhachHang(int Id)
        {
            KhachHang_DAL kh_dal = new KhachHang_DAL();
            kh_dal.deleteKhachHang(Id);
        }
    }
}
