using AduClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AduClub.Repositories
{
    public class ClubRepository
    {
        private ApplicationDbContext _dbContext;

        public ClubRepository()
        {
            _dbContext = new AduClub.Models.ApplicationDbContext();
        }

        public IEnumerable<Club> GetAllClubs()
        {
            return _dbContext.Clubs;
        }

        //public IEnumerable<Club> GetAllClubsForUser(string sUserName)
        //{
        //    return _dbContext.Clubs.Where(c => c.Users.Any(u => u.UserName == sUserName));
        //}
    }
}