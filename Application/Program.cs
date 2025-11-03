namespace Application;

class Program
{
    static void Main(string[] args)
    {
        var keypad = new Keypad.OldPhonePad();

        Console.WriteLine($"222 2 22#: {keypad.process("222 2 22#")}"); //=> output: CAB
        Console.WriteLine($"33#: {keypad.process("33#")}"); //=> output: E
        Console.WriteLine($"227 *#: {keypad.process("227 *#")}"); //=> output: B
        Console.WriteLine($"4433555 555666#: {keypad.process("4433555 555666#")}"); //=> output: HELLO
        Console.WriteLine($"8 88777444666 * 664#: {keypad.process("8 88777444666 * 664#")}"); //=> output: ?????
    }
}
