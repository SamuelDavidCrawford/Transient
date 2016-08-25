namespace Transient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedVehicleNullableYear : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "Year", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "Year", c => c.DateTime(nullable: false));
        }
    }
}
