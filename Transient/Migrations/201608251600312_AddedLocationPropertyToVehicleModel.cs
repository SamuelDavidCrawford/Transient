namespace Transient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedLocationPropertyToVehicleModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "Location_Id", c => c.Int());
            CreateIndex("dbo.Vehicles", "Location_Id");
            AddForeignKey("dbo.Vehicles", "Location_Id", "dbo.Locations", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "Location_Id", "dbo.Locations");
            DropIndex("dbo.Vehicles", new[] { "Location_Id" });
            DropColumn("dbo.Vehicles", "Location_Id");
        }
    }
}
