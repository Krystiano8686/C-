using System;

namespace Zadania_5
{
    class Program
    {
        static void Main(string[] args)
        {

            static double zadanie5_1a(double temp)
            {
                
                return temp * 9 / 5 + 32;
            }

            static void zadanie5_1()
            {
                double temp;
                Console.WriteLine("Podaj temperature w celcjuszach a on zamieni ja na fahrenheita: ");
                temp = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Temperatura wynosi: " + zadanie5_1a(temp) + " stopni fahrenheita");
            }

            static bool zadanie5_2a(double a, double b, double x)
            {
                if (a < b)
                {
                    if (x < b && x > a)
                    {
                        return true;
                    }
                    else return false;
                } else
                {
                    if (x > b && x < a)
                    {
                        return true;
                    }
                    else return false;
                }
               
            }

            static void zadanie5_2()
            {
                double a, b, x;
                Console.WriteLine("Podaj liczby a i b ktore beda krancami przedzialow");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj liczbe x by sprawdzic czy jest w podanym wczesniej przedziale");
                x = Convert.ToDouble(Console.ReadLine());
             
                Console.WriteLine("Czy liczba nalezy do przedzialu? " + zadanie5_2a(a, b, x));
            }



            static void zadanie5_3a(ref int[,] tab1)
            {
                int i, j;
                int[,] wektor = new int[1, 2] { { 3, 2 } };
                for (i = 0; i < 1; i++)
                {
                    for (j = 0; j < 2; j++)
                    {
                        tab1[i, j] = tab1[i, j] + wektor[i, j];
                    }
                }
            }


            static void zadanie5_3()
            {
                int[,] tab1 = new int[1, 2];
                Console.WriteLine("Podaj wspolrzedne punktu A: ");
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j< 2; j++)
                    {
                        tab1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("Po przesunieciu o wektor[3,2]:");
                zadanie5_3a(ref tab1);

                foreach (int x in tab1)
                {
                    Console.WriteLine(x);
                }

                Console.ReadKey();
            }


            static void zadanie5_4b(int[] tab1, int n)
            {
                int[] tab2 = new int[tab1.Length];

                Console.WriteLine("Otrzymana tablica wynosi: (pomnzozona przez) " + n);

                for (int i = 0; i < tab1.Length; i++)
                {

                    tab1[i] *= n;
                    Console.Write(tab1[i] + ", ");
                }
                Console.WriteLine();

            }

            static int[] zadanie5_4a(int[] tab1, int n) {
                int[] tab2 = new int[tab1.Length];

                Console.WriteLine("Otrzymana tablica wynosi: (pomnzozona przez) " + n);

                for (int i = 0; i < tab1.Length; i++)
                {
                    tab2[i] = tab1[i];
                }
                return tab2;
            }


            static void zadanie5_4()
            {
                int[] tab1 = new int[] {2, 4, 6, 8, 1, 10, 40};
                int n;
                Console.WriteLine("Podaj liczbe przez ktora chcesz pomnozyc podana nizej tablice: ");

                for(int i = 0; i < tab1.Length; i++)
                {
                    Console.Write(tab1[i] + ", ");
                }
                Console.WriteLine();

                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Wariant B) ");
                
                zadanie5_4b(tab1, n);

                Console.WriteLine("Wariant A) ");

                tab1 = zadanie5_4a(tab1, n);
                for(int i = 0; i < tab1.Length; i++)
                {
                    Console.Write(tab1[i] + ", ");
                }
                Console.WriteLine();
            }

            static void zadanie5_5a(int dlug, int szer)
            {
                for (int i = 0; i < dlug; i++)
                {
                    for (int j = 0; j < szer; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            static void zadanie5_5() 
            {
                Console.WriteLine("Podaj dlugosc: ");
                int dlug = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Podaj szerokosc: ");
                int szer = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                zadanie5_5a(dlug, szer);
                Console.WriteLine();
                zadanie5_5a(szer, dlug);
            }

            static void zadanie5_6a(string[] tab1, int x)
            {
                Console.WriteLine("\nKonkatencja:");
                for (int i = 0; i < tab1.Length; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        Console.Write(tab1[i]);
                    }
                    Console.Write(" ");
                }
            }

            static void zadanie5_6()
            {
                Console.WriteLine("Podaj 3 wyrazy:");
                string[] tab1 = new string[3];

                for (int i = 0; i < tab1.Length; i++)
                {
                    tab1[i] = Console.ReadLine();
                }

                Console.WriteLine("Podaj mnoznik:");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Twoje wyrazy:");
                for (int i = 0; i < tab1.Length; i++)
                {
                    Console.Write(tab1[i] + " ");
                }

                zadanie5_6a(tab1, x);
            }

            static void zadanie5_7a(int x, int n)
            {
                int wzor = (2 * x + 1 + n) * n / 2;
                Console.WriteLine("Wynik: {0}", wzor);
            }

            static void zadanie5_7()
            {
                Console.WriteLine("Podaj x dla ciagu W = (x+1) + (x+2) + (x+3) +.......+ (x+n)");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Podaj n dla W = (x+1) + (x+2) + (x+3) +.......+ (x+n)");
                int n = Convert.ToInt32(Console.ReadLine());

                zadanie5_7a(x, n);
            }

            static void zadanie5_8a(string liczba)
            {
                int suma = 0;
                for (int i = 0; i < liczba.Length; i++)
                {
                    suma += Convert.ToInt32(liczba[i].ToString());
                }
                Console.WriteLine("Suma cyfr liczby {0} wynosi {1}", liczba, suma);
            }

            static void zadanie5_8()
            {
                Console.WriteLine("Podaj liczbe calkowita wielocyfrowa");
                string liczba = Console.ReadLine();
                zadanie5_8a(liczba);
            }

            static int rekurencja(int n)
            {
                if ((n == 1) || (n == 2))
                    return 1;
                else
                    return rekurencja(n - 1) + rekurencja(n - 2);
            }

            static int iteracja(int n)
            {
                int a = 0;
                int b = 1;
                for (int i = 0; i < n; i++)
                {
                    b += a;
                    a = b - a;
                }
                return a;
            }

            static void zadanie5_9()
            {
                int n;

                Console.WriteLine("Podaj ktory wyraz ciagu Fibonacciego obliczyc");
                n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0} wyraz ciagu Fibonacciego: {1}", n, rekurencja(n));
                Console.WriteLine("{0} wyraz ciagu Fibonacciego: {1}", n, iteracja(n));
            }


            static int zadanie5_10a(int n)
            {
                if (n <= 1) return (1);
                else return (n + zadanie5_10a(n - 1));
            }

            static void zadanie5_10()
            {
                Console.WriteLine(zadanie5_10a(5));
            }

            //zadanie5_1();
            //zadanie5_2();
            //zadanie5_3();
            //zadanie5_4();
            //zadanie5_5();
            //zadanie5_6();
            //zadanie5_7();
            //zadanie5_8();
            //zadanie5_9();
            //zadanie5_10();
        }
    }
}
