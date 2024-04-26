namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembersipType : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers set MembershipTypeId = 1 where Id = 3");
        }
        
        public override void Down()
        {
        }
    }
}
