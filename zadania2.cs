﻿using System.Runtime.InteropServices;

namespace zadania_2
{
    internal class zadania2
    {
        static void Main(string[] args)
        {
            OcenyPozytywne();
            //Lokata();
            //Silnia();
            //MinMax5();
            //Pierwsza();
         
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
        static void Pierwsza()
        {
            Console.WriteLine("Podaj liczbe calkowita:");
            int liczba = Convert.ToInt32(Console.ReadLine());
            if (liczba < 2)
            {
                Console.WriteLine("Nie jest to liczba pierwsza");
                return;
            }
            for(int i = 2; i < liczba; i++)
            {
                if(liczba%i == 0) {
                    Console.WriteLine("Ta liczba nie jest pierwsza");
                    return;
                }
            }
            Console.WriteLine("Ta liczba jest pierwsza");
         
        }
    }
}