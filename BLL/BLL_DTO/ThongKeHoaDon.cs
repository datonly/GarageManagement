using AutoMapper;
using BLL.ViewModels;
using DAL;
using DAL.DAL_DTO;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL_DTO
{
    public class ThongKeHoaDon
    {
        protected readonly CSDL _db;
        internal DbSet<PhieuSuaChua> dbSet;
        public ThongKeHoaDon()
        {
            _db = new CSDL();
            dbSet = _db.Set<PhieuSuaChua>();
        }
        public List<PhieuSuaChuaVM> GetBillHistory(string CustomerName, DateTime? _fromDate = null,
                                                                        DateTime? _toDate = null)
        {
            PhieuSuaChua_DAL psc_dal = new PhieuSuaChua_DAL();
            CustomerName = CustomerName.Trim();
            List<PhieuSuaChua> list = new List<PhieuSuaChua>();
            List<PhieuSuaChuaVM> listvm = new List<PhieuSuaChuaVM>();
            foreach (PhieuSuaChua i in psc_dal.getAllPSC())
            {
                if(i.TrangThai == "Purchased" && i.KhachHang.TenChuXe.Contains(CustomerName))
                {
                    list.Add(i);
                }    
            }    
            if (_fromDate != null && _toDate != null)
            {
                list = list.Where(c => c.NgayThanhToan.Value.Date >= _fromDate.Value.Date
                                    && c.NgayThanhToan.Value.Date <= _toDate.Value.Date).ToList();
            }
            foreach (PhieuSuaChua i in list)
            {
                listvm.Add(new PhieuSuaChuaVM()
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
            return listvm;
        }
        public void StatisticMonthAndToday(out int _billMonth, out int _billToday,
                            out int _cusMonth, out int _cusToday, out double _saleMonth, out double _saleToday)
        {
            
            IQueryable<PhieuSuaChua> query = dbSet;
            query = query.Where(c => c.NgayThanhToan.Value.Month == DateTime.Now.Month
                                           && c.NgayThanhToan.Value.Year == DateTime.Now.Year);
            IEnumerable<PhieuSuaChua> list_bill = query;

                                         

            _billMonth = list_bill.Count();

            _billToday = list_bill.Count(c => c.NgayThanhToan.Value.Day == DateTime.Now.Day);

            _saleMonth = list_bill.Sum(c => c.TongTien);

            _saleToday = list_bill.Where(c => c.NgayThanhToan.Value.Day == DateTime.Now.Day).Sum(c => c.TongTien);

            _cusMonth = list_bill.GroupBy(c => c.Customer_ID).Count();

            _cusToday = list_bill.Where(c => c.NgayThanhToan.Value.Day == DateTime.Now.Day)
                                .GroupBy(c => c.Customer_ID).Count();
        }
        public void StatisticSalePerMonth(out double[] _doanhThuThang)
        {
            _doanhThuThang = new double[13];
            IQueryable<PhieuSuaChua> query = dbSet;
            query = query.Where(c => c.TrangThai == "Purchased" &&
                                            c.NgayThanhToan.Value.Year == DateTime.Now.Year);
            IEnumerable<PhieuSuaChua> list = query;
            for (int i = 1; i <= 12; i++)
            {
                _doanhThuThang[i] += list.Where(c => c.NgayThanhToan.Value.Month == i)
                                            .Sum(c => c.TongTien);
            }
        }
    }
}
