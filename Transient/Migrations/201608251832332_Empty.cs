namespace Transient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Empty : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Vehicles", "VehicleType_Id", "dbo.VehicleTypes");
            DropIndex("dbo.Vehicles", new[] { "VehicleType_Id" });
            AlterColumn("dbo.Vehicles", "VehicleType_Id", c => c.Int());
            CreateIndex("dbo.Vehicles", "VehicleType_Id");
            AddForeignKey("dbo.Vehicles", "VehicleType_Id", "dbo.VehicleTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "VehicleType_Id", "dbo.VehicleTypes");
            DropIndex("dbo.Vehicles", new[] { "VehicleType_Id" });
            AlterColumn("dbo.Vehicles", "VehicleType_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Vehicles", "VehicleType_Id");
            AddForeignKey("dbo.Vehicles", "VehicleType_Id", "dbo.VehicleTypes", "Id", cascadeDelete: true);
        }
    }
}
