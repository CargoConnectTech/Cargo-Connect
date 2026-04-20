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
    [Table("Transactions")]
    public class TransactionEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey("Booking")]
        public Guid BookingId { get; set; }
        public BookingEntity Booking { get; set; }
        
        [Required]
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        public UserEntity User { get; set; }

        [Required]
        [ForeignKey("Driver")]
        public Guid DriverId { get; set; }
        public DriverEntity Driver { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Amount { get; set; }

        public TransactionStatus Status { get; set; }

        public TransactionType Type { get; set; }

        [Required]
        [MaxLength(128)]
        public string PaymentGateway { get; private set; } // Razorpay, Stripe

        [Required]
        [MaxLength(128)]
        public string GatewayTransactionId { get; private set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
