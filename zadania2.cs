using System.Runtime.InteropServices;

namespace zadania_2
{
    internal class zadania2
    {
        static void Main(string[] args)
        {
            //OcenyPozytywne();
            //Silnia();
            MinMax5();
        }
        static void OcenyPozytywne()
        {
            int suma = 0;
            int ocena;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Podaj ocenę: ");
                if (int.Parse(Console.ReadLine()) >= 3) 
                {
                    ocena = Convert.ToInt32(Console.ReadLine());
                    suma += ocena;
                }
                else 
                { 
                    Console.WriteLine("Ocena negatywna lub poza mozliwymi do uzyskania");
                }
            }
            double srednia = suma / (double)5;
            Console.WriteLine("Śrenia z ocen wynosi: {0:N}", srednia);

        }

        static void Lokata()
        {

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
    }
}