namespace Transient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNumberOfStockedVehiclesToLocationsModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Vehicles", "Location_Id", "dbo.Locations");
            DropIndex("dbo.Vehicles", new[] { "Location_Id" });
            AddColumn("dbo.Locations", "numberOfStockedVehicles", c => c.Int(nullable: false));
            DropColumn("dbo.Vehicles", "Location_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vehicles", "Location_Id", c => c.Int());
            DropColumn("dbo.Locations", "numberOfStockedVehicles");
            CreateIndex("dbo.Vehicles", "Location_Id");
            AddForeignKey("dbo.Vehicles", "Location_Id", "dbo.Locations", "Id");
        }
    }
}
