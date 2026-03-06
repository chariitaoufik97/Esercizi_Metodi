namespace InputInRange;

class Program
{
    static void Main(string[] args)
    {
        // 1) Chiama LeggiInteroInRange(1, 10)
        int input = LeggiInteroInRange(1, 10);
        // 2) Stampa il numero letto
        Console.WriteLine($"Hai inserito: {input}");
    }

    static int LeggiInteroInRange(int min, int max)
    {
        // TODO:
        // while(true)
        while (true)
        {
            //   - chiedi input
            Console.Write($"Inserisci un numero tra {min} e {max}: ");
            string? raw = Console.ReadLine();

            //   - TryParse
            if (!int.TryParse(raw, out int num))
            {
                Console.WriteLine("Digita un numero valido!");
                Console.WriteLine("Premi INVIO per continuare");
                Console.ReadLine();
                continue;
            }
            //   - controlla range min..max
            if (num < min || num > max)
            {
                Console.WriteLine("Digita un numero valido!");
                Console.WriteLine("Premi INVIO per continuare");
                Console.ReadLine();
                continue;
            }

            //   - se ok return numero
            return num;
        }

    }
}
