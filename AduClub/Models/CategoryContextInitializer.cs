using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AduClub.Models
{
    public class CategoryContextInitializer : DropCreateDatabaseAlways<CategoryDBContext>
    {
        protected override void Seed(CategoryDBContext context)
        {
            var categories = new List<Category>(){
                new Category() {Name = "Science"},
                new Category() {Name = "Art"},
                new Category() {Name = "Commerce"}
            };

            categories.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();
        }
    }
}