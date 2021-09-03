namespace vividly_app.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3b36e98c-0af0-460d-add8-bf0f871dae68', N'guest@vividly.com', 0, N'ADaY4EizlCzEL9+vlwoblkW1lpIXygXbnXhwy9BxxN/KoU+JSWaOdbyi9alB8VvSpQ==', N'b6fc1270-17be-49dc-98a7-bd11ca56e735', NULL, 0, 0, NULL, 1, 0, N'guest@vividly.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4292664a-8b0d-440e-a6e2-2c08b6c69277', N'uriel.fiori@gmail.com', 0, N'ACW81/liBRdxYvtFNpNS1fQ8sOPrj+qDKafjpqR9g926z4XjYxj+PR0rL1rREUtf1w==', N'19eece9c-2b1d-44d9-b838-a37bbc795435', NULL, 0, 0, NULL, 1, 0, N'uriel.fiori@gmail.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'46c1b5e3-7961-47bf-8857-db3904c5ca1c', N'admin@vividly.com', 0, N'AMDAeq9VDrmEXmEllIrGt1krvpqoXdc6deszKa52aDAdp8WckjFJLpvDM137YKQEOg==', N'eca16919-064d-4437-aef1-ad53fa3b8705', NULL, 0, 0, NULL, 1, 0, N'admin@vividly.com')
                  
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f975c4fd-f493-4d62-9ec4-1bd227859468', N'CanManageMovie')
                  
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'46c1b5e3-7961-47bf-8857-db3904c5ca1c', N'f975c4fd-f493-4d62-9ec4-1bd227859468')
                ");
        }

        public override void Down()
        {
        }
    }
}
