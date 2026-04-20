using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoConnect.Common.Enums;

namespace CargoConnect.Domain.Entities
{
    [Table("Bookings")]
    public class BookingEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public UserEntity User { get; set; }

        [Required]
        [ForeignKey("Driver")]
        public Guid DriverId { get; set; }
        public DriverEntity Driver { get; set; }

        [Required]
        [Column(TypeName ="varchar(255)")]
        public string PickupLocation {  get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string DropLocation {  get; set; }

        [Required]
        public BookingStatus Status { get; set; } = BookingStatus.Pending;

        [Required]
        [Column(TypeName ="float")]
        public double Distance { get; set; }

        [Required]
        [Column(TypeName ="decimal(10,2)")]
        public decimal Price { get; set; }

        [Column(TypeName ="datetime")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
