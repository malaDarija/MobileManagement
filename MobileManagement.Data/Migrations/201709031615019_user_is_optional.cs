namespace MobileManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user_is_optional : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Devices", "UserId", "dbo.Users");
            DropIndex("dbo.Devices", new[] { "UserId" });
            AlterColumn("dbo.Devices", "UserId", c => c.Int(nullable: true));
            CreateIndex("dbo.Devices", "UserId");
            AddForeignKey("dbo.Devices", "UserId", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Devices", "UserId", "dbo.Users");
            DropIndex("dbo.Devices", new[] { "UserId" });
            AlterColumn("dbo.Devices", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Devices", "UserId");
            AddForeignKey("dbo.Devices", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
