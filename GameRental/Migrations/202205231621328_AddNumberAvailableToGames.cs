namespace GameRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberAvailableToGames : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "NumberAvailable", c => c.Byte(nullable: false));

            Sql("UPDATE Games SET NumberAvailable = NumberInStock");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "NumberAvailable");
        }
    }
}
