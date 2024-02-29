namespace Testify_CSharp_Example;

public class Student
{
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string GradeLevel { get; private set; }
    public string Major { get; private set; }
    public int Age { get; private set; }
    public int Id { get; private set; }

    public Student(string name = "", string email = "", string gradeLevel = "",
        string major = "", int age = 0, int id = 0)
    {
        Name = name;
        Email = email;
        GradeLevel = gradeLevel;
        Major = major;
        Age = age;
        Id = id;
    }
}