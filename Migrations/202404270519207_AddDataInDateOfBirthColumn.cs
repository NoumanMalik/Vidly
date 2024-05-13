namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataInDateOfBirthColumn : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers set DateOfBirth = 07/03/1991 where Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
