namespace Transient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAdditionalVehicleProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "Year", c => c.DateTime(nullable: false));
            AddColumn("dbo.Vehicles", "YearAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Vehicles", "NumberInStock", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vehicles", "NumberInStock");
            DropColumn("dbo.Vehicles", "YearAdded");
            DropColumn("dbo.Vehicles", "Year");
        }
    }
}
