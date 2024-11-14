namespace XUnitTest;

public class MoqTest
{
    [Fact]
    public void Divide()
    {
        var calculator = new Mock<ICalculator>();

        calculator.Setup(x => x.Divide(It.IsAny<decimal>(), It.IsAny<decimal>())).Returns(100);

        Assert.Equal(100, calculator.Object.Divide(1000, 10));
    }

    [Fact]
    public void DivideByZeroException()
    {
        var calculator = new Mock<ICalculator>();

        calculator.Setup(x => x.Divide(It.IsAny<decimal>(), 0)).Throws(new DivideByZeroException());

        Assert.Throws<DivideByZeroException>(() => calculator.Object.Divide(1000, 0));
    }

    [Fact]
    public void Multiply()
    {
        var calculator = new Mock<ICalculator>();

        calculator.Setup(x => x.Multiply(It.IsAny<decimal>(), It.IsAny<decimal>())).Returns(100);

        Assert.Equal(100, calculator.Object.Multiply(5, 20));
    }

    [Fact]
    public void Subtract()
    {
        var calculator = new Mock<ICalculator>();

        calculator.Setup(x => x.Subtract(It.IsAny<decimal>(), It.IsAny<decimal>())).Returns(100);

        Assert.Equal(100, calculator.Object.Subtract(150, 50));
    }

    [Fact]
    public void Sum()
    {
        var calculator = new Mock<ICalculator>();

        calculator.Setup(x => x.Sum(It.IsAny<decimal>(), It.IsAny<decimal>())).Returns(100);

        Assert.Equal(100, calculator.Object.Sum(40, 60));
    }

    [Fact]
    public void SumParameters()
    {
        var calculator = new Mock<ICalculator>();

        calculator.Setup(x => x.Sum(0, 0)).Returns(0);

        calculator.Setup(x => x.Sum(40, 60)).Returns(100);

        Assert.Equal(0, calculator.Object.Sum(0, 0));

        Assert.Equal(100, calculator.Object.Sum(40, 60));
    }
}
