namespace Keypad.Tests;

public class MultiTapTestFixture
{
    public IKeypadTextInputMethod InputMethod { get; private set; }

    public MultiTapTestFixture()
    {
        InputMethod = new MultiTapInput();
    }
}

public class MultiTapInputTests : IClassFixture<MultiTapTestFixture>
{
    private readonly MultiTapTestFixture _fixture;

    public MultiTapInputTests(MultiTapTestFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void Test_SequenceFailsWhenItDoesNotEndWithHash()
    {
        var (Successful, _) = _fixture.InputMethod.Validate("123");

        Assert.False(Successful);
    }

    [Theory]
    [InlineData("222 2 22#", "cab")]
    [InlineData("33#", "e")]
    [InlineData("227 *#", "b")]
    [InlineData("4433555 555666#", "hello")]
    [InlineData("8 88777444666 * 664#", "turing")]
    public void MultiTapInputTheory(string input, string expectedResult)
    {
        string result = _fixture.InputMethod.Process(input);

        Assert.Equal(expectedResult, result);
    }
}
