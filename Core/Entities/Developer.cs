namespace Core.Entities
{
public class Developer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int YearsOfExperience { get; set; }
    public decimal EstimatedIncome { get; set; }
    public Address Address { get; set; }
}
}