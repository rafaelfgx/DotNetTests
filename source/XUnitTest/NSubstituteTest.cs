namespace XUnitTest;

public class NSubstituteTest
{
    [Fact]
    public void Divide()
    {
        var calculator = Substitute.For<ICalculator>();

        calculator.Divide(Arg.Any<decimal>(), Arg.Any<decimal>()).Returns(100);

        Assert.Equal(100, calculator.Divide(1000, 10));
    }

    [Fact]
    public void DivideByZeroException()
    {
        var calculator = Substitute.For<ICalculator>();

        calculator.Divide(1000, 0).Returns(_ => throw new DivideByZeroException());

        Assert.Throws<DivideByZeroException>(() => calculator.Divide(1000, 0));
    }

    [Fact]
    public void Multiply()
    {
        var calculator = Substitute.For<ICalculator>();

        calculator.Multiply(Arg.Any<decimal>(), Arg.Any<decimal>()).Returns(100);

        Assert.Equal(100, calculator.Multiply(5, 20));
    }

    [Fact]
    public void Subtract()
    {
        var calculator = Substitute.For<ICalculator>();

        calculator.Subtract(Arg.Any<decimal>(), Arg.Any<decimal>()).Returns(100);

        Assert.Equal(100, calculator.Subtract(150, 50));
    }

    [Fact]
    public void Sum()
    {
        var calculator = Substitute.For<ICalculator>();

        calculator.Sum(Arg.Any<decimal>(), Arg.Any<decimal>()).Returns(100);

        Assert.Equal(100, calculator.Sum(40, 60));
    }

    [Fact]
    public void SumParameters()
    {
        var calculator = Substitute.For<ICalculator>();

        calculator.Sum(0, 0).Returns(0);

        calculator.Sum(40, 60).Returns(100);

        Assert.Equal(0, calculator.Sum(0, 0));

        Assert.Equal(100, calculator.Sum(40, 60));
    }
}
