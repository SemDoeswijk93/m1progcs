namespace operators;

class Program
{
    static void Main(string[] args)
    {

        int plus = 9;
        plus++;

        Console.WriteLine($"Ik heb er 1 bij gedaan want de waarde is nu {plus}");

        int min = 9;
        min--;
        min--;

        Console.WriteLine($"Ik heb er 2 afgehaald want de waarde is nu {min}");

        int voorbeeld1 = 20;
        voorbeeld1 += 10;
        Console.WriteLine($"Voorbeeld 1 is nu 30, kijk {voorbeeld1}");

        int voorbeeld2 = 20;
        int result = voorbeeld2 + 10;
        Console.WriteLine($"Voorbeeld 2 blijft 20 want kijk {voorbeeld2} terwijl result wel {result} is.");

        int voorbeeld3 = 20;
        int result2 = voorbeeld3 += 10;
        Console.WriteLine($"Voorbeeld 3 is nu wel {voorbeeld3} net zo als result 2 die ook {result2} is. Dit komt door de += die we erbij hebben gedaan.");

        //Zelf Opdrachten hieronder

        int getalint = 163;
        getalint -= 67;
        Console.WriteLine($"De getal met de int wat eerst 163 was heeft nu een waarde van {getalint}");

        double getaldouble = 67;
        getaldouble *= 3;
        Console.WriteLine($"De getal met de double wat eerst 67 was heeft nu een waarde van {getaldouble}");

        float getalfloat = 690;
        getalfloat /= 5;
        Console.WriteLine($"De getal met de float wat eerst 690 was heeft nu een waarde van {getalfloat}");


    }
}
