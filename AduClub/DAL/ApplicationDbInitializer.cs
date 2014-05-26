using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AduClub.DAL;
using AduClub.Models;
using Devtalk.EF.CodeFirst;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AduClub.DAL
{
    public class ApplicationContextInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {

        protected override void Seed(ApplicationDbContext context)
        {

            InitIdentityTables(context);
            
            var categories = new List<AduClub.Models.Category>(){
                new AduClub.Models.Category() {Name = "Science"},
                new AduClub.Models.Category() {Name = "Art"},
                new AduClub.Models.Category() {Name = "Commerce"}
            };

            categories.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();

            var clubs = new List<Club>();
<<<<<<< HEAD
            var clubNode = new Club() { Name = "Football", Description = "Club for Football Freaks.", CreatedOn = DateTime.Now };
=======
            var clubNode = new Club() { Name = "Football", Description = "Club for Football fans.", CreatedOn = DateTime.Now };
>>>>>>> c0e0bdce8aa1f85652c6d66481d00742cb711f19
            clubNode.Categories = context.Categories.ToList();
            clubNode.ImagePath = "/Images/football.jpg";
            context.Clubs.Add(clubNode);

            var clubPhoto = new Club() { Name = "Photography Club", Description = "Club for camera people", CreatedOn = DateTime.Now.AddDays(-1), ImagePath = "/Images/camera.jpg" };
            clubPhoto.Categories = context.Categories.Take(1).ToList();
            context.Clubs.Add(clubPhoto);
            context.SaveChanges();

            base.Seed(context);
        }

        private void InitIdentityTables(ApplicationDbContext context)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            string name = "Admin";
            string password = "adnan123";

            if (!roleManager.RoleExists(name))
            {
                var roleResult = roleManager.Create(new IdentityRole(name));
            }

            if (!roleManager.RoleExists("user"))
            {
                var roleResult = roleManager.Create(new IdentityRole("user"));
            }

            var adminUser = new ApplicationUser();
            adminUser.UserName = name;
            var adminResult = userManager.Create(adminUser, password);

            if (adminResult.Succeeded)
            {
                var result = userManager.AddToRole(adminUser.Id, name);
            }
        }
    }

}