using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefereeX.Data.Entities
{
    public class Rank
    {
        public int Id { get; set; }
        public string RankName { get; set; }
        public virtual ICollection<Referee> Referees { get; set; }
    }
}
