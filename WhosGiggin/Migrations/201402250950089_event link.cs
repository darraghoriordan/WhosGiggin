namespace WhosGiggin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eventlink : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Events", name: "Venue_Id", newName: "VenueId");
            AddColumn("dbo.Venues", "ListedBy", c => c.String(maxLength: 300));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Venues", "ListedBy");
            RenameColumn(table: "dbo.Events", name: "VenueId", newName: "Venue_Id");
        }
    }
}
