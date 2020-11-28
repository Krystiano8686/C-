using System;

namespace Kolokwium_wariant2
{
    class Program
    {
        static void Main(string[] args)
        {

            double rown(double a, double b)
            {
                double x0;
                if (a == 0 && b != 0)
                {
                    Console.WriteLine("Funkcja nie ma rozwiazan");
                    return 0;
                } else if (a == 0 && b == 0)
                {
                    Console.WriteLine("Funkcja ma nieskonczenie wiele rozwiazan");
                    return 0;
                } else
                {
                    x0 = ((3 * b) / (2 * a));
                    Console.WriteLine("Rozwiazanie funkcji liniowej jest x0 = " + x0);
                    return x0;
                }

            }


            void zadanie_1()
            {
                double a, b;
                Console.WriteLine("Podaj wspolczynniki a i b: ");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());

                rown(a, b);

            }

            /*
            int[] tab2d(int n)
            {
                int[,] tabA = new int[n, n];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        tabA[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                return tabA;
            }
            */

            void zadanie_2()
            {
                int n;
                Console.WriteLine("Podaj n: ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n <= 10)
                {
                     //tab2d(n);
                }
                else if (n > 10)
                {
                    while (n > 10) {
                        Console.WriteLine("Zle podaj n jeszcze raz: ");
                        n = Convert.ToInt32(Console.ReadLine());
                    }
                }


            }


            void zadanie_3() {
                int n, p = 0, np = 0; // p = parzyste np = nieparzyste
                Console.WriteLine("Podaj liczbe n:  (ktora symbolizuje ilosc liczb ktore zostanie wpisane przez uzytkownika)");
                n = Convert.ToInt32(Console.ReadLine());
                int[] tab = new int[n];

                Console.WriteLine();

                for (int i = 0; i < n; i++)
                {
                    tab[i] = Convert.ToInt32(Console.ReadLine());

                    if (tab[i] > 0)
                    {
                        if (tab[i] % 2 == 0)
                        {
                            p++;
                        }
                        else
                        {
                            np++;
                        }
                    }                    
                }

                Console.WriteLine("Liczb parzystych jest: " + p + " a liczb nieparzystych: " + np);
            }


            zadanie_1();
            //zadanie_2();
            zadanie_3();


         
        }
    }
}
