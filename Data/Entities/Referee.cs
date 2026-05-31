using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefereeX.Data.Entities
{
    public class Referee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Rank_Id { get; set; }
        public int City_Id { get; set; }
        public bool IsActive { get; set; }
        public virtual Rank Rank { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<TrainingAttendance> TrainingAttendances { get; set; }
    }
}
