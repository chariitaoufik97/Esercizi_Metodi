namespace BancomatRestoGreedy;

class Program
{
    static void Main(string[] args)
    {
        // 1) Leggi importo valido (multiplo di 10, range a scelta)
        // 2) Definisci tagli NON ordinati (es. {20,10,50})
        // 3) Ordina tagli in decrescente con Ordinatore(tagli, true)
        // 4) Calcola quante banconote per ogni taglio (greedy)
        // 5) Stampa "taglio€ x quantità"
        // 6) Se resta qualcosa (rimanente != 0) stampa messaggio
    }

    static int LeggiImportoValido(int min, int max)
    {
        // TODO:
        // - while(true)
        // - TryParse
        // - range
        // - multiplo di 10
        // - return importo
        return 0;
    }

    static int[] Ordinatore(int[] tagli, bool desc)
    {
        // TODO:
        // - selection sort (come hai fatto)
        // - return tagli
        return tagli;
    }

     static void StampaTagliErogati(int importo, int[] tagli)
    {
        // TODO:
        // - rimanente = importo
        // - for sui tagli
        // - q = rimanente / taglio
        // - se q>0 stampa
        // - rimanente = rimanente % taglio
    }
}
