namespace Keypad.Tests;

public class T9TestFixture
{
    public IKeypadTextInputMethod InputMethod { get; private set; }

    public T9TestFixture()
    {
        InputMethod = new T9Input();
    }
}

public class T9InputTests : IClassFixture<T9TestFixture>
{
    private readonly T9TestFixture _fixture;

    public T9InputTests(T9TestFixture fixture)
    {
        _fixture = fixture;
    }

    [Theory]
    [InlineData("123", "??")]
    [InlineData("84265 968", "thank you")]
    [InlineData("43556 2629464 5433", "hello amazing life")]
    public void T9InputTheory(string input, string expectedResult)
    {
        string result = _fixture.InputMethod.Process(input);

        Assert.Equal(expectedResult, result);
    }
}
