namespace Car_Auction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class caruser1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cars", "user");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "user", c => c.String());
        }
    }
}
