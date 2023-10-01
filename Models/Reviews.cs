
namespace deleivry_system.Models;

    public class Reviews : BaesModel
    {
        public decimal Rating { get; set; }
        public string Comment { get; set; }
        public int TripId { get; set; }

    }

