namespace MobileManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class phone_number_changed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Devices", "PhoneNumber", c => c.String());
            DropColumn("dbo.Users", "PhoneNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "PhoneNumber", c => c.String());
            DropColumn("dbo.Devices", "PhoneNumber");
        }
    }
}
