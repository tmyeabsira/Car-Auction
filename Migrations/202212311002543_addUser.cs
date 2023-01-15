namespace Car_Auction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        carId = c.Int(nullable: false, identity: true),
                        carName = c.String(),
                        carModel = c.String(),
                        noOfSeats = c.String(),
                        startBid = c.Single(nullable: false),
                        carOwner = c.String(),
                    })
                .PrimaryKey(t => t.carId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        userId = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        Email = c.String(),
                        userName = c.String(),
                        userPassword = c.String(),
                        balance = c.Single(nullable: false),
                        Created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.userId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Cars");
        }
    }
}
