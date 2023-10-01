namespace deleivry_system.Models
{
    public class Vehicles : BaesModel
    {
        public int VehicleModel { get; set; }
        public int VehicleLicensePlate { get; set; }
        public int DriverId { get; set; }
    }
}
