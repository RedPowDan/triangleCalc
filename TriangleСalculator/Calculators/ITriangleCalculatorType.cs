using TriangleСalculator.Enums;
using TriangleСalculator.Models;

namespace TriangleСalculator.Calculators;

/// <summary>
/// Калькулятор для фигур.
/// </summary>
public interface ITriangleCalculatorType
{
    #region Public Methods

    /// <summary>
    /// Получает тип треугольника.
    /// </summary>
    /// <param name="triangle">Треугольник.</param>
    /// <returns>Результат проверки.</returns>
    public TriangleType GetTypeTriangle(Triangle triangle);

    #endregion
}