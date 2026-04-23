using System.ComponentModel.DataAnnotations;

namespace CargoConnect.MVC.Client.Models.User
{
    public class UserUpdateModel
    {
        public Guid Id { get; set; }

        [MinLength(2, ErrorMessage = "First name must be at least 2 characters")]
        [MaxLength(50)]
        public string? FirstName { get; set; }

        [MinLength(2, ErrorMessage = "Last name must be at least 2 characters")]
        [MaxLength(50)]
        public string? LastName { get; set; }

        [RegularExpression(@"^[6-9]\d{9}$", ErrorMessage = "Invalid phone number")]
        public string? Phone { get; set; }
    }
}
