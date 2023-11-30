using TriangleСalculator.Enums;
using TriangleСalculator.Models;

namespace TriangleСalculator.Calculators;

public class TriangleCalculatorType : ITriangleCalculatorType
{
    #region Public Methods

    /// <inheritdoc />
    public TriangleType GetTypeTriangle(Triangle triangle)
    {
        // Проверяем неравенство треугольника
        if (triangle.Side1 + triangle.Side2 <= triangle.Side3
            || triangle.Side2 + triangle.Side3 <= triangle.Side1
            || triangle.Side1 + triangle.Side3 <= triangle.Side2)
        {
            return TriangleType.Invalid;
        }

        // Вычисляем квадраты сторон треугольника
        var square1 = triangle.Side1 * triangle.Side1;
        var square2 = triangle.Side2 * triangle.Side2;
        var square3 = triangle.Side3 * triangle.Side3;

        // Проверяем тип треугольника
        if (square1 + square2 == square3 || square2 + square3 == square1 || square1 + square3 == square2)
        {
            return TriangleType.Right;
        }

        if (square1 + square2 > square3 && square2 + square3 > square1 && square1 + square3 > square2)
        {
            return TriangleType.Acute;
        }

        return TriangleType.Obtuse;
    }

    #endregion
}