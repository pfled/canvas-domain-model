namespace DomainModel;

public class User
{

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public Inbox Inbox { get; set; }

    public User(string firstName, string lastName, int id, string email, string password)
    {
        FirstName = firstName;
        LastName = lastName;
        Id = id;
        Email = email;
        Password = password;
    }

    public void SendMessage(User recipient, string subject, string body)
    {
        // Some network code
    }
}