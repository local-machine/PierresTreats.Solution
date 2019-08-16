
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PierresTreats.Models
{
    [Table("Treats")]
    public class Treat
    {
        [Key]
        public int TreatId { get; set; }
        public string Description { get; set; }
        // public virtual ApplicationUser User { get; set; }


        public ICollection<FlavorTreat> Flavors { get; }
        public Treat()
        {
            this.Flavors = new HashSet<FlavorTreat>();

        }
    }
}