namespace Keypad.Tests;

public class T9InputTests
{
    [Theory]
    [InlineData("123", "??")]
    [InlineData("84265 968", "thank you")]
    [InlineData("43556 2629464 5433", "hello amazing life")]
    public void T9InputTheory(string input, string expectedResult)
    {
        var _t9Input = new T9Input();

        string result = _t9Input.Process(input);

        Assert.Equal(expectedResult, result);
    }
}
