namespace SommaDueNumeri;

class Program
{
    static void Main(string[] args)
    {
        // 1) Leggi due numeri da console (string? + TryParse)
        Console.Write("Digita 1° Numero:");
        string? primo = Console.ReadLine();

        if(!int.TryParse(primo, out int num1))
        {
            Console.WriteLine("Digita un numero valido!");
            Console.WriteLine("Premi INVIO per continuare");
            Console.ReadLine();
            return;
        }

        Console.Write("Digita 2° Numero:");
        string? secondo = Console.ReadLine();

        if(!int.TryParse(secondo, out int num2))
        {
            Console.WriteLine("Digita un numero valido!");
            Console.WriteLine("Premi INVIO per continuare");
            Console.ReadLine();
            return;
        }
        // 2) Chiama Somma(a, b)
        int risultato = Somma(num1, num2);

        // 3) Stampa il risultato
        Console.WriteLine($"{num1} + {num2} = {risultato}");
        Console.ReadLine();
    }

    static int Somma(int a, int b)
    {
        // TODO: ritorna a + b
        return a + b;
    }
}
