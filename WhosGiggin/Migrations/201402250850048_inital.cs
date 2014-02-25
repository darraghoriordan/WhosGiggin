namespace WhosGiggin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inital : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        FinishDate = c.DateTime(nullable: false),
                        Restrictions = c.String(),
                        WebsiteUrl = c.String(),
                        ListedBy = c.String(),
                        Description = c.String(),
                        PrimaryImageUrl = c.String(),
                        Venue_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Venues", t => t.Venue_Id)
                .Index(t => t.Venue_Id);
            
            CreateTable(
                "dbo.Venues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                        Region = c.String(),
                        Address = c.String(),
                        Postcode = c.String(),
                        ContactPhone = c.String(),
                        WebsiteUrl = c.String(),
                        Description = c.String(),
                        PrimaryImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserProfile",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "Venue_Id", "dbo.Venues");
            DropIndex("dbo.Events", new[] { "Venue_Id" });
            DropTable("dbo.UserProfile");
            DropTable("dbo.Venues");
            DropTable("dbo.Events");
        }
    }
}
