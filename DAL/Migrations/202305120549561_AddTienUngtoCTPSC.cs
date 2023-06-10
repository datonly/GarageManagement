namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTienUngtoCTPSC : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChiTietPhieuSCs", "TienUng", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ChiTietPhieuSCs", "TienUng");
        }
    }
}
