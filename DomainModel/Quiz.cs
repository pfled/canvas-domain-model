namespace DomainModel;

public class Quiz : ISubmittable<List<string>>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Deadline { get; set; }
    public bool IsSubmitted { get; set; }
    public Course Course { get; set; }
    public Student? Student { get; set; }
    public List<string>? SubmissionContent { get; set; }
    public Grade? Grade { get; set; }

    public List<string> QuestionsList { get; set; }

    public Quiz(string title, string description, DateTime deadline, bool isSubmitted, Course course, List<string> questionsList)
    {
        Title = title;
        Description = description;
        Deadline = deadline;
        IsSubmitted = isSubmitted;
        Course = course;
        QuestionsList = questionsList;
    }

    public void Submit(Student student, List<string> submissionContent)
    {
        Student = student;
        SubmissionContent = submissionContent;

        if (DateTime.Compare(DateTime.Now, Deadline) < 0)
        {
            // Some network code
            IsSubmitted = true;
        }
        else
        {
            // reject the submission
        }
    }
}