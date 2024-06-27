namespace XUnitTest;

public class FakeItEasyTest
{
    [Fact]
    public void Divide()
    {
        var calculator = A.Fake<ICalculator>();

        A.CallTo(() => calculator.Divide(A<decimal>.Ignored, A<decimal>.Ignored)).Returns(100);

        Assert.Equal(100, calculator.Divide(1000, 10));
    }

    [Fact]
    public void DivideByZeroException()
    {
        var calculator = A.Fake<ICalculator>();

        A.CallTo(() => calculator.Divide(A<decimal>.Ignored, 0)).Throws(new DivideByZeroException());

        Assert.Throws<DivideByZeroException>(() => calculator.Divide(1000, 0));
    }

    [Fact]
    public void Multiply()
    {
        var calculator = A.Fake<ICalculator>();

        A.CallTo(() => calculator.Multiply(A<decimal>.Ignored, A<decimal>.Ignored)).Returns(100);

        Assert.Equal(100, calculator.Multiply(5, 20));
    }

    [Fact]
    public void Subtract()
    {
        var calculator = A.Fake<ICalculator>();

        A.CallTo(() => calculator.Subtract(A<decimal>.Ignored, A<decimal>.Ignored)).Returns(100);

        Assert.Equal(100, calculator.Subtract(150, 50));
    }

    [Fact]
    public void Sum()
    {
        var calculator = A.Fake<ICalculator>();

        A.CallTo(() => calculator.Sum(A<decimal>.Ignored, A<decimal>.Ignored)).Returns(100);

        Assert.Equal(100, calculator.Sum(40, 60));
    }

    [Fact]
    public void SumParameters()
    {
        var calculator = A.Fake<ICalculator>();

        A.CallTo(() => calculator.Sum(0, 0)).Returns(0);

        A.CallTo(() => calculator.Sum(40, 60)).Returns(100);

        Assert.Equal(0, calculator.Sum(0, 0));

        Assert.Equal(100, calculator.Sum(40, 60));
    }
}
