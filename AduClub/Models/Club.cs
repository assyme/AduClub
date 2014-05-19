using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AduClub.Models
{
    public class Club
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public virtual ICollection<Category> Categories { get; set; }
    }

    public class ClubDBContext : DbContext
    {
        public ClubDBContext(): base("DefaultConnection")
        {
            
        }
        public DbSet<Club> Clubs { get; set; }
    } 
}