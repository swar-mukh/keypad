namespace Keypad;

public interface IKeypadTextInputMethod
{
    (bool Successful, string? ErrorIfAny) Validate(string sequenceOfCharacters);
    string Process(string sequenceOfCharacters);
}