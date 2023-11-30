using TriangleСalculator.Calculators;
using TriangleСalculator.Enums;
using TriangleСalculator.Models;

namespace Tests;

public class TestsForFigures
{
    private readonly ITriangleCalculatorType _triangleCalculatorType;
        
    public TestsForFigures()
    {
        this._triangleCalculatorType = new TriangleCalculatorType();
    }


    [Test]
    public void AnalyzeTriangle_RightTriangle_ReturnsRight()
    {
        // Arrange
        var side1 = 3.0;
        var side2 = 4.0;
        var side3 = 5.0;
        var triangle = new Triangle(side1, side2, side3);
        // Act
        var result = this._triangleCalculatorType.GetTypeTriangle(triangle);

        // Assert
        Assert.That(result, Is.EqualTo(TriangleType.Right));
    }

    [Test]
    public void AnalyzeTriangle_ObtuseTriangle_ReturnsObtuse()
    {
        // Arrange
        var side1 = 3.0;
        var side2 = 4.0;
        var side3 = 6.0;
        var triangle = new Triangle(side1, side2, side3);
        // Act
        var result = this._triangleCalculatorType.GetTypeTriangle(triangle);

        // Assert
        Assert.That(result, Is.EqualTo(TriangleType.Obtuse));
    }
    
    [Test]
    public void AnalyzeTriangle_AcuteTriangle_ReturnsAcute()
    {
        // Arrange
        var side1 = 5.0;
        var side2 = 5.0;
        var side3 = 5.0;
        var triangle = new Triangle(side1, side2, side3);
        // Act
        var result = this._triangleCalculatorType.GetTypeTriangle(triangle);

        // Assert
        Assert.That(result, Is.EqualTo(TriangleType.Acute));
    }

    [Test]
    public void AnalyzeTriangle_InvalidSides_ReturnsInvalid()
    {
        // Arrange
        var side1 = 1.0;
        var side2 = 2.0;
        var side3 = 10.0;
        var triangle = new Triangle(side1, side2, side3);
        // Act
        var result = this._triangleCalculatorType.GetTypeTriangle(triangle);

        // Assert
        Assert.AreEqual(TriangleType.Invalid, result);
    }
}