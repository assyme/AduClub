using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Data.Entity;

namespace AduClub.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Club> Clubs {get;set;}
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //create a many to many table
            modelBuilder.Entity<Club>()
                .HasMany(x => x.Categories)
                .WithMany(x => x.Clubs)
                .Map(mc =>
                {
                    mc.ToTable("ClubCategories");
                    mc.MapLeftKey("Club_Id");
                    mc.MapRightKey("Category_Id");
                });

            modelBuilder.Entity<Club>()
                .HasMany(x => x.Users)
                .WithMany(x => x.Clubs)
                .Map(mc =>
                {
                    mc.ToTable("ClubUsers");
                    mc.MapLeftKey("Club_Id");
                    mc.MapRightKey("User_Id");

                });
        }


        public DbSet<Club> Clubs { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}