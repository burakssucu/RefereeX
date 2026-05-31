using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RefereeX.Data.Contexts;
using RefereeX.Data.Entities;

namespace RefereeX.Services
{
    public class AttendanceService
    {
        public void Create(TrainingAttendance attendance)
        {
            using (var context = new RefereXDbContext())
            {
                context.TrainingAttendances.Add(attendance);
                context.SaveChanges();
            }
        }

        public List<TrainingAttendance> GetAll()
        {
            using (var context = new RefereXDbContext())
            {
                return context.TrainingAttendances
                    .Include(ta => ta.Referee)
                    .Include(ta => ta.Training)
                    .ToList();
            }
        }

        public void Delete(int id)
        {
            using (var context = new RefereXDbContext())
            {
                var attendance = context.TrainingAttendances.Find(id);
                if (attendance != null)
                {
                    context.TrainingAttendances.Remove(attendance);
                    context.SaveChanges();
                }
            }
        }

        public int GetTotalAttendanceCountByRank(string rankName)
        {
            using (var context = new RefereXDbContext())
            {
                return context.TrainingAttendances
                    .Where(ta => ta.Referee.Rank.RankName == rankName && ta.IsPresent == true)
                    .Count();
            }
        }

        public List<string> GetPerfectAttendanceRefereeNames()
        {
            using (var context = new RefereXDbContext())
            {
                return context.TrainingAttendances
                    .Where(ta => ta.IsPresent == true)
                    .Select(ta => ta.Referee.FirstName + " " + ta.Referee.LastName)
                    .Distinct()
                    .ToList();
            }
        }
    }
}
