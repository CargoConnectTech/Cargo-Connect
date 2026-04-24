using CargoConnect.Common.Enums;
using CargoConnect.Domain.Entities;

namespace CargoConnect.MVC.Client.Models.Booking
{
    public class BookingViewModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public UserEntity? User { get; set; }

        public Guid DriverId { get; set; }
        public DriverEntity? Driver { get; set; }
        public string PickupLocation { get; set; }
        public string DropLocation { get; set; }
        public BookingStatus Status { get; set; } = BookingStatus.Pending;
        public double Distance { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
