namespace Project_Bike_Hikes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FieldToProperty : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rides",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country = c.Int(nullable: false),
                        BestTime = c.String(),
                        Map = c.String(),
                        Score = c.Int(nullable: false),
                        Size = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rides");
        }
    }
}
