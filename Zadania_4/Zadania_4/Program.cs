using System;

namespace Zadania_4
{
    class Program
    {
        static void Main(string[] args)
        {

            void zadanie4_1()
            {
                Console.WriteLine("Zadanie4_1");
                int n;
                Console.WriteLine("Podaj liczbe elementow tablicy: ");
                n = Convert.ToInt32(Console.ReadLine());
                int[] tab = new int[n];

                for (int i = 0; i < tab.Length; i++)
                {
                    Console.WriteLine("Podaj {0} pierwsza wartosc: ", i + 1);
                    tab[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Podane liczby to:");

                for (int i = 0; i < tab.Length; i++)
                {
                    Console.WriteLine(tab[i]);
                }
                Console.ReadKey();
            }

            void zadanie4_2()
            {
                Console.WriteLine("Zadanie4_2");
                Console.WriteLine("Podaj 10 liczb calkowitych a program wyswietli dodatnie: ");
                int[] tab1 = new int[10];
                int[] tab2 = new int[10];

                for (int i = 0; i < tab1.Length; i++)
                {
                    tab1[i] = Convert.ToInt32(Console.ReadLine());

                    if (tab1[i] > 0)
                    {
                        tab2[i] = tab1[i];
                    }
                }

                for (int i = 0; i < tab2.Length; i++)
                {
                    if (tab2[i] > 0)
                    {
                        Console.WriteLine("Liczba dodatnia to: " + tab2[i]);
                    }
                }
                Console.ReadKey();
            }

            void zadanie4_3()
            {
                Console.WriteLine("Zadanie4_3");
                double lde = 0, suma = 0, max, min, srednia; // lde (liczba dodatnich elemntow)
                Console.WriteLine("Podaj liczbe elementow w tablicy: ");
                int n = Convert.ToInt32(Console.ReadLine());
                double[] tab1 = new double[n];

                max = tab1[0];

                for (int i = 0; i < tab1.Length; i++)
                {
                    Console.WriteLine("Wartosc {0} wynosi: ", i + 1);
                    tab1[i] = Convert.ToInt32(Console.ReadLine());
                    suma += tab1[i];


                    if (tab1[i] > 0)
                    {
                        lde++;
                    }

                    if (max <= tab1[i])
                    {
                        max = tab1[i];
                    }

                }

                min = tab1[0];

                for (int i = 0; i < tab1.Length; i++)
                {
                    if (min >= tab1[i])
                    {
                        min = tab1[i];
                    }

                }

                for (int i = 0; i < tab1.Length; i++)
                {
                    if (tab1[i] == max)
                    {
                        Console.Write("Najwieksza wartosc w tablicy wynosi: " + max + " jest na pozycji: " + i + "\n");
                    }

                    if (tab1[i] == min)
                    {
                        Console.Write("Najmniejsza wartosc w tablicy wynosi: " + min + " jest na pozycji: " + i + "\n");
                    }
                }

                srednia = (suma / tab1.Length);

                Console.Write("Liczba dodatnich elemntow w tablicy wynosi: " + lde + "\n");
                Console.Write("Srednia elemntow tablicy wynosi: " + srednia + "\n");
                Console.ReadKey();
            }

            bool zadanie4_p(int n)
            {
                if (n < 2)
                {
                    return false;
                }
                for (int i = 2; i * i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            void zadanie4_4()
            {
                Console.WriteLine("Zadanie4_4");
                int p = 0; // p = ilosc liczb pierwszych w podanej tablicy
                Console.WriteLine("Prgoram pokazuje ile liczb pierwszych jest w tablicy 100 losowych liczb: ");
                int[] tab1 = new int[100];

                Random rand = new Random();
                for (int i = 0; i < tab1.Length; i++)
                {
                    tab1[i] = rand.Next(1, 1000);
                    Console.WriteLine(tab1[i]);

                }

                for (int i = 0; i < tab1.Length; i++)
                {
                    if (zadanie4_p(tab1[i]))
                    {
                        p++;
                    }

                }

                Console.WriteLine("Liczb pierwszych jest: " + p + " w tablicy 100 liczb");
                Console.ReadKey();
            }

            void zadanie4_5()
            {
                Console.WriteLine("Zadanie4_5");
                int n;
                Console.WriteLine("Podaj ilosc elementow w tablicy: ");
                n = Convert.ToInt32(Console.ReadLine());
                int[] tab1 = new int[n];
                int[] tab2 = new int[n];

                for (int i = 0; i < tab1.Length; i++)
                {
                    tab1[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < tab1.Length; i++)
                {
                    if (i + 1 < tab2.Length)
                    {
                        tab2[i + 1] = tab1[i];
                    }
                    else
                    {
                        tab2[0] = tab1[i];
                    }
                }
                Console.WriteLine();
                for (int i = 0; i < tab2.Length; i++)
                {
                    Console.WriteLine(tab2[i]);
                }
                Console.ReadKey();
            }

            void zadanie4_6()
            {
                Console.WriteLine("Zadanie4_6");
                int n = 5, suma = 0;
                Console.WriteLine("Program wylosuje wartosci dla tablicy 5 x 5");
                int[,] tab2d = new int[n, n];

                Random rand = new Random();
                for (int i = 0, j = 0; i < n; i++)
                {
                    tab2d[i, j] = rand.Next(1, 9);

                    for (j = 0; j < n; j++)
                    {
                        tab2d[i, j] = rand.Next(1, 9);
                        Console.Write("{0,1} ", tab2d[i, j]);
                    }
                    j = 0;
                    Console.WriteLine();
                }

                for (int i = 0, j = 0; i < n; i++, j++)
                {
                    suma += tab2d[i, j];
                }
                Console.WriteLine(suma);
                Console.ReadKey();
            }

            void zadanie4_7()
            {
                Console.WriteLine("Zadanie4_7");
                int x = 2, y = 3; // x - poziom, y - pion
                int[,] tab1_2d = new int[x, y];
                int[,] tab2_2d = new int[x, y];
                int[,] tab3_2d = new int[x, y];

                Console.WriteLine("Wprowadz zmienne do pierwszej macierzy: ");
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        tab1_2d[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Wprowadz zmienne do drugiej macierzy: ");

                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        tab2_2d[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Pierwsza macierz: ");

                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        Console.Write("{0,2} ", tab1_2d[i, j]);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Druga macierz: ");

                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        Console.Write("{0,2} ", tab2_2d[i, j]);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();


                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        tab3_2d[i, j] = tab1_2d[i, j] + tab2_2d[i, j];
                    }
                }

                Console.WriteLine("Macierz wyjsciowa: ");

                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        Console.Write("{0,2} ", tab3_2d[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }

            void zadanie4_8()
            {
                Console.WriteLine("Zadanie4_8");
                Console.WriteLine("Program wyswietli dni tygodnia w 3 jezykach: ");
                Console.WriteLine();

                string[,] dniTygodnia = new string[3, 7];

                dniTygodnia[0, 0] = "poniedzialek";
                dniTygodnia[0, 1] = "wtorek";
                dniTygodnia[0, 2] = "sroda";
                dniTygodnia[0, 3] = "czwartek";
                dniTygodnia[0, 4] = "piatek";
                dniTygodnia[0, 5] = "sobota";
                dniTygodnia[0, 6] = "niedizela";
                dniTygodnia[1, 0] = "monday";
                dniTygodnia[1, 1] = "tuesday";
                dniTygodnia[1, 2] = "wednesday";
                dniTygodnia[1, 3] = "thursday";
                dniTygodnia[1, 4] = "friday";
                dniTygodnia[1, 5] = "saturday";
                dniTygodnia[1, 6] = "sunday";
                dniTygodnia[2, 0] = "montag";
                dniTygodnia[2, 1] = "dienstag";
                dniTygodnia[2, 2] = "mittwoch";
                dniTygodnia[2, 3] = "donnerstag";
                dniTygodnia[2, 4] = "freitag";
                dniTygodnia[2, 5] = "samstag";
                dniTygodnia[2, 6] = "sonntag";

                for (int i = 0; i < dniTygodnia.GetLength(0); i++)
                {
                    for (int j = 0; j < dniTygodnia.GetLength(1); j++)
                    {
                        Console.Write("{0,12}", dniTygodnia[i, j]);
                    }
                    Console.WriteLine();
                }

                Console.ReadKey();
            }

            void zadanie4_9()
            {
                Console.WriteLine("Zadanie4_9");
                Console.WriteLine("Wpisz tekst w ktorym wyrazy sa oddzielone spacja a program poda ile ich jest");
                int liczba = 1; // liczba wskazuje ilosc wyrazow 
                string tekst;
                tekst = Console.ReadLine();

                if (tekst.Length > 0)
                {
                    for (int i = 0; i < tekst.Length; i++)
                    {
                        if (tekst[i] == ' ')
                        {
                            liczba++;
                        }
                    }
                }
                else { liczba = 0; }

                Console.WriteLine("Liczba wyrazow wynosi: " + liczba);
            }

            void zadanie4_10()
            {
                Console.WriteLine("Zadanie4_10");
                Console.WriteLine("Podaj date w formacie: DD-MM-RRRR a program wyswietli ktory jest miesiac. ");
                DateTime data = Convert.ToDateTime(Console.ReadLine());
                int miesiac = data.Month;

                Console.Write("W tym przypadku miesiac to: ");

                switch (miesiac)
                {
                    case 1:
                        Console.Write("Styczen");
                        break;
                    case 2:
                        Console.Write("Luty");
                        break;
                    case 3:
                        Console.Write("Marzec");
                        break;
                    case 4:
                        Console.Write("Kwiecien");
                        break;
                    case 5:
                        Console.Write("Maj");
                        break;
                    case 6:
                        Console.Write("Czerwiec");
                        break;
                    case 7:
                        Console.Write("Lipiec");
                        break;
                    case 8:
                        Console.Write("Sierpien");
                        break;
                    case 9:
                        Console.Write("Wrzesien");
                        break;
                    case 10:
                        Console.Write("Pazdziernik");
                        break;
                    case 11:
                        Console.Write("Listopad");
                        break;
                    case 12:
                        Console.Write("Grudzien");
                        break;
                    default: 
                        Console.Write("Nie ma takiego miesiaca!");
                        break;
                }
            }           

             //zadanie4_1();
             //zadanie4_2();
             //zadanie4_3();
             //zadanie4_4();
             //zadanie4_5();
             //zadanie4_6();
             //zadanie4_7();
             //zadanie4_8();
             //zadanie4_9();
             //zadanie4_10();
            
        }

    } 
}
