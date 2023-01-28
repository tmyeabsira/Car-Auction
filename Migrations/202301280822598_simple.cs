namespace Car_Auction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class simple : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cars", "User_userName", "dbo.Users");
            DropForeignKey("dbo.Bids", "carId", "dbo.Cars");
            DropIndex("dbo.Bids", new[] { "carId" });
            DropIndex("dbo.Cars", new[] { "User_userName" });
            AddColumn("dbo.Cars", "carOwner", c => c.String());
            DropColumn("dbo.Cars", "User_userName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "User_userName", c => c.String(maxLength: 128));
            DropColumn("dbo.Cars", "carOwner");
            CreateIndex("dbo.Cars", "User_userName");
            CreateIndex("dbo.Bids", "carId");
            AddForeignKey("dbo.Bids", "carId", "dbo.Cars", "carId", cascadeDelete: true);
            AddForeignKey("dbo.Cars", "User_userName", "dbo.Users", "userName");
        }
    }
}
