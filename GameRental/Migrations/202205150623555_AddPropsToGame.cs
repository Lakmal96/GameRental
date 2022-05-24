namespace GameRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropsToGame : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Games", "GenreId", c => c.Byte(nullable: false));
            AddColumn("dbo.Games", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Games", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Games", "NumberInStock", c => c.Byte(nullable: false));
            AlterColumn("dbo.Games", "Name", c => c.String(nullable: false));
            CreateIndex("dbo.Games", "GenreId");
            AddForeignKey("dbo.Games", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "GenreId", "dbo.Genres");
            DropIndex("dbo.Games", new[] { "GenreId" });
            AlterColumn("dbo.Games", "Name", c => c.String());
            DropColumn("dbo.Games", "NumberInStock");
            DropColumn("dbo.Games", "ReleaseDate");
            DropColumn("dbo.Games", "DateAdded");
            DropColumn("dbo.Games", "GenreId");
            DropTable("dbo.Genres");
        }
    }
}
