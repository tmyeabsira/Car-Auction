namespace Car_Auction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "carModel", c => c.Int(nullable: false));
            AlterColumn("dbo.Cars", "noOfSeats", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "noOfSeats", c => c.String());
            AlterColumn("dbo.Cars", "carModel", c => c.String());
        }
    }
}
