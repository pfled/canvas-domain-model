namespace DomainModel;

public class CanvasFile
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Extension { get; set; }
    public User Uploader { get; set; }

    public CanvasFile(int id, string name, string extension, User uploader)
    {
        Id = id;
        Name = name;
        Extension = extension;
        Uploader = uploader;
    }
}