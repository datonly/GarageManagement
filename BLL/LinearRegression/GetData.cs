using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.LinearRegression
{
    public class GetData
    {
        protected readonly CSDL _db;
        internal DbSet<PhieuSuaChua> dbSet;
        public GetData()
        {
            _db = new CSDL();
            dbSet = _db.Set<PhieuSuaChua>();
        }
        public double[] GetAverageCustomer()
        {
            IQueryable<PhieuSuaChua> query = dbSet;
            query = query.Where(c => c.TrangThai == "Purchased");
            double[] result = new double[7];
            IEnumerable<PhieuSuaChua> listBill = query;
            for (int i = 0; i < 7; i++)
            {
                IEnumerable<PhieuSuaChua> listBillPerDOW = listBill.Where(c => c.NgayThanhToan.Value.DayOfWeek
                                                          == (DayOfWeek)i);                //0 : Sunday
                int totalCus = listBillPerDOW.Count();
                int totalDate = listBillPerDOW.GroupBy(c => c.NgayThanhToan.Value.Date).Count();
                if (totalCus == 0) result[i] = 0;
                else result[i] = (double)totalCus / totalDate;
            }
            return result;
        }

        // Trong mỗi ngày, có bao nhiêu khách và doanh thu bao nhiêu
        public IEnumerable<PricePerCustomer> GetPricePerCustomer()
        {
            IQueryable<PhieuSuaChua> query = dbSet;
            return query.Where(c => c.TrangThai == "Purchased")
            .GroupBy(c => EntityFunctions.TruncateTime(c.NgayThanhToan))
            .Select(c => new PricePerCustomer
            {
                TotalCus = c.Count(),
                TotalPrice = c.Sum(x => x.TongTien)
            });
        }
    }

    public class PricePerCustomer
    {
        public int TotalCus { get; set; }
        public double TotalPrice { get; set; }
    }
}

