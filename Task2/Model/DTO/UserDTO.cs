using System.ComponentModel.DataAnnotations;
using Task2.Model.Enum;

namespace Task2.Model.DTO
{
    public class UserDTO
    {
        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }

        public string MiddleName { get; set; }
        public EGender Gender { get; set; }
        [Required] public string PINFL { get; set; }
        [Required] public string PassportSeriaNumber { get; set; }
        [Required] public DateTime? BornDate { get; set; }
        public string GivenBy { get; set; }
        public DateTime? GivenDate { get; set; }
        public string Country { get; set; }
        [Required] public string Region { get; set; }
        [Required] public string City { get; set; }
        public ECitizenship Citizenship { get; set; }
        [Required] public string Adress { get; set; }

        [Required]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string Contact { get; set; }

        public string Email { get; set; }
    }
}