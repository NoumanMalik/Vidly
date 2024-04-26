namespace Vidly.Migrations
{
    using Microsoft.Ajax.Utilities;
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDataInCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers (Name,IsSubscribedToNewsLetter,MembershipTypeId) VALUES ('Nouman Malik',1,1)");
            Sql("INSERT INTO Customers (Name,IsSubscribedToNewsLetter,MembershipTypeId) VALUES ('Abdul Haseeb',1,2)");
            Sql("INSERT INTO Customers (Name,IsSubscribedToNewsLetter,MembershipTypeId) VALUES ('Haris Ahmed',1,3)");
        }
        
        public override void Down()
        {
        }
    }
}
