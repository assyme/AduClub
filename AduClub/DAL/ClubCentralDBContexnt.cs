using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AduClub.Models;
namespace AduClub.DAL
{
    public class ClubCentralDBContext : DbContext
    {
        public ClubCentralDBContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<Club> Clubs { get; set; }
        public DbSet<Category> Categories { get; set; }
        
    }
}