namespace Transient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVehicleType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VehicleTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Vehicles", "VehicleTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Vehicles", "VehicleType_Id", c => c.Int());
            CreateIndex("dbo.Vehicles", "VehicleType_Id");
            AddForeignKey("dbo.Vehicles", "VehicleType_Id", "dbo.VehicleTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "VehicleType_Id", "dbo.VehicleTypes");
            DropIndex("dbo.Vehicles", new[] { "VehicleType_Id" });
            DropColumn("dbo.Vehicles", "VehicleType_Id");
            DropColumn("dbo.Vehicles", "VehicleTypeId");
            DropTable("dbo.VehicleTypes");
        }
    }
}
