namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddToPSC : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ChiTietPhieuSCs", "isDone", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ChiTietPhieuSCs", "isDone");
        }
    }
}
