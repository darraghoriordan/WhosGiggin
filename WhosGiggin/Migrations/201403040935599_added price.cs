namespace WhosGiggin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedprice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "Price");
        }
    }
}
