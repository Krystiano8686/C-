using System;

namespace Zadania_2
{

    class Zadania
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Zadanie 2.1");
            double celc, far;
            Console.WriteLine("Podaj stopnie w celcjuszach");
            celc = Convert.ToDouble(Console.ReadLine());
            far = celc * 9 / 5 + 32;
            Console.WriteLine(far);

            Console.WriteLine("///////////////////////////////////////////////////////");

            Console.WriteLine("Zadanie 2.2");
            double a, b, c, delt;
            Console.WriteLine("Podaj a, b i c");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            delt = b * b - 4 * a * c;

            Console.WriteLine("Delta jest równa: " + delt);

            Console.WriteLine("///////////////////////////////////////////////////////");

            Console.WriteLine("Zadanie 2.3");
            double mass, height, BMI;
            Console.WriteLine("Podaj swoją wagę w kilogramach");
            mass = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj swój wzrost metrach");
            height = Convert.ToDouble(Console.ReadLine());

            BMI = mass / (height * height);

            Console.WriteLine("Twoje BMI wynosi: " + BMI);

            Console.WriteLine("///////////////////////////////////////////////////////");

            Console.WriteLine("Zadanie 2.4: a");
            Console.WriteLine("Zadanie 2.5: d");
            Console.WriteLine("Zadanie 2.6: 3");
            Console.WriteLine("Zadanie 2.7: 7");
            Console.WriteLine("Zadanie 2.8: a");
            Console.WriteLine("Zadanie 2.9: a");

            Console.WriteLine("///////////////////////////////////////////////////////");

            Console.WriteLine("Zadanie 2.10");

            double powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia = osoby / powierzchnia;
            Console.WriteLine(gestoscZaludnienia);
            Console.WriteLine("Problem polegał na tym, iż bazowo dla powierzchni i osób był przypisany do int`a a więc program zaokrąglił w dół z 0.1 do 0");
        }
    }
}
