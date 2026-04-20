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

        [Required]
        [ForeignKey("Booking")]
        public Guid BookingId { get; set; }

        public BookingEntity Booking { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Amount { get; set; }

        [Required]
        public PaymentStatus Status { get; set; }

        [Required]
        public PaymentMethod PaymentMethod { get; set; }

        [Required]
        [ForeignKey("Transaction")]
        public Guid TransactionId { get; set; }
        public TransactionEntity Transaction { get; set; }
    }
}
