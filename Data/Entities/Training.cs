using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefereeX.Data.Entities
{
    public class Training
    {
        public int Id { get; set; }
        public DateTime TrainingDate { get; set; }
        public string Location { get; set; }
        public virtual ICollection<TrainingAttendance> TrainingAttendances { get; set; }
    }
}
