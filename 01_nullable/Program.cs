namespace _01_nullable;

class Program
{
    private static readonly int second;

    static void Main(string[] args)
    {
        int? first = 0;

        int? third = new();
        DateTime fourth = new();

        Console.WriteLine(first); // 0
        Console.WriteLine(second); // 0
        Console.WriteLine(third); // 0
        Console.WriteLine(fourth); // 01.01.0001 00:00:00
    }
}
