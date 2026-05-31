using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefereeX.Data.Contexts;
using RefereeX.Data.Entities;

namespace RefereeX.Services
{
    public class LookupService
    {
        public List<Rank> GetRanks()
        {
            using (var context = new RefereXDbContext())
            {
                return context.Ranks.ToList();
            }
        }

        public List<City> GetCities()
        {
            using (var context = new RefereXDbContext())
            {
                return context.Cities.OrderBy(c => c.CityName).ToList();
            }
        }
    }
}
