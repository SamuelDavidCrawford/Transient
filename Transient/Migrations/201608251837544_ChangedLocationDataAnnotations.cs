namespace Transient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedLocationDataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Locations", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Locations", "Address", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Locations", "Address", c => c.String());
            AlterColumn("dbo.Locations", "Name", c => c.String());
        }
    }
}
