namespace Application;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Incorrect usage. Pass a string to be processed, e.g. \"222 2 22#\".");
            Console.WriteLine("Space-delimited string must be wrapped in double quotes.");
            Environment.Exit(1);
        }

        var input = args[0];

        if (!args[0].EndsWith("#"))
        {
            Console.WriteLine("String must end with a hash, i.e. '#'.");
            Environment.Exit(1);
        }

        var keypad = new Keypad.OldPhonePad();

        Console.WriteLine($"\"{input}\" emits \"{keypad.process(input)}\"");
    }
}
