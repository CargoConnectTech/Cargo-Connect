using CargoConnect.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoConnect.Domain.Entities
{
    public class PaymentEntity
    {
        [Key]
        public Guid Id { get; set; }

        //[Required]
        //public Guid BookingId { get; set; }

        //[ForeignKey(nameof(BookingId))]
        //public Booking Booking { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        [Required]
        public PaymentStatusEnum Status { get; set; }

        [Required]
        public PaymentMethodEnum PaymentMethod { get; set; }

        public string? TransactionId { get; set; }
    }
}
