﻿namespace TriangleСalculator.Models;

/// <summary>
/// Базовый класс для фигуры.
/// </summary>
public abstract class FigureBase
{
    /// <summary>
    /// Проверяет фигуру на правильность заполненных данных.
    /// </summary>
    /// <remarks>
    /// ВАЖНО.
    /// Похорошему здесь мы должны передавать объект который будет содержать в себе результаты валидации.
    /// Что-то типо ValidationResultBuilder. Но думаю в контексте тестового задания это не важно.
    /// </remarks>
    /// <returns>Результат проверки.</returns>
    public abstract void ValidateFigure();
}