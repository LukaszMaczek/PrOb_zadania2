using System.Runtime.InteropServices;

namespace zadania_2
{
    internal class zadania2
    {
        static void Main(string[] args)
        {
            //OcenyPozytywne();
            //Lokata();
            //Silnia();
            //MinMax5();
            //Skoki();
            //Pierwsza();
            Wszystkie_Pierwsze();
            //Newton();
         
        }
        static void OcenyPozytywne()
        {
            int suma = 0;
            int ocena;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Podaj ocenę:");
                if (int.TryParse(Console.ReadLine(), out ocena))
                {
                    if (ocena >= 3 && ocena <= 5)
                    {
                        suma += ocena;
                    }
                    else
                    {
                        Console.WriteLine("Ocena negatywna lub poza mozliwymi do uzyskania");
                        i--;
                    }
                }
            }
            double srednia = suma / (double)10;
            Console.WriteLine("Śrenia z ocen wynosi: {0:N}", srednia);

        }

        static void Lokata()
        {
            Console.WriteLine("Podaj kwote lokaty:");
            double lok = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj ilosc lat:");
            int lata = Convert.ToInt32(Console.ReadLine());
            double finalna = lok;
            for (int i = 0;i < lata; i++)
            {
                finalna += lok * 0.06;
            }
            Console.WriteLine("Kwota finalna po {0} latach wynosi {1}", lata, finalna);
        }

        static void MinMax5()
        {
            int[] a = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Podaj liczbe: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = a[1], max = a[1];
            for(int i = 1;i < 5; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
                else if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine("Liczba maksymalna wynosi {0}, a minimalna {1}", max, min);
        }

        static void Skoki()
        {
            Console.WriteLine("Podaj dlugosc skoku:");
            int pd1 = Convert.ToInt32(Console.ReadLine());
            int[] ps1 = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Podaj ocene jury z przedziału od 0 do 20:");
                ps1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(ps1);
            int ps = ps1[2] + ps1[3] + ps1[4];
            double pd = 60 + (pd1 - 120) * 1.8;
            double ocena = ps + pd;
            Console.WriteLine("Ocena za skok wynosi: {0}", ocena);
        }
        static void Silnia()
        {
            Console.WriteLine("Podaj liczbe naturalna, z ktorej chcesz obliczyc silnie: ");
            int silnia = Convert.ToInt32(Console.ReadLine());
            int i = silnia;
            if (silnia > 0)
            {
                while (i > 1)
                {
                    silnia = silnia * (i - 1);
                    i--;
                }
            }
            else if(silnia == 0)
            {
                silnia = 1;
            }
            else { 
                Console.WriteLine("Zla liczba");
                return;
            }
              Console.WriteLine("Wynik wynosi: {0}", silnia);

        }
        static bool CzyPierwsza(int liczba)
        {
            if (liczba < 2)
            {
                return false;
            }
            for(int i = 2; i < liczba; i++)
            {
                if(liczba%i == 0) {
                    return false;
                }
            }
            return true;
         
        }

        static void Pierwsza()
        {
            Console.WriteLine("Podaj liczbe calkowita:");
            int liczba = Convert.ToInt32(Console.ReadLine());
            if (CzyPierwsza(liczba))
            {
                Console.WriteLine("Ta liczba jest pierwsza");
            }
            else
            {
                Console.WriteLine("Ta liczba nie jest pierwsza");
            }
        }


        static void Wszystkie_Pierwsze()
        {
            Console.WriteLine("Podaj pierwsza liczbe calkowita:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe calkowita, wieksza niz pierwsza:");
            int b = Convert.ToInt32(Console.ReadLine());
            for(int i = a; i <= b; i++)
            {
                if (CzyPierwsza(i))
                {
                    Console.WriteLine("Liczba {0} jest pierwsza w tym przedziale", i);
                }
            }

        }
        static void Newton()
        {
            double wynik;
            Console.WriteLine("Podaj n z symbolu Newtona:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj k z symbolu Newtona:");
            int k = Convert.ToInt32(Console.ReadLine());
            int silnia_n = n, silnia_k = k, silnia_nk = n - k;
            int i_n = silnia_n, i_k = silnia_k, i_nk = silnia_nk;
            if(n <= k)
            {
                Console.WriteLine("Bledne dane");
                return;
            }
           while(i_n > 1)
            {
                silnia_n = silnia_n * (i_n - 1);
                i_n--;
            }
           while(i_k > 1)
            {
                silnia_k = silnia_k * (i_k - 1);
                i_k--;
            }
           while(i_nk > 1)
            {
                silnia_nk = silnia_nk * (i_nk - 1);
                i_nk--;
            }
            wynik = silnia_n / (silnia_k * silnia_nk);
            Console.WriteLine("Wynik wynosi {0:0.00}", wynik);
        }
    }
}