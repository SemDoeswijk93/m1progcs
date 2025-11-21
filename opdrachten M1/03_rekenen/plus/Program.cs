namespace plus;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int LeeftijdStudent = 16;

        int nummerVariable = 0; //we starten op 0

        // we rekenen tellen 0 + 1 uit, EN DAN zetten we het resultaat (1) in nummervariable met de =

        nummerVariable = LeeftijdStudent + 1;

        Console.WriteLine("Year 1 Happy Birthday!");
        Console.WriteLine($"Je bent nu {nummerVariable}");
    }
}
