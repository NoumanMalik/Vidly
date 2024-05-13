namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerAndMembershipTypeTable : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers set Name = 'Nouman Malik' where Id =1");
            Sql("Update Customers set Name = 'Abdul Haseeb' where Id =2");
            Sql("Update Customers set Name = 'Abdul Majeed' where Id =3");
            Sql("Update MembershipTypes set Membership = 'Pay as You Go' where Id =1");
            Sql("Update MembershipTypes set Membership = 'Monthly' where Id =2");
            Sql("Update MembershipTypes set Membership = 'Quarterly' where Id =3");
            Sql("Update MembershipTypes set Membership = 'Annual' where Id =4");
        }
        
        public override void Down()
        {
        }
    }
}
