namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountInformations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.Boolean(nullable: false),
                        PhoneNumber = c.String(),
                        IdentityCard = c.String(),
                        Salary = c.Single(nullable: false),
                        Address = c.String(),
                        Account_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.Account_Id, cascadeDelete: true)
                .Index(t => t.Account_Id);
            
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        PassWord = c.String(),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PhieuSuaChuas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BillCode = c.String(),
                        Customer_ID = c.Int(nullable: false),
                        NgayLapPhieu = c.DateTime(nullable: false),
                        NgayThanhToan = c.DateTime(),
                        Account_ID = c.Int(nullable: false),
                        TienUng = c.Double(nullable: false),
                        TongTien = c.Double(nullable: false),
                        TrangThai = c.String(),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccountInformations", t => t.Account_ID, cascadeDelete: true)
                .ForeignKey("dbo.KhachHangs", t => t.Customer_ID, cascadeDelete: true)
                .Index(t => t.Customer_ID)
                .Index(t => t.Account_ID);
            
            CreateTable(
                "dbo.ChiTietPhieuSCs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ID_Phieu = c.Int(nullable: false),
                        ID_TienCong = c.Int(nullable: false),
                        ID_PhuTung = c.Int(nullable: false),
                        SoLuong = c.Int(nullable: false),
                        Total = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PhieuSuaChuas", t => t.ID_Phieu, cascadeDelete: true)
                .ForeignKey("dbo.PhuTungs", t => t.ID_PhuTung, cascadeDelete: true)
                .ForeignKey("dbo.TienCongs", t => t.ID_TienCong, cascadeDelete: true)
                .Index(t => t.ID_Phieu)
                .Index(t => t.ID_TienCong)
                .Index(t => t.ID_PhuTung);
            
            CreateTable(
                "dbo.PhuTungs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameVTPT = c.String(),
                        DonVi = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                        SoLuong = c.Int(nullable: false),
                        GiaBan = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TienCongs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NoiDung = c.String(),
                        GiaTC = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BienSoXe = c.String(),
                        HieuXe_ID = c.Int(nullable: false),
                        TenChuXe = c.String(),
                        SoDienThoai = c.String(),
                        Email = c.String(),
                        DiaChi = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HieuXes", t => t.HieuXe_ID, cascadeDelete: true)
                .Index(t => t.HieuXe_ID);
            
            CreateTable(
                "dbo.HieuXes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameHieuXe = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BaoCaoDoanhThus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Thang = c.Int(nullable: false),
                        Nam = c.Int(nullable: false),
                        TongDoanhThu = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ChiTietBCDTs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ID_BCDT = c.Int(nullable: false),
                        ID_HieuXe = c.Int(nullable: false),
                        SoLuotSua = c.Int(nullable: false),
                        ThanhTien = c.Double(nullable: false),
                        TiLe = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BaoCaoDoanhThus", t => t.ID_BCDT, cascadeDelete: true)
                .ForeignKey("dbo.HieuXes", t => t.ID_HieuXe, cascadeDelete: true)
                .Index(t => t.ID_BCDT)
                .Index(t => t.ID_HieuXe);
            
            CreateTable(
                "dbo.BaoCaoTonVTPTs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Thang = c.Int(nullable: false),
                        Nam = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ChiTiet_BCT",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BCT_ID = c.Int(nullable: false),
                        VTPT_ID = c.Int(nullable: false),
                        TonDau = c.Int(nullable: false),
                        PhatSinh = c.Int(nullable: false),
                        TonCuoi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BaoCaoTonVTPTs", t => t.BCT_ID, cascadeDelete: true)
                .ForeignKey("dbo.PhuTungs", t => t.VTPT_ID, cascadeDelete: true)
                .Index(t => t.BCT_ID)
                .Index(t => t.VTPT_ID);
            
            CreateTable(
                "dbo.QuyDinhs",
                c => new
                    {
                        SoXeSuaChuaToiDa = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.SoXeSuaChuaToiDa);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChiTiet_BCT", "VTPT_ID", "dbo.PhuTungs");
            DropForeignKey("dbo.ChiTiet_BCT", "BCT_ID", "dbo.BaoCaoTonVTPTs");
            DropForeignKey("dbo.ChiTietBCDTs", "ID_HieuXe", "dbo.HieuXes");
            DropForeignKey("dbo.ChiTietBCDTs", "ID_BCDT", "dbo.BaoCaoDoanhThus");
            DropForeignKey("dbo.PhieuSuaChuas", "Customer_ID", "dbo.KhachHangs");
            DropForeignKey("dbo.KhachHangs", "HieuXe_ID", "dbo.HieuXes");
            DropForeignKey("dbo.ChiTietPhieuSCs", "ID_TienCong", "dbo.TienCongs");
            DropForeignKey("dbo.ChiTietPhieuSCs", "ID_PhuTung", "dbo.PhuTungs");
            DropForeignKey("dbo.ChiTietPhieuSCs", "ID_Phieu", "dbo.PhieuSuaChuas");
            DropForeignKey("dbo.PhieuSuaChuas", "Account_ID", "dbo.AccountInformations");
            DropForeignKey("dbo.AccountInformations", "Account_Id", "dbo.Accounts");
            DropIndex("dbo.ChiTiet_BCT", new[] { "VTPT_ID" });
            DropIndex("dbo.ChiTiet_BCT", new[] { "BCT_ID" });
            DropIndex("dbo.ChiTietBCDTs", new[] { "ID_HieuXe" });
            DropIndex("dbo.ChiTietBCDTs", new[] { "ID_BCDT" });
            DropIndex("dbo.KhachHangs", new[] { "HieuXe_ID" });
            DropIndex("dbo.ChiTietPhieuSCs", new[] { "ID_PhuTung" });
            DropIndex("dbo.ChiTietPhieuSCs", new[] { "ID_TienCong" });
            DropIndex("dbo.ChiTietPhieuSCs", new[] { "ID_Phieu" });
            DropIndex("dbo.PhieuSuaChuas", new[] { "Account_ID" });
            DropIndex("dbo.PhieuSuaChuas", new[] { "Customer_ID" });
            DropIndex("dbo.AccountInformations", new[] { "Account_Id" });
            DropTable("dbo.QuyDinhs");
            DropTable("dbo.ChiTiet_BCT");
            DropTable("dbo.BaoCaoTonVTPTs");
            DropTable("dbo.ChiTietBCDTs");
            DropTable("dbo.BaoCaoDoanhThus");
            DropTable("dbo.HieuXes");
            DropTable("dbo.KhachHangs");
            DropTable("dbo.TienCongs");
            DropTable("dbo.PhuTungs");
            DropTable("dbo.ChiTietPhieuSCs");
            DropTable("dbo.PhieuSuaChuas");
            DropTable("dbo.Accounts");
            DropTable("dbo.AccountInformations");
        }
    }
}
