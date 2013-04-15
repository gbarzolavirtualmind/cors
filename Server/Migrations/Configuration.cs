namespace Server.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using Model;

    internal sealed class Configuration : DbMigrationsConfiguration<ServerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Model.ServerContext context)
        {
            var initialTasks = new List<Task>() { 
                new Task { Name= "Read about cours" },
                new Task { Name = "create the example" }
            };

            context.Tasks.AddOrUpdate(initialTasks.ToArray());


        }
    }
}
