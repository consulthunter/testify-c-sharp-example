using System;
using System.IO;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testify_CSharp_Example.Tests;

[TestClass]
[TestSubject(typeof(Program))]
public class ProgramTest
{

    [TestMethod]
    public void TestMainExit()
    {
        // Arrange
        const string input = "4";
        const string expected = "Goodbye!\n";
        TextReader reader = new StringReader(input);
        TextWriter writer = new StringWriter();
        
        // Act
        Program.Start(reader, writer);
        var actual = writer.ToString() ?? String.Empty;
        
        // Assert
        Assert.IsTrue(actual.Contains(expected));
    }
}