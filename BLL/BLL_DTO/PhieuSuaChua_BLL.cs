using BLL.ViewModels;
using DAL.DAL_DTO;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.BLL_DTO
{
    public class PhieuSuaChua_BLL
    {
        public List<PhieuSuaChuaVM> getPSCbyBS(string bienso)
        {
            List<PhieuSuaChua> data = new List<PhieuSuaChua>();
            List<PhieuSuaChuaVM> datavm = new List<PhieuSuaChuaVM>();
            PhieuSuaChua_DAL psc_dal = new PhieuSuaChua_DAL();


            if (bienso == "")
            {
                foreach (PhieuSuaChua i in psc_dal.getAllPSC())
                {
                    if (i.TrangThai == "UnPurchased")
                    {
                        data.Add(i);
                    }
                }
            }
            else
            {
                foreach (PhieuSuaChua i in psc_dal.getAllPSC())
                {
                    if (i.KhachHang.BienSoXe.Contains(bienso) && i.TrangThai == "UnPurchased")
                    {
                        data.Add(i);
                    }
                }
            }
            foreach (PhieuSuaChua i in data)
            {
                datavm.Add(new PhieuSuaChuaVM
                {
                    Id = i.Id,
                    BillCode = i.BillCode,
                    Customer_ID = i.Customer_ID,
                    Customer_Name = i.KhachHang.TenChuXe,
                    BienSoXe = i.KhachHang.BienSoXe,
                    Customer_Phone = i.KhachHang.SoDienThoai,
                    NgayLapPhieu = i.NgayLapPhieu,
                    NgayThanhToan = i.NgayThanhToan,
                    Account_ID = i.Account_ID,
                    Cashier_Name = i.Cashier.Name,
                    TienUng = i.TienUng,
                    TongTien = i.TongTien,





                });
            }
            return datavm;
        }
        public void getPSCById(int id, out PhieuSuaChuaVM psc, out List<ChiTietPhieuSCVM> ctpsc)
        {
            PhieuSuaChua_DAL psc_dal = new PhieuSuaChua_DAL();
            List<ChiTietPhieuSC> a = new List<ChiTietPhieuSC>();
            List<ChiTietPhieuSCVM> avm = new List<ChiTietPhieuSCVM>();
            PhieuSuaChua i = psc_dal.getPSCbyID(id);
            a = i.ChiTietPhieuSCs.ToList();
            psc = new PhieuSuaChuaVM()
            {
                Id = i.Id,
                BillCode = i.BillCode,
                Customer_ID = i.Customer_ID,
                Customer_Name = i.KhachHang.TenChuXe,
                BienSoXe = i.KhachHang.BienSoXe,
                Customer_Phone = i.KhachHang.SoDienThoai,
                NgayLapPhieu = i.NgayLapPhieu,
                NgayThanhToan = i.NgayThanhToan,
                Account_ID = i.Account_ID,
                Cashier_Name = i.Cashier.Name,
                TienUng = i.TienUng,
                TongTien = i.TongTien,
            };
            foreach (ChiTietPhieuSC m in a)
            {
                avm.Add(new ChiTietPhieuSCVM()
                {
                    Id = m.Id,
                    ID_Phieu = m.ID_Phieu,
                    Bill_Code = m.PhieuSuaChua.BillCode,
                    ID_TienCong = m.ID_TienCong,
                    NoiDung = m.TienCong.NoiDung,
                    isDone = m.isDone,
                    ID_PhuTung = m.ID_PhuTung,
                    TenVTPT = m.PhuTung.NameVTPT,
                    SoLuong = m.SoLuong,
                    TienUng = m.TienUng,
                    Total = m.Total
                });
            }
            ctpsc = avm;

        }







        public bool existBillCode(string billCode)
        {
            PhieuSuaChua_DAL psc_dal = new PhieuSuaChua_DAL();
            foreach (PhieuSuaChua i in psc_dal.getAllPSC())
            {
                if (i.BillCode == billCode)
                {
                    return false;
                }
            }
            return true;
        }
        public void addPSC(PhieuSuaChuaVM a)
        {
            if (a.Validate().Length != 0)
            {
                throw new Exception(a.Validate());
            }
            else
            {
                if (existBillCode(a.BillCode) == false)
                {
                    throw new Exception("Mã hóa đơn đã tồn tại! Vui lòng chọn lại");
                }
                else
                {
                    PhieuSuaChua_DAL psc_dal = new PhieuSuaChua_DAL();
                    psc_dal.addPSC(new PhieuSuaChua()
                    {
                        BillCode = a.BillCode,
                        Customer_ID = a.Customer_ID,
                        NgayLapPhieu = a.NgayLapPhieu,
                        NgayThanhToan = a.NgayThanhToan,
                        Account_ID = a.Account_ID,
                        TienUng = a.TienUng,
                        TongTien = a.TongTien,
                        TrangThai = "UnPurchased",
                        GhiChu = "Không"

                    });
                }
            }
        }
        public void setBillTotal(int PSC_Id)
        {
            PhieuSuaChua_DAL psc_dal = new PhieuSuaChua_DAL();
            PhieuSuaChua b = psc_dal.getPSCbyID(PSC_Id);
            double _total = 0;
            double _deposit = 0;
            foreach (ChiTietPhieuSC i in b.ChiTietPhieuSCs)
            {
                _total += i.Total;
                _deposit += i.TienUng;
            }
            psc_dal.setBillTotal(PSC_Id, _total, _deposit);
        }
        public string GetContentPrint(int Bill_Id)
        {
            PhieuSuaChua_DAL psc_dal = new PhieuSuaChua_DAL();
            PhieuSuaChua b = psc_dal.getPSCbyID(Bill_Id);
            StringBuilder content = new StringBuilder();
            //Chao mung
            content.Append("\t\t\t\t Hệ thống Gara Oto chuyên nghiệp DUT-GARAGE\n");
            content.Append("\t\t\t\tĐịa chỉ : Trường Đại Học Bách Khoa Đà Nẵng\n\n");
            content.Append("\t\t\t\t\tBáo giá dịch vụ\n");
            content.Append($"\t\t\t\t\tMã hóa đơn : {b.BillCode}\n\n");
            content.Append($"\t\t\t\tNgày thành lập : {DateTime.Now}\n");
            content.Append($"\t\t\t\tNgày thanh toán : Nope\n");
            content.Append($"\t\t\t\tTên khách hàng : {b.KhachHang.TenChuXe}\n");
            content.Append($"\t\t\t\tSố điện thoại : {b.KhachHang.SoDienThoai}\n");
            content.Append($"\t\t\t\tThu ngân : {b.Cashier.Name}\n");

            content.Append("\n_______________________________________Bảng báo giá chi tiết :______________________________________\n\n");
            content.Append($"{"Tên nội dung sửa",15}\t{"Tên VTPT",15}\t{"Tiền công",10}\t{"Tiền VTPT",10}\t{"Tổng cộng",15}\t{"Tiền ứng",10}\n");

            foreach (ChiTietPhieuSC ro in b.ChiTietPhieuSCs)
            {
                content.Append($"{ro.TienCong.NoiDung,15}\t{ro.PhuTung.NameVTPT,15}\t{ro.TienCong.GiaTC,10}\t{ro.PhuTung.GiaBan,10}\t{ro.Total,15}\t{ro.TienUng,10}\n");
            }


            //Tong ket
            content.Append("\n_______________________________________Tổng kết báo giá :________________________________________\n\n");
            content.Append($"\t\t\t\t\t>> Tổng cộng : {b.TongTien}\n");
            content.Append($"\t\t\t\t\t>> Tiền ứng  : {b.TienUng}\n");
            content.Append($"\t\t\t\t\t>> Phải trả  : {b.TongTien - b.TienUng}\n");

            content.Append("\n\t\t\t\t\tKí xác nhận sửa chữa");
            content.Append("\n");
            content.Append("\n");
            content.Append("\n");
            content.Append("\n");
            content.Append("\n");
            content.Append($"\n\t\t\t\t\t {b.KhachHang.TenChuXe}");

            return content.ToString();
        }
        public bool checkHoanThanh(int Id)
        {
            PhieuSuaChua_DAL psc_dal = new PhieuSuaChua_DAL();

            HashSet<ChiTietPhieuSC> listctpsc = psc_dal.getPSCbyID(Id).ChiTietPhieuSCs;
            foreach (ChiTietPhieuSC i in listctpsc)
            {
                if (i.isDone == false)
                {
                    return true;
                }
            }
            return false;
        }
        public void PurchaseBill(int Id)
        {
            PhieuSuaChua_DAL psc_dal = new PhieuSuaChua_DAL();
            psc_dal.PurchaseBill(Id);
        }
        public string GetContentPrintBill(int Bill_Id)
        {
            PhieuSuaChua_DAL psc_dal = new PhieuSuaChua_DAL();
            PhieuSuaChua b = psc_dal.getPSCbyID(Bill_Id);
            StringBuilder content = new StringBuilder();
            //Chao mung
            content.Append("\t\t\t\t Hệ thống Gara Oto chuyên nghiệp DUT-GARAGE\n");
            content.Append("\t\t\t\tĐịa chỉ : Trường Đại Học Bách Khoa Đà Nẵng\n\n");
            content.Append("\t\t\t\t\tHóa đơn thanh toán dịch vụ\n");
            content.Append($"\t\t\t\t\tMã hóa đơn : {b.BillCode}\n\n");
            content.Append($"\t\t\t\tNgày thành lập : {b.NgayLapPhieu}\n");
            content.Append($"\t\t\t\tNgày thanh toán : {b.NgayThanhToan}\n");
            content.Append($"\t\t\t\tTên khách hàng : {b.KhachHang.TenChuXe}\n");
            content.Append($"\t\t\t\tSố điện thoại : {b.KhachHang.SoDienThoai}\n");
            content.Append($"\t\t\t\tThu ngân : {b.Cashier.Name}\n");

            content.Append("\n_______________________________________Bảng sử dụng dịch vụ chi tiết :______________________________________\n\n");
            content.Append($"{"Tên nội dung sửa",15}\t{"Tên VTPT",15}\t{"Tiền công",10}\t{"Tiền VTPT",10}\t{"Tổng cộng",15}\t{"Tiền ứng",10}\n");

            foreach (ChiTietPhieuSC ro in b.ChiTietPhieuSCs)
            {
                content.Append($"{ro.TienCong.NoiDung,15}\t{ro.PhuTung.NameVTPT,15}\t{ro.TienCong.GiaTC,10}\t{ro.PhuTung.GiaBan,10}\t{ro.Total,15}\t{ro.TienUng,10}\n");
            }


            //Tong ket
            content.Append("\n_______________________________________Tổng kết hóa đơn :________________________________________\n\n");
            content.Append($"\t\t\t\t\t>> Tổng cộng : {b.TongTien}\n");
            content.Append($"\t\t\t\t\t>> Tiền ứng  : {b.TienUng}\n");
            content.Append($"\t\t\t\t\t>> Phải trả  : {b.TongTien - b.TienUng}\n");

            content.Append("\n\t\t\t\t\tKí xác nhận trả tiền");
            content.Append("\n");
            content.Append("\n");
            content.Append("\n");
            content.Append("\n");
            content.Append("\n");
            content.Append($"\n\t\t\t\t\t {b.KhachHang.TenChuXe}");

            return content.ToString();
        }
        public void deleteHoaDon(int ID)
        {
            PhieuSuaChua_DAL psc_dal = new PhieuSuaChua_DAL();
            psc_dal.deleteBill(ID);
        }
    }
}
