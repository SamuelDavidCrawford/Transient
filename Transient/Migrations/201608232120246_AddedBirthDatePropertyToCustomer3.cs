namespace Transient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBirthDatePropertyToCustomer3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Vehicles", "VehicleType_Id", "dbo.VehicleTypes");
            DropIndex("dbo.Vehicles", new[] { "VehicleType_Id" });
            DropTable("dbo.Vehicles");
            DropTable("dbo.VehicleTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.VehicleTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Year = c.DateTime(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        NumberInStock = c.Int(nullable: false),
                        VehicleType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Vehicles", "VehicleType_Id");
            AddForeignKey("dbo.Vehicles", "VehicleType_Id", "dbo.VehicleTypes", "Id");
        }
    }
}
