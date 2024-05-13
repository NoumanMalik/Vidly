namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDateFormatInMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name,ReleaseDate,AddedDate,Stock,GenreId) VALUES ('Shrak','2020-08-28','2024-08-28',4,1)");
            Sql("INSERT INTO Movies (Name,ReleaseDate,AddedDate,Stock,GenreId) VALUES ('PK','2020-08-28','2020-08-28',5,3)");
            Sql("INSERT INTO Movies (Name,ReleaseDate,AddedDate,Stock,GenreId) VALUES ('Wanted','2020-08-28','2020-08-28',4,2)");
            Sql("INSERT INTO Movies (Name,ReleaseDate,AddedDate,Stock,GenreId) VALUES ('John Wick','2020-08-28','2020-08-28',4,1)");
        }
        
        public override void Down()
        {
        }
    }
}
