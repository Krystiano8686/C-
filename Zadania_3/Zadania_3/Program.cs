using System;

namespace Zadania_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Zadanie 3.1");

            Console.WriteLine("Podaj rok:");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0) && (year % 400 == 0) || (year % 100 != 0))
            {
                Console.WriteLine("Rok jest przestępny!");
            }
            else
            {
                Console.WriteLine("Rok nie jest przestępny!");
            }
            */



            /*
            Console.WriteLine("Zadanie 3.2");

            Console.WriteLine("Podaj pierwsza liczbe: ");
            int pierwsza = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj druga liczbe: ");
            int druga = int.Parse(Console.ReadLine());

            if (druga == 0)
            {
                Console.WriteLine("Nie dzielimy przez 0");
            }

            else if (pierwsza % druga == 0)
            {
                Console.WriteLine("Druga liczba jest dzielnikiem pierwszej");
            }
          
            else
            {
                Console.WriteLine("Druga liczba nie jest dzielnikiem pierwszej");
            }
            */



            /*
            Console.WriteLine("Zadanie 3.3");
            int pierwsza, druga, trzecia, max;

            Console.WriteLine("Podaj pierwsza liczbe:");
            pierwsza = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj druga liczbe:");
            druga = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj trzecia liczbe:");
            trzecia = int.Parse(Console.ReadLine());

            max = pierwsza;

            if (druga > max) { max = druga; }
            if (trzecia > max) { max = trzecia; }


            Console.WriteLine("Najwieksza liczba to: " + max);   
            */



            /*
            Console.WriteLine("Zadanie 3.4");
            double pierwsza, druga, wynik = 0;
            string wybor;

            Console.WriteLine("Podaj pierwsza liczbe");
            pierwsza = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj druga liczbe");
            druga = int.Parse(Console.ReadLine());

            Console.WriteLine("Co chcesz zrobic?");
            Console.WriteLine("Dodac: wpisz +");
            Console.WriteLine("Odjac: wpisz -");
            Console.WriteLine("Pomnozyc: wpisz *");
            Console.WriteLine("Podzielic: wpisz /");
            wybor = Console.ReadLine();

            switch (wybor)
            {
                case "+":
                    wynik = pierwsza + druga;
                    break;

                case "-":
                    wynik = pierwsza - druga;
                    break;

                case "*":
                    wynik = pierwsza * druga;
                    break;

                case "/":
                    if(druga == 0)
                    {
                        Console.WriteLine("Nie mozemy dzielic przez 0!");
                    }
                    wynik = pierwsza / druga;
                    break;
                default:
                    Console.WriteLine("Podano zły symbol");
                    break;
            }

            Console.WriteLine("Wynik Twojego dzialania wynosi: " + wynik);
           */



            /*
            Console.WriteLine("Zadanie 3.5");

            double a, b, c, delt, x1, x2, x0;

            Console.WriteLine("Podaj wspolczyniki rownania: a, b i c");

            Console.WriteLine("Podaj a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj c: ");
            c = Convert.ToDouble(Console.ReadLine());

            delt = b*b - 4*a* c;

            if (delt > 0)
            {
                x1 = (-b - Math.Sqrt(delt)) / (2 * a);
                x2 = (-b + Math.Sqrt(delt)) / (2 * a);
                Console.WriteLine("Rownanie ma dwa miejsca zerowe: x1 = " + x1 + " oraz x2 = " + x2);
            } else if (delt == 0){
                x0 = -b / (2 * a);
                Console.WriteLine("Rownanie ma jedno miejsca zerowe: x1 = " + x0);
            } else
            {
                Console.WriteLine("Rownanie nie ma rozwiazan rzeczywistych");
            }
            */



            /*
            Console.WriteLine("Zadanie 3.6");

            double mass, height, BMI;

            Console.WriteLine("Podaj swoją wagę w kilogramach");
            mass = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj swój wzrost metrach");
            height = Convert.ToDouble(Console.ReadLine());

            BMI = mass / (height * height);
            Console.WriteLine("Twoje BMI wynosi: " + BMI);

            if(BMI < 18.5) {
                Console.WriteLine("Masz niedowage!");
            } else if (BMI <25 && BMI >= 18.5) {
                Console.WriteLine("Masz prawdilowa wage!");
            } else
            {
                Console.WriteLine("Masz nadwage!");
            }
            */



            /*
            Console.WriteLine("Zadanie 3.7");

            int choice;
            Console.WriteLine("Wpisz nr dnia tygodnia");
            choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;

                case 2:
                    Console.WriteLine("Wtorek");
                    break;

                case 3:
                    Console.WriteLine("Sroda");
                    break;

                    case 4:
                    Console.WriteLine("Czwartek");
                    break;

                case 5:
                    Console.WriteLine("Piatek");
                    break;

                case 6:
                    Console.WriteLine("Sobota");
                    break;

                case 7:
                    Console.WriteLine("Niedziela");
                    break;

                default:
                    Console.WriteLine("Nie ma takiego dnia tygodnia!");
                    break;
            }
            */



            /*
            Console.WriteLine("Zadanie 3.8");

            double gr1, gr2, gr3, gr4, gr5, avarage;

            Console.WriteLine("Podaj 5 ocen odzielonych enterem");
            gr1 = Convert.ToDouble(Console.ReadLine());
            gr2 = Convert.ToDouble(Console.ReadLine());
            gr3 = Convert.ToDouble(Console.ReadLine());
            gr4 = Convert.ToDouble(Console.ReadLine());
            gr5 = Convert.ToDouble(Console.ReadLine());

            avarage = (gr1 + gr2 + gr3 + gr4 + gr5) / 5;

            Console.WriteLine("Twoja srednia wynosi: " + avarage);

            if (avarage >= 0 && avarage < 4)
            {
               Console.WriteLine("Twoje stypendium wynosi 0 zl");
            } else if (avarage >= 4 && avarage < 4.8)
            {
               Console.WriteLine("Twoje stypendium wynosi 350 zl");
            } else Console.WriteLine("Twoje stypendium wynosi 550 zl"); 
            */



            /*
            Console.WriteLine("Zadanie 3.9");

            Console.WriteLine("Podpunkt A)\n");
            int n, n1 = 1;
            Console.WriteLine("Wprowadź liczbę wierszy");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n1; j++)
                {
                    Console.Write("*");
                }
                n1++;
                Console.WriteLine();
            }

            Console.WriteLine("Podpunkt B)\n");
            int m, m1;
            Console.WriteLine("Wprowadź liczbę wierszy");
            m = int.Parse(Console.ReadLine());
            m1 = m;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= m1; j++)
                {
                    Console.Write("*");
                }
                m1--;
                Console.WriteLine();
            } 

            Console.WriteLine("Podpunkt C)\n");

            int o, o1, r = 1;
            Console.WriteLine("Wprowadź liczbę wierszy");
            o = int.Parse(Console.ReadLine());
            o1 = o;
            for (int i = 1; i <= o; i++)
            {
                for (int j = 1; j <= o1; j++)
                {
                    Console.Write(" ");
                }
                for (int p = 0; p < r; p++)
                {
                    Console.Write("*");
                }
                o1--;
                r++;
                Console.WriteLine();
            }

            Console.WriteLine("Podpunkt D)\n");
            int s;
            Console.WriteLine("Wprowadź liczbę wierszy");
            s = int.Parse(Console.ReadLine());

            for (int i = 0; i < s; i++)
            {
               if(i % 3 == 0)
                {
                    Console.Write("****");
                } else
                {
                    Console.Write("*  *");
                }
                Console.WriteLine();
            }
            */



            /*
            Console.WriteLine("Zadanie 3.10");

            int n, silnia =1;
            Console.WriteLine("Podaj n: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                silnia *= i;
               
            }
            Console.WriteLine("Silnia wynosi: " + silnia);
            */



            /*
            Console.WriteLine("Zadanie 3.11");
            Console.WriteLine("Ile liczb kolejnych liczb musi sie zsmuowac by przekroczyc 100");
            int suma = 0, pierwsza = 1, ile = 0;

            while (suma <= 100)
            {
                suma += pierwsza;
                pierwsza++;
                ile++;
                Console.WriteLine(suma);
            }
            Console.WriteLine("Po tylu kolejnych liczbach suma przekroczy 100: " + ile);
            */



            /*
            Console.WriteLine("Zadanie 3.12");

            Console.WriteLine("Podawaj liczby calkowite: ");
            int liczba = 1, suma = 0;
          
            while (liczba != 0)
            {
                liczba = Convert.ToInt32(Console.ReadLine());
                suma += liczba;
            }
            Console.WriteLine("Suma Twoich liczb wynosi: " + suma);
            */



            /*
            Console.WriteLine("Zadanie 3.13");

            int n;
            double suma = 0;
            Console.WriteLine("Podaj liczbe n: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    suma =- i;
                } else
                {
                    suma =- i;
                }
            }
            Console.WriteLine("Suma szeregu wynosi: " + suma);
            */



            /*
            Console.WriteLine("Zadanie 3.14");

            int n;
            Console.WriteLine("Podaj n: ");
            n = int.Parse(Console.ReadLine());

            for (long i = 1; i <= n; i++)
            {
                long suma = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        suma = suma + j;
                }
                if (suma == i) { 
                    Console.WriteLine("Liczba: " + suma + " jest doskonala");
                }
            }
            */
        }
    }
}
