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
        public DateTime CreatedOn { get; set; }
        
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }
    } 
}