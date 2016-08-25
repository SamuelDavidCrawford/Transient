namespace Transient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedVehicleNullableYear1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "YearAdded", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "YearAdded", c => c.DateTime(nullable: false));
        }
    }
}
