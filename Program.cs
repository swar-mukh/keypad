using System.Text;

namespace keypad;

class Program
{
    static Dictionary<char, string> Keys = new Dictionary<char, string>
    {
        { '1', "&\'(" },
        { '2', "abc" },
        { '3', "def" },
        { '4', "ghi" },
        { '5', "jkl" },
        { '6', "mno" },
        { '7', "pqrs" },
        { '8', "tuv" },
        { '9', "wxyz" },
        { '*', "\b" },
        { '0', " " },
        { '#', "" }
    };

    static void Main(string[] args)
    {
        Console.WriteLine($"222 2 22#: {OldPhonePad("222 2 22#")}"); //=> output: CAB
        Console.WriteLine($"33#: {OldPhonePad("33#")}"); //=> output: E
        Console.WriteLine($"227 *#: {OldPhonePad("227 *#")}"); //=> output: B
        Console.WriteLine($"4433555 555666#: {OldPhonePad("4433555 555666#")}"); //=> output: HELLO
        Console.WriteLine($"8 88777444666 * 664#: {OldPhonePad("8 88777444666 * 664#")}"); //=> output: ?????
    }

    static string OldPhonePad(string input)
    {
        var result = new StringBuilder();
        int frequency = 0;

        for (int i = 1; i < input.Length; i++)
        {
            var previousCharacter = input[i - 1];
            var currentCharacter = input[i];

            if (currentCharacter == previousCharacter)
            {
                frequency++;
            }
            else
            {
                result.Append(Keys[previousCharacter][frequency]);

                if (currentCharacter == ' ')
                {
                    i++;
                }

                frequency = 0;
            }
        }

        return result.ToString();
    }
}
