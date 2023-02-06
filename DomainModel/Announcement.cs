namespace DomainModel;

public class Announcement
{
    public string Title { get; set; }
    public string Content { get; set; }

    public Announcement(string title, string content)
    {
        Title = title;
        Content = content;
    }
}