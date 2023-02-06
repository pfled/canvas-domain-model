namespace DomainModel;

public interface ISubmittable<T>
{
    string Title { get; set; }
    string Description { get; set; }
    DateTime Deadline { get; set; }
    bool IsSubmitted { get; set; }
    Course Course { get; set; }
    Student? Student { get; set; }
    T? SubmissionContent { get; set; }
    Grade? Grade { get; set; }

    void Submit(Student student, T submissionContent);
}
