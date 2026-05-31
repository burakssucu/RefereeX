using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefereeX.Data.Entities
{
    public class TrainingAttendance
    {
        public int Id { get; set; }
        public int Referee_Id { get; set; }
        public int Training_Id { get; set; }
        public DateTime IsSignedTime { get; set; }
        public bool IsPresent { get; set; }
        public virtual Referee Referee { get; set; }
        public virtual Training Training { get; set; }
    }
}
