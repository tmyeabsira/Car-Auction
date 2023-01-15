namespace Car_Auction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bids", "BidTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bids", "BidTime");
        }
    }
}
