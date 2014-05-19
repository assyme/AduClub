using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AduClub.DAL;

namespace AduClub.Models
{
    public class CategoryContextInitializer : DropCreateDatabaseAlways<ClubCentralDBContext>
    {
        protected override void Seed(ClubCentralDBContext context)
        {
            var categories = new List<Category>(){
                new Category() {Name = "Science"},
                new Category() {Name = "Art"},
                new Category() {Name = "Commerce"}
            };

            categories.ForEach(c => context.Categories.Add(c));
            context.Clubs.Add(new Club() { Name = "NodsJs", Description = "Club for Node JS Freaks." });

            context.SaveChanges();
        }
    }
}