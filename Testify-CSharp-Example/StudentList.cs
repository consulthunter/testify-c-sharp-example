namespace Testify_CSharp_Example;

public class StudentList
{
    // Variables
    private List<Student> Students { get; set; }
    // Methods
    private Student GetStudentInfo(TextReader reader, TextWriter writer)
    {
        writer.WriteLine("Enter the student's name: ");
        string name = (reader.ReadLine()?? String.Empty).Trim();
        
        writer.WriteLine("Enter the student's email: ");
        string email = (reader.ReadLine() ?? String.Empty).Trim();
        
        writer.WriteLine("Enter the student's grade level: ");
        string gradeLevel = (reader.ReadLine() ?? String.Empty).Trim();
        
        writer.WriteLine("Enter the student's major: ");
        string major = (reader.ReadLine() ?? String.Empty).Trim();
        
        writer.WriteLine("Enter the student's age: ");
        int age = 0;
        try
        {
            age = int.Parse(reader.ReadLine() ?? "0");
        }
        catch (FormatException)
        {
            writer.WriteLine("Error parsing student's age.");
        }
        
        writer.WriteLine("Enter the student's ID: ");
        int id = 0;
        try
        {
            id = int.Parse(reader.ReadLine() ?? "0");
        }
        catch (FormatException)
        {
            writer.WriteLine("Error parsing student's ID");
        }

        return new Student(name, email, gradeLevel, major, age, id);
    }

    public void AddStudent(TextReader reader, TextWriter writer)
    {
        Student student = GetStudentInfo(reader, writer);

        foreach (var present in Students)
        {
            if (present.Id == student.Id)
            {
                writer.WriteLine("The student is already present in the list.");
                return;
            }
        }
        
        Students.Add(student);
        writer.WriteLine("The student has been added to the list.");
    }

    public void RemoveStudent(TextReader reader, TextWriter writer)
    {
        Student student = GetStudentInfo(reader, writer);

        foreach (var present in Students)
        {
            if (present.Id == student.Id)
            {
                Students.Remove(student);
                writer.WriteLine("The student has been removed from the list.");
                return;
            }
        }
        
        writer.WriteLine("The student is not in the list.");
    }

    public void Print()
    {
        foreach(Student student in Students)
        {
            Console.WriteLine($"Name: {student.Name}, Email: {student.Email}, " +
                              $"Grade Level: {student.GradeLevel}, Major: {student.Major}, " +
                              $"Age: {student.Age}, ID: {student.Id}");
        }
    }
    // Constructor

    public StudentList()
    {
        Students = new List<Student>();
    }
}