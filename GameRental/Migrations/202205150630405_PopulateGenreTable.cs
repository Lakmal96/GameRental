namespace GameRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Adventure')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Puzzle')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Sport')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Strategy')");
        }
        
        public override void Down()
        {
        }
    }
}
