namespace PierresTreats.Models
{
    public class Treat
    {
        public int TreatId { get; set; }
        public string Description { get; set; }

        public int FlavorId { get; set; }
        public virtual Flavor Flavor { get; set; }
    }
}