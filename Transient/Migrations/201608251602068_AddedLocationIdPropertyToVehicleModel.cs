namespace Transient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedLocationIdPropertyToVehicleModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Vehicles", "Location_Id", "dbo.Locations");
            DropIndex("dbo.Vehicles", new[] { "Location_Id" });
            RenameColumn(table: "dbo.Vehicles", name: "Location_Id", newName: "LocationId");
            AlterColumn("dbo.Vehicles", "LocationId", c => c.Int(nullable: false));
            CreateIndex("dbo.Vehicles", "LocationId");
            AddForeignKey("dbo.Vehicles", "LocationId", "dbo.Locations", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "LocationId", "dbo.Locations");
            DropIndex("dbo.Vehicles", new[] { "LocationId" });
            AlterColumn("dbo.Vehicles", "LocationId", c => c.Int());
            RenameColumn(table: "dbo.Vehicles", name: "LocationId", newName: "Location_Id");
            CreateIndex("dbo.Vehicles", "Location_Id");
            AddForeignKey("dbo.Vehicles", "Location_Id", "dbo.Locations", "Id");
        }
    }
}
