namespace DomainModel;

public class Message
{

    public int Id { get; set; }
    public User Sender { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public DateTime SentTime { get; set; }

    public Message(int id, User sender, string subject, string body, DateTime sentTime)
    {
        Id = id;
        Sender = sender;
        Subject = subject;
        Body = body;
        SentTime = sentTime;
    }
}