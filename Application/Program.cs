using Keypad;

namespace Application;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            ShowUsage();
            Environment.Exit(1);
        }

        var (mode, sequence) = TryParseArgs(args);
        IKeypadTextInputMethod? inputMethod = null;

        switch (mode)
        {
            case "t9":
                {
                    inputMethod = new T9Input();
                    break;
                }
            case "multitap":
                {
                    inputMethod = new MultiTapInput();
                    break;
                }
            default:
                {
                    Console.WriteLine("Invalid mode!");
                    Environment.Exit(1);
                    break;
                }
        }

        if (inputMethod is not null)
        {
            var (Successful, ErrorIfAny) = inputMethod.Validate(sequence);

            if (!Successful)
            {
                Console.WriteLine(ErrorIfAny);
                Environment.Exit(1);
            }
        }

        Console.WriteLine($"\"{sequence}\" in {mode} format emits \"{inputMethod?.Process(sequence)}\"");
    }

    static void ShowUsage()
    {
        Console.WriteLine("Incorrect usage!\n");
        Console.WriteLine("Usage:\n");
        Console.WriteLine("--mode=<t9|multitap> \"sequence\"\n");
        Console.WriteLine("1. Pass a string to be processed, e.g. \"222 2 22#\".");
        Console.WriteLine("2. Space-delimited string must be wrapped in double quotes.");
    }

    static (string Mode, string Sequence) TryParseArgs(string[] args)
    {
        string mode = "";

        if (args[0].StartsWith("--mode"))
        {
            mode = args[0].Substring("--mode=".Length);
        }

        return (mode, args[1]);
    }
}
