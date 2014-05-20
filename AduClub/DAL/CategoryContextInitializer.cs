using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AduClub.DAL;
using AduClub.Models;

namespace AduClub.DAL
{
    public class ClubCentralContextInitializer : DropCreateDatabaseAlways<ClubCentralDBContext>
    {
        protected override void Seed(ClubCentralDBContext context)
        {
            var categories = new List<AduClub.Models.Category>(){
                new AduClub.Models.Category() {Name = "Science"},
                new AduClub.Models.Category() {Name = "Art"},
                new AduClub.Models.Category() {Name = "Commerce"}
            };

            categories.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();

            var clubs = new List<Club>();
            var clubNode = new Club() { Name = "NodesJs", Description = "Club for Node JS Freaks.", CreatedOn = DateTime.Now };
            clubNode.Categories = context.Categories.ToList();
            
            context.Clubs.Add(clubNode);

            context.SaveChanges();
        }
    }
}