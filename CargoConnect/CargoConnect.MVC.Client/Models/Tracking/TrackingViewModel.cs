namespace CargoConnect.MVC.Client.Models.Tracking
{
    public class TrackingViewModel
    {
        public Guid Id { get; set; }

        public Guid BookingId { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
