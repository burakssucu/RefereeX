using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RefereeX.Data.Contexts;
using RefereeX.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace RefereeX.Services
{
    public class RefereeService
    {
        public void Create(Referee referee)
        {
            using (var context = new RefereXDbContext())
            {
                context.Referees.Add(referee);
                context.SaveChanges();
            }
        }

        public List<Referee> GetAll()
        {
            using (var context = new RefereXDbContext())
            {
                return context.Referees
                    .Include(r => r.Rank)
                    .Include(r => r.City)
                    .ToList();
            }
        }

        public void Update(Referee referee)
        {
            using (var context = new RefereXDbContext())
            {
                var existing = context.Referees.Find(referee.Id);
                if (existing != null)
                {
                    existing.FirstName = referee.FirstName;
                    existing.LastName = referee.LastName;
                    existing.Rank_Id = referee.Rank_Id;
                    existing.City_Id = referee.City_Id;
                    existing.IsActive = referee.IsActive;
                    context.SaveChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (var context = new RefereXDbContext())
            {
                var referee = context.Referees.Find(id);
                if (referee != null)
                {
                    context.Referees.Remove(referee);
                    context.SaveChanges();
                }
            }
        }
    }
}
