using NUnit.Framework;
namespace Testify_CSharp_Example.Tests;

[TestFixture]
[TestOf(typeof(Student))]
public class StudentTest
{
    private readonly string Name = "John";
    private readonly string Email = "bob@email.com";
    private readonly string GradeLevel = "Freshman";
    private readonly string Major = "Computer Science";
    private readonly int Age = 18;
    private readonly int Id = 12345;
    private Student CreateStudentWithOptions()
    {
        return new Student(Name, Email, GradeLevel, Major, Age, Id);
    }
    
    private Student CreateStudent()
    {
        return new Student();
    }

    [Test]
    public void TestStudentConstructorWithOptions()
    {
        // Arrange
        Student student = CreateStudentWithOptions();
        
        // Act
        string actualName = student.Name;
        string actualEmail = student.Email;
        string actualGradeLevel = student.GradeLevel;
        string actualMajor = student.Major;
        int actualAge = student.Age;
        int actualId = student.Id;
        
        // Assert
        Assert.That(actualName.Equals(Name));
        Assert.That(actualEmail.Equals(Email));
        Assert.That(actualGradeLevel.Equals(GradeLevel));
        Assert.That(actualMajor.Equals(Major));
        Assert.That(actualAge.Equals(Age));
        Assert.That(actualId.Equals(Id));
    }
    
    [Test]
    public void TestStudentConstructor()
    {
        // Arrange
        const string expectString = "";
        const int expectInt = 0;
        Student student = CreateStudent();
        
        // Act
        string actualName = student.Name;
        string actualEmail = student.Email;
        string actualGradeLevel = student.GradeLevel;
        string actualMajor = student.Major;
        int actualAge = student.Age;
        int actualId = student.Id;
        
        // Assert
        Assert.That(actualName.Equals(expectString));
        Assert.That(actualEmail.Equals(expectString));
        Assert.That(actualGradeLevel.Equals(expectString));
        Assert.That(actualMajor.Equals(expectString));
        Assert.That(actualAge.Equals(expectInt));
        Assert.That(actualId.Equals(expectInt));
    }
}