namespace TriangleСalculator.Models;

/// <summary>
/// Треугольник.
/// </summary>
public class Triangle : FigureBase
{
    #region Constructor

    public Triangle(
        double side1,
        double side2,
        double side3)
    {
        this.Side1 = side1;
        this.Side2 = side2;
        this.Side3 = side3;

        this.ValidateFigure();
    }

    #endregion

    #region Public Fields

    public double Side1;
    public double Side2;
    public double Side3;

    #endregion

    #region Public Methods

    /// <inheritdoc />
    /// <exception cref="ArgumentException">Все стороны треугольника должны быть положительными числами.</exception>
    public sealed override void ValidateFigure()
    {
        if (this.Side1 <= 0 || this.Side2 <= 0 || this.Side3 <= 0)
        {
            throw new ArgumentException("Все стороны треугольника должны быть положительными числами.");
        }
    }

    #endregion
}