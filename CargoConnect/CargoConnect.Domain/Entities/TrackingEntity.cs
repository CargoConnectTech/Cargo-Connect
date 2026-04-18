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

        //[Required]
        //public Guid BookingId { get; set; }

        //[ForeignKey("BookingId")]
        //public BookingEntity Booking { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }

        [Required]
        public DateTime Timestamp { get; set; }
    }
}
