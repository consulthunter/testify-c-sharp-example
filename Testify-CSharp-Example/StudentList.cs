namespace Testify_CSharp_Example;

public class StudentList
{
    // Variables
    private List<Student> Students { get; set; }
    // Methods
    private Student GetStudentInfo()
    {
        Console.WriteLine("Enter the student's name: ");
        string name = Console.ReadLine() ?? String.Empty;
        
        Console.WriteLine("Enter the student's email: ");
        string email = Console.ReadLine() ?? String.Empty;
        
        Console.WriteLine("Enter the student's grade level: ");
        string gradeLevel = Console.ReadLine() ?? String.Empty;
        
        Console.WriteLine("Enter the student's major: ");
        string major = Console.ReadLine() ?? String.Empty;
        
        Console.WriteLine("Enter the student's age: ");
        int age = 0;
        try
        {
            age = int.Parse(Console.ReadLine() ?? "0");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error parsing student's age.");
        }
        
        Console.WriteLine("Enter the student's ID: ");
        int id = 0;
        try
        {
            id = int.Parse(Console.ReadLine() ?? "0");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error parsing student's ID");
        }

        return new Student(name, email, gradeLevel, major, age, id);
    }

    public void AddStudent()
    {
        Student student = GetStudentInfo();

        if (Students.Contains(student))
        {
            Console.WriteLine("The student is already present in the list.");
        }
        else
        {
            Students.Add(student);
            Console.WriteLine("The student has been added to the list.");
        }
    }

    public void RemoveStudent()
    {
        Student student = GetStudentInfo();
        if (!Students.Contains(student))
        {
            Students.Remove(student);
            Console.WriteLine("Student has been removed from the list.");
        }
        else
        {
            Console.WriteLine("The student is not in the list.");
        }
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