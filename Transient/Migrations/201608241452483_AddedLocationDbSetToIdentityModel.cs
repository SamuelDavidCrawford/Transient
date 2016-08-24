namespace Transient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedLocationDbSetToIdentityModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Vehicles", "Location_Id", c => c.Int());
            CreateIndex("dbo.Vehicles", "Location_Id");
            AddForeignKey("dbo.Vehicles", "Location_Id", "dbo.Locations", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vehicles", "Location_Id", "dbo.Locations");
            DropIndex("dbo.Vehicles", new[] { "Location_Id" });
            DropColumn("dbo.Vehicles", "Location_Id");
            DropTable("dbo.Locations");
        }
    }
}
