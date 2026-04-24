using System.ComponentModel.DataAnnotations;

namespace CargoConnect.MVC.Client.Models.Tracking
{
    public class TrackingCreateModel
    {


        [Required]
        public Guid BookingId { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }

        [Required]
        public DateTime Timestamp { get; set; }
    }
}
   
