using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoConnect.Common.Enums;

namespace CargoConnect.Domain.Entities
{
    public class UserEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName ="varchar(255)")]
        [Required]
        public string FirstName { get; set; }

        [Column(TypeName = "varchar(255)")]
        [Required]
        public string LastName { get; set; }

        [Column(TypeName = "varchar(255)")]
        [Required]
        public string Email { get; set; }

        [Column(TypeName = "varchar(255)")]
        [Required]
        public string Phone { get; set; }

        [Column(TypeName = "varchar(255)")]
        [Required]
        public string Password { get; set; }

        public Roles Role { get; set; } = Roles.User;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}
