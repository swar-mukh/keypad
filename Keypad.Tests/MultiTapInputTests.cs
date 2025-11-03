namespace Keypad.Tests;

public class MultiTapInputTests
{
    [Theory]
    [InlineData("222 2 22#", "cab")]
    [InlineData("33#", "e")]
    [InlineData("227 *#", "b")]
    [InlineData("4433555 555666#", "hello")]
    [InlineData("8 88777444666 * 664#", "turing")]
    public void MultiTapInputTheory(string input, string expectedResult)
    {
        var _multiTapInput = new MultiTapInput();

        string result = _multiTapInput.Process(input);

        Assert.Equal(expectedResult, result);
    }
}
