namespace Task2.Model.DTO;

public class PersonDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Patronymic { get; set; }
    public DateTime? BirthDate { get; set; }
    public string Age { get; set; }
    public PasportSeriaDTO PasportSeria { get; set; }
    public string PNFL { get; set; }
}