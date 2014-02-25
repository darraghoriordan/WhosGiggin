namespace WhosGiggin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "Venue_Id", "dbo.Venues");
            DropIndex("dbo.Events", new[] { "Venue_Id" });
            AlterColumn("dbo.Events", "Title", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Events", "Restrictions", c => c.String(maxLength: 500));
            AlterColumn("dbo.Events", "ListedBy", c => c.String(maxLength: 300));
            AlterColumn("dbo.Events", "Description", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Events", "Venue_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Venues", "Name", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Venues", "City", c => c.String(maxLength: 200));
            AlterColumn("dbo.Venues", "Region", c => c.String(maxLength: 200));
            AlterColumn("dbo.Venues", "Address", c => c.String(maxLength: 200));
            AlterColumn("dbo.Venues", "ContactPhone", c => c.String(nullable: false));
            AlterColumn("dbo.Venues", "Description", c => c.String(nullable: false, maxLength: 1000));
            AlterColumn("dbo.Venues", "PrimaryImageUrl", c => c.String(nullable: false));
            CreateIndex("dbo.Events", "Venue_Id");
            AddForeignKey("dbo.Events", "Venue_Id", "dbo.Venues", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "Venue_Id", "dbo.Venues");
            DropIndex("dbo.Events", new[] { "Venue_Id" });
            AlterColumn("dbo.Venues", "PrimaryImageUrl", c => c.String());
            AlterColumn("dbo.Venues", "Description", c => c.String());
            AlterColumn("dbo.Venues", "ContactPhone", c => c.String());
            AlterColumn("dbo.Venues", "Address", c => c.String());
            AlterColumn("dbo.Venues", "Region", c => c.String());
            AlterColumn("dbo.Venues", "City", c => c.String());
            AlterColumn("dbo.Venues", "Name", c => c.String());
            AlterColumn("dbo.Events", "Venue_Id", c => c.Int());
            AlterColumn("dbo.Events", "Description", c => c.String());
            AlterColumn("dbo.Events", "ListedBy", c => c.String());
            AlterColumn("dbo.Events", "Restrictions", c => c.String());
            AlterColumn("dbo.Events", "Title", c => c.String());
            CreateIndex("dbo.Events", "Venue_Id");
            AddForeignKey("dbo.Events", "Venue_Id", "dbo.Venues", "Id");
        }
    }
}
