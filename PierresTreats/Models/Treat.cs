
using System.Collections.Generic;
using PierresTreats.Models;

namespace PierresTreats.Models
{
    public class Treat
    {
        public Treat()
        {
            this.Flavors = new HashSet<FlavorTreat>();

        }
        public int TreatId { get; set; }
        public string Description { get; set; }

        public ICollection<FlavorTreat> Flavors { get; }
    }
}