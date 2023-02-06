namespace DomainModel;

public class Instructor : User
{
    public List<Course> CoursesTaught { get; set; } = new List<Course>();

    public Instructor(string firstName, string lastName, int id, string email, string password) : base(firstName, lastName, id, email, password)
    {
    }

    public void CreateModule(Course course, Module module)
    {

    }

    public void CreateAssignment(Course course, Assignment assignment)
    {

    }

    public void GradeAssignment(Assignment assignment)
    {

    }

    public void MakeAnnouncement(Course course, Announcement announcement)
    {

    }

    public void AssignFinalGrade(Course course, Student student)
    {

    }

    public void UploadCanvasFile(Course course, CanvasFile canvasFile)
    {

    }

    public void DeleteCanvasFile(Course course, CanvasFile canvasFile)
    {

    }
}