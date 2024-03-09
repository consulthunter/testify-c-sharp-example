using System;
using System.IO;
using JetBrains.Annotations;
using Xunit;

namespace Testify_CSharp_Example.Tests;

[TestSubject(typeof(StudentList))]
public class StudentListTest
{
    private const string Input = "John\n bob@email.com\n Freshman\n Computer Science\n 18\n 12345\n";
    private TextReader GetTextReader(string input)
    {
        return new StringReader(input);
    }
    private TextWriter GetTextWriter()
    {
        return new StringWriter();
    }
    private StudentList GetStudentList()
    {
        return new StudentList();
    }
    [Fact]
    public void TestAddStudent()
    {
        // Arrange
        const string expected = "The student has been added to the list.\n";
        TextReader reader = GetTextReader(Input);
        TextWriter writer = GetTextWriter();
        StudentList studentList = GetStudentList();
        
        // Act
        studentList.AddStudent(reader, writer);
        var actual = writer.ToString() ?? String.Empty;
        
        // Assert
        Assert.Contains(expected, actual);
        
    }

    [Fact]
    public void TestAddStudentAlreadyPresent()
    {
        // Arrange
        const string expected = "The student is already present in the list.\n";
        TextReader readerInitial = GetTextReader(Input);
        TextWriter writerInitial= GetTextWriter();
        TextReader readerExtra = GetTextReader(Input);
        TextWriter writerExtra = GetTextWriter();
        StudentList studentList = GetStudentList();

        // Act
        studentList.AddStudent(readerInitial, writerInitial);
        studentList.AddStudent(readerExtra, writerExtra);
        var actual = writerExtra.ToString() ?? String.Empty;

        // Assert
        Assert.Contains(expected, actual);
    }
    
    [Fact]
    public void TestRemoveStudent()
    {
        // Arrange
        const string expected = "The student has been removed from the list.\n";
        TextReader readerInitial = GetTextReader(Input);
        TextWriter writerInitial = GetTextWriter();
        TextReader readerExtra = GetTextReader(Input);
        TextWriter writerExtra = GetTextWriter();
        StudentList studentList = GetStudentList();
        
        // Act
        studentList.AddStudent(readerInitial, writerInitial);
        studentList.RemoveStudent(readerExtra, writerExtra);
        var actual = writerExtra.ToString() ?? String.Empty;
        
        // Assert
        Assert.Contains(expected, actual);
    }
}