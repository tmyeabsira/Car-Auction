namespace Car_Auction.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUser1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Created");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Created", c => c.DateTime(nullable: false));
        }
    }
}
