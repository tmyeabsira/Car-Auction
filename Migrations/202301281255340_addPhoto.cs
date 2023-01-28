namespace Car_Auction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPhoto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "photo", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "photo");
        }
    }
}
