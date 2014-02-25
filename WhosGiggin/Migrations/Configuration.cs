namespace WhosGiggin.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WhosGiggin.DataContext.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WhosGiggin.DataContext.DatabaseContext context)
        {
           
            context.Venues.AddOrUpdate(v=>v.Name,new Models.VenueModel()
            {
                Name = "Golden Dawn",
                Address = "Cnr Ponsonby Road & Richmond Road",
                City = "Auckland",
                ContactPhone = "09-376-9929",
                Description = "Great venue bar staff great people great entertainment But,The Bouncers need to loose attitude & stop power tripping & also fingering the wrong people for doing nothing but enjoying themselves. ",
                ListedBy = "doriordan",
                Postcode = "1010",
                Region = "Auckland Central",
                WebsiteUrl = "http://www.goldendawn.co.nz",
                PrimaryImageUrl = "http://www.goldendawn.co.nz"
            }, new Models.VenueModel()
            {
                Name = "Vector Arena",
                Address = "42-80 Mahuhu Crescent",
                City = "Auckland",
                ContactPhone = "(09) 358 1250",
                Description = "A world class, indoor, multi-purpose, all weather arena attracting the cream of world sports and entertainment from rock concerts to classical performances, ballet, opera, family shows, netball, tennis, boxing, gymnastics, conferences & exhibitions and more! At its heart is a superb performance space in which we are able to host an audience of over 12,000 people. Vector Arena can also be configured as a theatre or intimate concert venue providing a perfect performance space for smaller audiences. Situated in Auckland, the largest city of the Pacific, Vector Arena is a world class venue for all New Zealanders!",
                ListedBy = "doriordan",
                Postcode = "1010",
                Region = "Auckland Central",
                WebsiteUrl = "http://www.vectorarena.co.nz",
                PrimaryImageUrl = "http://www.vectorarena.co.nz"
            });

            context.SaveChangesWithErrors();
        }
    }
}
