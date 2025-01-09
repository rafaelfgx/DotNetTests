namespace XUnitTest;

public class RealTest
{
    private readonly ICalculator _calculator = new Calculator();

    [Theory]
    [InlineData(100, 10, 10)]
    [InlineData(1000, 10, 100)]
    public void Divide(decimal number1, decimal number2, decimal result)
    {
        Assert.Equal(result, _calculator.Divide(number1, number2));
    }

    [Fact]
    public void DivideByZeroException()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(1000, 0));
    }

    [Theory]
    [InlineData(2, 5, 10)]
    [InlineData(20, 10, 200)]
    public void Multiply(decimal number1, decimal number2, decimal result)
    {
        Assert.Equal(result, _calculator.Multiply(number1, number2));
    }

    [Theory]
    [InlineData(15, 5, 10)]
    [InlineData(100, 50, 50)]
    public void Subtract(decimal number1, decimal number2, decimal result)
    {
        Assert.Equal(result, _calculator.Subtract(number1, number2));
    }

    [Theory]
    [InlineData(-10, 10, 0)]
    [InlineData(100, 50, 150)]
    public void Sum(decimal number1, decimal number2, decimal result)
    {
        Assert.Equal(result, _calculator.Sum(number1, number2));
    }
}
