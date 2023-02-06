namespace DomainModel;

public class Grade
{
    public int Percentage { get; set; }
    public string Letter { get; set; }

    public Grade(int percentage, string letter)
    {
        Percentage = percentage;
        Letter = letter;
    }
}