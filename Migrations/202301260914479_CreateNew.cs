namespace Car_Auction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateNew : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bids",
                c => new
                    {
                        BidId = c.Int(nullable: false, identity: true),
                        OwnerName = c.String(),
                        BidderName = c.String(),
                        carId = c.Int(nullable: false),
                        BidAmount = c.Decimal(nullable: false, storeType: "money"),
                        BidTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BidId)
                .ForeignKey("dbo.Cars", t => t.carId, cascadeDelete: true)
                .Index(t => t.carId);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        carId = c.Int(nullable: false, identity: true),
                        carName = c.String(),
                        carModel = c.Int(nullable: false),
                        noOfSeats = c.Int(nullable: false),
                        startBid = c.Decimal(nullable: false, storeType: "money"),
                        User_userName = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.carId)
                .ForeignKey("dbo.Users", t => t.User_userName)
                .Index(t => t.User_userName);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        userName = c.String(nullable: false, maxLength: 128),
                        firstName = c.String(),
                        lastName = c.String(),
                        Email = c.String(),
                        userPassword = c.String(),
                        balance = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.userName);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bids", "carId", "dbo.Cars");
            DropForeignKey("dbo.Cars", "User_userName", "dbo.Users");
            DropIndex("dbo.Cars", new[] { "User_userName" });
            DropIndex("dbo.Bids", new[] { "carId" });
            DropTable("dbo.Users");
            DropTable("dbo.Cars");
            DropTable("dbo.Bids");
        }
    }
}
