using EDAPacman.Model;

namespace EDAPacman.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EDAPacman.Plumbing.GameContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EDAPacman.Plumbing.GameContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Mazes.AddOrUpdate(
                m=>m.Name,
                new Maze { Name = "default", Layout =
               "====================" +
               "=..................=" +
               "=.================.=" +
               "=.====.............=" +
               "=.====.======.====.=" +
               "=.====.======.====.=" +
               "=.====........====.=" +
               "=...==.======.==...=" +
               "===.==.======.==.===" +
               "===.==.======.==.===" +
               "=..................=" +
               "=.====.===.==.====.=" +
               "=.====.===.==.====.=" +
               "=......===.==......=" +
               "=.====.===.==.====.=" +
               "=.====.==.===.====.=" +
               "=.====.==.===.====.=" +
               "=.==......===...==.=" +
               "=.==.====.=====.==.=" +
               "=....====.=====....=" +
               "====================",

                Player = new Player(1,1)
            }
                );
        }
    }
}
