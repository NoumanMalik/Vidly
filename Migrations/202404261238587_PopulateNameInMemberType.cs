namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNameInMemberType : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes set Name = 'Free' where Id = 1");
            Sql("Update MembershipTypes set Name = 'One Month' where Id = 2");
            Sql("Update MembershipTypes set Name = 'Three Month' where Id = 3");
            Sql("Update MembershipTypes set Name = 'One Year' where Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
