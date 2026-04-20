using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoConnect.Domain.Entities
{
    public class TrackingEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey("Booking")]

        public Guid BookingId { get; set; }

        public BookingEntity Booking { get; set; }

        [Required]
        [Column(TypeName = "float")]
        public double Latitude { get; set; }

        [Required]
        [Column(TypeName ="float")]
        public double Longitude { get; set; }
        [Required]
        public DateTime Timestamp { get; set; }
    }
}
