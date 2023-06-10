namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Reflection;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.CSDL>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = true;

        }

        protected override void Seed(DAL.CSDL context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            //context.Accounts.Add(new Models.Account
            //{
            //    Id = 1,
            //    UserName = "admin",
            //    PassWord = "c4ca4238a0b923820dcc509a6f75849b",
            //    Role = "Admin",

            //});
            //context.Accounts.AddOrUpdate();
        }
    }
}
