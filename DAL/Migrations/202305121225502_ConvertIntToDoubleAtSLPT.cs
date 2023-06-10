namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConvertIntToDoubleAtSLPT : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PhuTungs", "SoLuong", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PhuTungs", "SoLuong", c => c.Int(nullable: false));
        }
    }
}
