
namespace deleivry_system.Models;

public class Trips : BaesModel
{
    public string StartLocation { get; set; }
    public string EndLocation { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int DriverId { get; set; }
    public List<Passengers> Passengers { get; set; }

    public Trips StartTrip()
    {
        return new Trips( ) { Id = 1, StartLocation = "a", EndLocation = "b" };

    }
}

