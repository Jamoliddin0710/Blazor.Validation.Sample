using System.ComponentModel.DataAnnotations;

namespace Task2.Model.Entity;

public class User
{
    [Required]
    [StringLength( 10, ErrorMessage = "Name is too long." )]
    public string Name { get; set; }
    
    public string Email { get; set; }

    [Required( ErrorMessage = "Password is required" )]
    [StringLength( 8, ErrorMessage = "Must be between 5 and 8 characters", MinimumLength = 5 )]
    [DataType( DataType.Password )]
    public string Password { get; set; }

    [Required( ErrorMessage = "Confirm Password is required" )]
    [StringLength( 8, ErrorMessage = "Must be between 5 and 8 characters", MinimumLength = 5 )]
    [DataType( DataType.Password )]
    [Compare( "Password" )]
    public string ConfirmPassword { get; set; }

    [Required]
    public string Title { get; set; }

    [Range( typeof( bool ), "true", "true", ErrorMessage = "You gotta tick the box!" )]
    public bool TermsAndConditions { get; set; }
}