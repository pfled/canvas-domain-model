namespace DomainModel;
public class Student : User
{
    public List<Course> CoursesEnrolled { get; set; } = new List<Course>();
    public List<Assignment> Assignments { get; set; } = new List<Assignment>();
    public List<Grade> Grades { get; set; } = new List<Grade>();

    public Student(string firstName, string lastName, int id, string email, string password) : base(firstName, lastName, id, email, password)
    {
    }

    public void EnrollInCourse(Course course)
    {
        CoursesEnrolled.Add(course);
    }

    public void DropCourse(Course course)
    {
        CoursesEnrolled.Remove(course);
    }

    public void SubmitAssignment(Assignment assignment, string submissionContent)
    {
        assignment.Submit(this, submissionContent);
    }

    public void SubmitQuiz(Quiz quiz, List<string> submissionContent)
    {
        quiz.Submit(this, submissionContent);
    }

    public void SubmitExam(Exam exam, List<string> submissionContent)
    {
        exam.Submit(this, submissionContent);
    }
}
