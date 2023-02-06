namespace DomainModel;

public class Course
{
    public string Name { get; set; }
    public int Id { get; set; }
    public List<Student> StudentsEnrolled { get; set; }
    public Instructor Instructor { get; set; }
    public List<Module> Modules { get; set; }
    public List<Assignment> Assignments { get; set; }
    public List<Quiz> Quizzes { get; set; }
    public List<Exam> Exams { get; set; }
    public List<CanvasFile> Files { get; set; }


    public Course(string name, int id, List<Student> studentsEnrolled, Instructor instructor)
    {
        Name = name;
        Id = id;
        StudentsEnrolled = studentsEnrolled;
        Instructor = instructor;
    }

    public void AddStudent(Student student)
    {
        StudentsEnrolled.Add(student);
    }

    public void RemoveStudent(Student student)
    {
        StudentsEnrolled.Remove(student);
    }
}