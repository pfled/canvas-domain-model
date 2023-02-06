namespace DomainModel;

public class Assignment : ISubmittable<string>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Deadline { get; set; }
    public bool IsSubmitted { get; set; }

    public Course Course { get; set; }
    public Student? Student { get; set; }
    public string? SubmissionContent { get; set; }
    public Grade? Grade { get; set; }

    public Assignment(string title, string description, DateTime deadline, bool isSubmitted, Course course)
    {
        Title = title;
        Description = description;
        Deadline = deadline;
        IsSubmitted = isSubmitted;
        Course = course;
    }

    public void Submit(Student student, string submissionContent)
    {
        Student = student;
        SubmissionContent = submissionContent;

        if (DateTime.Compare(DateTime.Now, Deadline) < 0)
        {
            // Some network code
            IsSubmitted = true;
        } else
        {
            // reject the submission
        }
    }
}