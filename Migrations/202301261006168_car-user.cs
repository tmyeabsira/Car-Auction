namespace Car_Auction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class caruser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "user", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "user");
        }
    }
}
