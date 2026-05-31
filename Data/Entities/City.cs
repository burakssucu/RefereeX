using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefereeX.Data.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public virtual ICollection<Referee> Referees { get; set; }
    }
}
