namespace Car_Auction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateBid : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bids", "BidAmount", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bids", "BidAmount", c => c.Int(nullable: false));
        }
    }
}
