namespace als;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Je zoekt je sleutel.");
        bool sleutelKwijt = false;

        if (sleutelKwijt == false) 
        {
            Console.WriteLine("Je hebt je sleutel GEVONDEN.");
            Console.WriteLine("Je mooie deur kan dus open.");

        }


        else if (sleutelKwijt == true)
        {
            Console.WriteLine("Je bent je sleutel VERLOREN.");
            Console.WriteLine("Je mooie deur blijft dus GESLOTEN.");

        }

    }
}
