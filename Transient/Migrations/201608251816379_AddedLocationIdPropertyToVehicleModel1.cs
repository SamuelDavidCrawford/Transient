namespace Transient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedLocationIdPropertyToVehicleModel1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Vehicles", "LocationId", "dbo.Locations");
            DropIndex("dbo.Vehicles", new[] { "LocationId" });
            DropColumn("dbo.Vehicles", "LocationId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vehicles", "LocationId", c => c.Int(nullable: false));
            CreateIndex("dbo.Vehicles", "LocationId");
            AddForeignKey("dbo.Vehicles", "LocationId", "dbo.Locations", "Id", cascadeDelete: true);
        }
    }
}
