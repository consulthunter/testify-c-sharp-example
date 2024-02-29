using System;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testify_CSharp_Example;

namespace Testify_CSharp_Example.Tests;

[TestClass]
[TestSubject(typeof(Program))]
public class ProgramTest
{

    [TestMethod]
    public void TestMainExit()
    {
        Assert.IsTrue(true);
    }
}