namespace FormattaPrezzo;

class Program
{
    static void Main(string[] args)
    {
        // 1) Leggi un prezzo (double) con TryParse
        Console.Write("Inserisci un prezzo: ");
        string? rawPrezzo = Console.ReadLine();

        if (!double.TryParse(rawPrezzo, out double prezzo))
        {
            Console.WriteLine("Inserisci un prezzo valido");
            Console.WriteLine("Premi 'Invio' per continuare");
            Console.ReadLine();
            return;
        }

        // 2) Leggi una scelta (es. 1=Euro davanti, 2=Euro dietro)
        Console.Write("Digita 1=>(€ davanti) o 2 =>(EUR dietro): ");
        string? raw = Console.ReadLine();

        if (!int.TryParse(raw, out int euro))
        {
            Console.WriteLine("Inserisci un numero valido");
            Console.WriteLine("Premi 'Invio' per continuare");
            Console.ReadLine();
            return;
        }

        // (consigliato) valida che sia proprio 1 o 2
        if (euro != 1 && euro != 2)
        {
            Console.WriteLine("Scelta non valida: inserisci 1 o 2");
            Console.WriteLine("Premi 'Invio' per continuare");
            Console.ReadLine();
            return;
        }

        // 3) Chiama FormattaPrezzo(prezzo, euroDavanti)
        bool euroDavanti = (euro == 1);
        string testo = FormattaPrezzo(prezzo, euroDavanti);

        // 4) Stampa la stringa formattata
        Console.WriteLine(testo);
    }

    static string FormattaPrezzo(double prezzo, bool euroDavanti)
    {
        // TODO:
        if (euroDavanti)
        {
            // if(euroDavanti) return "€..."
            return "€" + prezzo;
        }
        else
        {
            // else return "... EUR"
            return prezzo + " EUR";
        }
    }
}