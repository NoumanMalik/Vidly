namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDateInDateOfBirthColumn : DbMigration
    {
        public override void Up()
        {
           Sql("Update Customers set DateOfBirth = '1991-03-07' where Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
