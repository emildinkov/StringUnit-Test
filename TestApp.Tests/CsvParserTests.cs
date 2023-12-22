using NUnit.Framework;
using System;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        // Arrange
        string input = "";

        // Act
        string[] result = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        // Arrange
        string input = "hello";

        // Act
        string[] result = CsvParser.ParseCsv(input);

        // Assert
        Assert.That (result, Is.EqualTo(new[] { "hello" }));
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        // Arrange
        string input = "a,b,c";

        // Act
        string[] result = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(result, Is.EqualTo(new[] {"a", "b", "c"}));
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        // Arrange
        string input = "abc  ";

        // Act
        string[] result = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(result, Is.EqualTo(new[] { "abc" }));
    }
}
