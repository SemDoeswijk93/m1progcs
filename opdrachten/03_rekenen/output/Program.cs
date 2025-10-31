using System.Globalization;

namespace output;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int a = 1;
        double b = 1.9;
        float vx = 9.87f;
        bool ja = true;

        Console.WriteLine($"mijn int met de naam a heeft een waarde van {a}");
        Console.WriteLine($"ik heb een double met de naam b en die heeft een waarde van {b}");
        Console.WriteLine($"ik heb een float met de naam vx en die heeft een waarde van {vx}");
        Console.WriteLine($"ik heb een bool genaamd Ja op {ja} staan");


    }
}
