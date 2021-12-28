namespace PlcFxUa.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PlcFxUa.MBase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "PlcFxUa.MBase";
        }

        protected override void Seed(PlcFxUa.MBase context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
