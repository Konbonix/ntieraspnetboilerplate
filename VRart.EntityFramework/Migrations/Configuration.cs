using System.Data.Entity.Migrations;
using VRart.Uploads;

namespace VRart.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<VRart.EntityFramework.VRartDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "VRart";
        }

        protected override void Seed(VRart.EntityFramework.VRartDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
            context.Uploads.AddOrUpdate(
                p => p.Title,
                new Upload { Title = "Chair" },
                new Upload { Title = "City" },
                new Upload { Title = "Mushroom man" },
                new Upload { Title = "Pokemon" }
           );
        }
    }
}