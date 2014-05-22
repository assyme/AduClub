using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AduClub.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Club> Clubs { get; set; }
    }
}