namespace BancomatRestoGreedy;

class Program
{
    static void Main(string[] args)
    {
        // STEP 1) Leggi importo valido (range + multiplo di 10)
        int importoInserito = LeggiImportoValido(10, 999);

        // STEP 2) Definisci tagli NON ordinati
        int[] tagliDisp = { 50, 10, 100, 20 };

        // STEP 3) Ordina i tagli in decrescente (per greedy: prima i tagli grandi)
        tagliDisp = Ordinatore(tagliDisp, true);

        // STEP 4-6) Calcola e stampa i tagli erogati (e messaggio se resta rimanente)
        StampaTagliErogati(importoInserito, tagliDisp);

        Console.WriteLine("\nOperazione terminata. Premi INVIO per uscire.");
        Console.ReadLine();
    }

    static int LeggiImportoValido(int min, int max)
    {
        // Legge un intero finché:
        // - è un numero
        // - è nel range min..max
        // - è multiplo di 10
        while (true)
        {
            Console.Clear();
            Console.Write($"Digita un importo ({min}..{max}) multiplo di 10: ");
            string? raw = Console.ReadLine();

            if (!int.TryParse(raw, out int input))
            {
                Console.WriteLine("Numero inserito non valido!");
                Console.WriteLine("Premi INVIO e riprova.");
                Console.ReadLine();
                continue;
            }

            if (input < min || input > max)
            {
                Console.WriteLine("Importo fuori range.");
                Console.WriteLine("Premi INVIO e riprova.");
                Console.ReadLine();
                continue;
            }

            if (input % 10 != 0)
            {
                Console.WriteLine("Importo non valido: deve essere multiplo di 10.");
                Console.WriteLine("Premi INVIO e riprova.");
                Console.ReadLine();
                continue;
            }

            return input; // valido: esco dal metodo
        }
    }

    static int[] Ordinatore(int[] tagli, bool desc)
    {
        // Selection Sort:
        // - per ogni posizione i, cerca il migliore nel resto dell'array
        // - se desc=true: migliore = più grande (ordine decrescente)
        // - se desc=false: migliore = più piccolo (ordine crescente)
        for (int i = 0; i < tagli.Length - 1; i++)
        {
            int BestIndex = i;

            for (int j = i + 1; j < tagli.Length; j++)
            {
                if (desc == true)
                {
                    if (tagli[j] > tagli[BestIndex])
                        BestIndex = j;
                }
                else
                {
                    if (tagli[j] < tagli[BestIndex])
                        BestIndex = j;
                }
            }

            // swap: sposto il migliore in posizione i
            if (BestIndex != i)
            {
                int temp = tagli[i];
                tagli[i] = tagli[BestIndex];
                tagli[BestIndex] = temp;
            }
        }

        return tagli;
    }

    static void StampaTagliErogati(int importo, int[] tagli)
    {
        // Greedy: provo i tagli dal più grande al più piccolo
        int rimanente = importo;

        Console.Clear();
        Console.WriteLine($"Erogazione di {importo}€ in corso...\n");
        Console.WriteLine("Tagli erogati:");

        for (int i = 0; i < tagli.Length; i++)
        {
            int taglio = tagli[i];

            // quante banconote di questo taglio posso dare?
            int q = rimanente / taglio;

            if (q > 0)
            {
                Console.WriteLine($"{taglio}€ x {q}");
                rimanente = rimanente % taglio; // aggiorno il residuo
            }
        }

        // Se non sono riuscito a fare il totale esatto con questi tagli
        if (rimanente != 0)
        {
            Console.WriteLine($"\nATTENZIONE: non posso erogare esattamente l'importo. Residuo: {rimanente}€");
        }
        else
        {
            Console.WriteLine("\nErogazione completata!");
        }
    }
}