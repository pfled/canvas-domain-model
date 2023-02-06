namespace DomainModel;

public class Inbox
{
    public List<Message> Messages { get; set; }

    public Inbox(List<Message> messages)
    {
        Messages = messages;
    }
}