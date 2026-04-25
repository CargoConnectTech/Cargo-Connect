using System.ComponentModel.DataAnnotations;

namespace CargoConnect.MVC.Client.Models.Transaction
{
    public class TransactionCreateModel
    {

        [Required(ErrorMessage = "BookingId is required")]
        public Guid BookingId { get; set; }

        [Required(ErrorMessage = "Latitude is required")]
        [Range(-90, 90, ErrorMessage = "Latitude must be between -90 and 90")]
        public double? Latitude { get; set; }

        [Required(ErrorMessage = "Longitude is required")]
        [Range(-180, 180, ErrorMessage = "Longitude must be between -180 and 180")]
        public double? Longitude { get; set; }

        [Required(ErrorMessage = "Timestamp is required")]
        public DateTime? Timestamp { get; set; }
    }
}
