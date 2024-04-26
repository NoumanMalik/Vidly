namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IdentityModel1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CustomerModels", newName: "Customers");
            RenameTable(name: "dbo.MoviesModels", newName: "Movies");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Movies", newName: "MoviesModels");
            RenameTable(name: "dbo.Customers", newName: "CustomerModels");
        }
    }
}
