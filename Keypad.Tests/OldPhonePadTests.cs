namespace Keypad.Tests;

public class OldPhonePadTests
{
    [Theory]
    [InlineData("222 2 22#", "cab")]
    [InlineData("33#", "e")]
    [InlineData("227 *#", "b")]
    [InlineData("4433555 555666#", "hello")]
    [InlineData("8 88777444666 * 664#", "turing")]
    public void OldPhonePadTheory(string input, string expectedResult)
    {
        var _oldPhonePad = new Keypad.OldPhonePad();

        string result = _oldPhonePad.process(input);

        Assert.Equal(expectedResult, result);
    }
}
