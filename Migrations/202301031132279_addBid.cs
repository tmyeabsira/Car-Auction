namespace Car_Auction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBid : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bids",
                c => new
                    {
                        BidId = c.Int(nullable: false, identity: true),
                        OwnerName = c.String(),
                        Bidder = c.String(),
                        Car = c.String(),
                        BidAmount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BidId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bids");
        }
    }
}
