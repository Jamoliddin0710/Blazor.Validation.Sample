using System.ComponentModel.DataAnnotations;

namespace Task2.Model.DTO;

public class PasportSeriaDTO
{
    [Required] public string Seria { get; set; }
    [Required] public string Number { get; set; }
}