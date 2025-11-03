namespace Keypad;

public class OldPhonePad
{
    private Dictionary<char, string> Keys = new Dictionary<char, string>
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

    public string process(string input)
    {
        var result = new System.Text.StringBuilder();
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
