namespace Keypad;

public class T9Input : IKeypadTextInputMethod
{
    /**
    * Simulate a non-exhaustive local dictionary of words
    */
    private Dictionary<string, string> Sequences = new Dictionary<string, string>
    {
        { "43556", "hello" },
        { "84265", "thank" },
        { "968", "you" },
        { "5433", "life" },
        { "2629464", "amazing" }
    };

    public (bool Successful, string? ErrorIfAny) Validate(string sequenceOfCharacters)
    {
        return (true, null);
    }

    public string Process(string input)
    {
        return string.Join(" ",
            input
                .Split(" ")
                .Select(word => Sequences.TryGetValue(word, out var value) ? value : "??")
        );
    }
}
