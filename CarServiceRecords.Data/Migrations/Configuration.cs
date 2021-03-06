namespace CarServiceRecords.Data.Migrations
{
    using CarServiceRecords.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<CarServiceRecordsDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CarServiceRecordsDbContext context)
        {
            if (!context.Roles.Any(r => r.Name == "Administrator"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Administrator" };

                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "ServiceOwner"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "ServiceOwner" };

                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "Default"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Default" };

                manager.Create(role);
            }

            if (!context.Users.Any(u => u.UserName == "admin@car.rec"))
            {
                var store = new UserStore<User>(context);
                var manager = new UserManager<User>(store);
                var user = new User { UserName = "admin@car.rec" };

                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "Administrator");
            }

            if (!context.Users.Any(u => u.UserName == "emk33@emk33.com"))
            {
                var store = new UserStore<User>(context);
                var manager = new UserManager<User>(store);
                var user = new User { UserName = "emk33@emk33.com" };

                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "ServiceOwner");
            }

            var mercedes = new CarMake();
            mercedes.Id = 1;
            mercedes.Name = "Mercedes";

            var opel = new CarMake();
            opel.Id = 2;
            opel.Name = "Opel";

            var mercedesModel = new CarModel();
            mercedesModel.Id = 1;
            mercedesModel.Name = "C200";
            mercedesModel.Make = mercedes;

            var opelModel = new CarModel();
            opelModel.Id = 2;
            opelModel.Name = "Corsa";
            opelModel.Make = opel;

            context.CarModels.AddOrUpdate(mercedesModel);
            context.CarModels.AddOrUpdate(opelModel);

            context.SaveChanges();
        }
    }
}
