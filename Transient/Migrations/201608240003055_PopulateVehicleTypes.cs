namespace Transient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateVehicleTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO VehicleTypes (Name) VALUES ('Coupe')");
            Sql("INSERT INTO VehicleTypes (Name) VALUES ('Sedan')");
            Sql("INSERT INTO VehicleTypes (Name) VALUES ('Crossover')");
            Sql("INSERT INTO VehicleTypes (Name) VALUES ('SUV')");
            Sql("INSERT INTO VehicleTypes (Name) VALUES ('Van')");
            Sql("INSERT INTO VehicleTypes (Name) VALUES ('Truck')");
        }
        
        public override void Down()
        {
        }
    }
}
