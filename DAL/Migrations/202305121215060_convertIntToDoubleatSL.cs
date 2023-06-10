namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class convertIntToDoubleatSL : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ChiTietPhieuSCs", "SoLuong", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ChiTietPhieuSCs", "SoLuong", c => c.Int(nullable: false));
        }
    }
}
