namespace zadania_2
{
    internal class zadania2
    {
        static void Main(string[] args)
        {
            OcenyPozytywne();
        }
        static void OcenyPozytywne()
        {
            int suma = 0;
            int ocena;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Podaj ocenę: ");
                ocena = Convert.ToInt32(Console.ReadLine());
                suma += ocena;
            }
            double srednia = suma / (double)5;
            Console.WriteLine("Śrenia z ocen wynosi: {0:N}", srednia);

        }
    }
}