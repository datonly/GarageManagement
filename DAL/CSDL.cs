using DAL.Models;

using System;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace DAL
{
    public class CSDL : DbContext
    {
        // Your context has been configured to use a 'CSDL' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DAL.CSDL' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CSDL' 
        // connection string in the application configuration file.
        public CSDL()
            : base("name=CSDL")
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountInformation> AccountInformations { get; set; }
        public virtual DbSet<BaoCaoDoanhThu> BaoCaoDoanhThus { get; set; }
        public virtual DbSet<BaoCaoTonVTPT> BaoCaoTonVTPTs { get; set; }
        public virtual DbSet<ChiTiet_BCT> ChiTiet_BCTs { get; set; }
        public virtual DbSet<ChiTietBCDT> ChiTietBCDTs { get; set; }
        public virtual DbSet<ChiTietPhieuSC> ChiTietPhieuSCs { get; set; }
        public virtual DbSet<HieuXe> HieuXes { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<PhieuSuaChua> PhieuSuaChuas { get; set; }
        public virtual DbSet<PhuTung> PhuTungs { get; set; }
        public virtual DbSet<QuyDinh> QuyDinhs { get; set; }
        public virtual DbSet<TienCong> TienCongs { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}