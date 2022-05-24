namespace GameRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'38fbf58f-9517-460d-91c9-0abd6b21c6a8', N'guest@gmail.com', 0, N'ACJjPx/pinF2Capv0AXlu4RCDiBRLDtedAGW+3W5eanEUXq0M9h5Tj9162HFw5Ky6Q==', N'17a39084-8333-4d7d-9718-105f8ccce637', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4518b506-3ca3-4cde-a33a-64260624b2c2', N'admin@gmail.com', 0, N'ALpnfWjPHZR0UC8nBKuzOJzEyCbCB5J9V2AOT+iJYBo2e1vFdnCvad6UA3SvI1+jPA==', N'8f8abd2b-72e4-43fa-8b38-4b6dbda4c6de', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'53c46ee6-cab3-4f4a-a260-298f1916472a', N'tharindu96221@gmail.com', 0, N'AEt7iRxaTMHvk9gTONqe2nwayJ5hX7zAixg7OiWDa1kRSO/eslykWJZEKJHngiP1hA==', N'3e267672-af3f-4d0b-b1dc-3755e05da53b', NULL, 0, 0, NULL, 1, 0, N'tharindu96221@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'614425ab-31d9-47a5-9d04-e25194975311', N'CanManageGames')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4518b506-3ca3-4cde-a33a-64260624b2c2', N'614425ab-31d9-47a5-9d04-e25194975311')

");
        }
        
        public override void Down()
        {
        }
    }
}
