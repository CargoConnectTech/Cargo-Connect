using CargoConnect.Common.Enums;
namespace CargoConnect.MVC.Client.Models.User
{
    public class UserViewModel
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }

        public Roles Role { get; set; }
    }
}
