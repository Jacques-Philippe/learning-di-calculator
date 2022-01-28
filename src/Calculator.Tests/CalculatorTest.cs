using NUnit.Framework;
using Moq;
using CalculatorService;

namespace CalculatorService.Tests;

public class Tests
{
    [Test]
    public void Adding_Should_ReturnTheSum()
    {
        var mock = new Mock<ICalculator>();
        mock.Setup(calculator => calculator.Add(1, 2)).Returns(3);
        var calculatorMoq = mock.Object;
        var result = calculatorMoq.Add(1, 2);
        mock.Verify(calculator => calculator.Add(1, 2), Times.AtMostOnce());
    }

    [Test]
    public void Multiplying_Should_ReturnTheProduct()
    {
        var mock = new Mock<ICalculator>();
        mock.Setup(calculator => calculator.Multiply(3, 2)).Returns(6);
        var calculatorMoq = mock.Object;
        var result = calculatorMoq.Multiply(3, 2);
        mock.Verify(calculator => calculator.Multiply(3, 2), Times.AtMostOnce());
    }
}
